﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace estudio
{
    public partial class FormAtualizarTurma : Form
    {
        public FormAtualizarTurma()
        {
            InitializeComponent();
            Modalidade mod = new Modalidade();

            MySqlDataReader rd = mod.consultarTodasModalidade();

            while (rd.Read())
            {
                if (!(rd["ativa"].ToString() == "1"))
                {
                    cbxModaliade.Items.Add(rd["descricaoModalidade"].ToString());
                }

            }

            DAO_Conexao.con.Close();

            cbxModaliade.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxHora.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxDia.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxProfessor.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxQtdAluno.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void FormAtualizarTurma_Load(object sender, EventArgs e)
        {

        }

        private void cbxModaliade_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Limpa os items dentro do comboBox
            cbxDia.Items.Clear();
            cbxHora.Items.Clear();
            cbxProfessor.Items.Clear();
            cbxQtdAluno.Items.Clear();

            //Pega o id da modalidade selecionada
            Modalidade mod = new Modalidade(cbxModaliade.Text);

            MySqlDataReader reader = mod.consultarNomeModalidade();

            int idModalidade = 0;

            while (reader.Read())
            {
                idModalidade = int.Parse(reader["idEstudio_Modalidade"].ToString());
            }

            DAO_Conexao.con.Close();


            //Pega todas as turmas com a modalidade selecionada
            Turma t1 = new Turma(idModalidade);

            reader = t1.consultarDiaSemana();

            while (reader.Read())
            {
                cbxDia.Items.Add(reader["diaSemanaTurma"].ToString()); //joga os dias da semana no comboBox
            }

            DAO_Conexao.con.Close();
        }

        private void cbxDia_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Limpa os items dentro do comboBox
            cbxHora.Items.Clear();
            cbxProfessor.Items.Clear();
            cbxQtdAluno.Items.Clear();

            //Pega o id da modalidade selecionada
            Modalidade mod = new Modalidade(cbxModaliade.Text);

            MySqlDataReader reader = mod.consultarNomeModalidade();

            int idModalidade = 0;
            string diasSemana = null;

            while (reader.Read())
            {
                idModalidade = int.Parse(reader["idEstudio_Modalidade"].ToString());
            }

            DAO_Conexao.con.Close();


            //Pega todas as turmas com a modalidade e dia selecionados

            diasSemana = cbxDia.Text;
            Turma t1 = new Turma(idModalidade, diasSemana);

            reader = t1.consultarHoras();

            while (reader.Read())
            {
                cbxHora.Items.Add(reader["horaTurma"].ToString()); //e joga os horários das turmas encontradas na comboBox
            }

            DAO_Conexao.con.Close();
        }

        private void cbxHora_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Limpa os items dentro do comboBox
            cbxProfessor.Items.Clear();
            cbxQtdAluno.Items.Clear();

            //Pega o id da modalidade selecionada
            Modalidade mod = new Modalidade(cbxModaliade.Text);

            MySqlDataReader reader = mod.consultarNomeModalidade();

            int idModalidade = 0;

            while (reader.Read())
            {
                idModalidade = int.Parse(reader["idEstudio_Modalidade"].ToString());
            }

            DAO_Conexao.con.Close();

            //terminar de consultar tudo pra poder atualizar;
        }
    }
}