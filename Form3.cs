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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void maskedTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Aluno aluno = new Aluno(maskedTextBox1.Text);

            if(e.KeyChar == 13)
            {
               
                if (aluno.consultarAluno())
                {
                    MessageBox.Show("Aluno já está cadastrado!");
                    textBox2.Enabled = false;
                    textBox3.Enabled = false;
                    textBox4.Enabled = false;
                    textBox7.Enabled = false;
                    textBox8.Enabled = false;
                    textBox9.Enabled = false;
                    textBox10.Enabled = false;
                    textBox11.Enabled = false;
                    maskedTextBox2.Enabled = false;
                    maskedTextBox3.Enabled = false;
                }
                else
                {
                    textBox2.Focus();
                    textBox2.Enabled = true;
                    textBox3.Enabled = true;
                    textBox4.Enabled = true;
                    textBox7.Enabled = true;
                    textBox8.Enabled = true;
                    textBox9.Enabled = true;
                    textBox10.Enabled = true;
                    textBox11.Enabled = true;
                    maskedTextBox2.Enabled = true;
                    maskedTextBox3.Enabled = true;
                }
                
                
                

                //DAO_Conexao.con.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Aluno aluno = new Aluno(maskedTextBox1.Text, textBox2.Text, textBox3.Text, textBox9.Text, textBox4.Text, textBox10.Text, maskedTextBox2.Text, textBox7.Text, textBox11.Text, maskedTextBox3.Text, textBox8.Text);

            if (aluno.verificaCPF())
            {
                if (aluno.cadastrarAluno())
                {
                    MessageBox.Show("Cadastro Realizado com sucesso!");
                }
                else
                {
                    MessageBox.Show("Erro no cadastro");
                }
            }
            else
            {
                MessageBox.Show("O CPF que você está tentando cadastrar é inválido");
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Aluno aluno = new Aluno(maskedTextBox1.Text, textBox2.Text, textBox3.Text, textBox9.Text, textBox4.Text, textBox10.Text, maskedTextBox2.Text, textBox7.Text, textBox11.Text, maskedTextBox3.Text, textBox8.Text);

            if (aluno.consultarAluno())
            {
                MySqlDataReader reader = aluno.consultarDadosAluno();

                int ativo = -1;

                while (reader.Read())
                {
                    ativo = int.Parse(reader["ativo"].ToString());
                }
                DAO_Conexao.con.Close();
                if(ativo == 0)
                {
                    if (aluno.atualizarAluno())
                    {
                        MessageBox.Show("Dados atualizados com sucesso!");
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível atualizar os dados desse aluno");
                    }
                }
                else if(ativo == 1)
                {
                    DialogResult ativar = MessageBox.Show("Este aluno está desativado. Deseja reativá-lo","", MessageBoxButtons.YesNo);
                    if(ativar == DialogResult.Yes)
                    {
                        if (aluno.reativarAluno() && aluno.atualizarAluno())
                        {
                            MessageBox.Show("Aluno atualizado e reativado com sucesso!");
                        }
                        else
                        {
                            MessageBox.Show("Erro ao atualizar ou reativar o aluno");
                        }
                    }
                    else
                    {
                        if (aluno.atualizarAluno())
                        {
                            MessageBox.Show("Dados atualizados com sucesso!");
                        }
                        else
                        {
                            MessageBox.Show("Não foi possível atualizar os dados desse aluno");
                        }
                    }
                }
                
            }
            else
            {
                MessageBox.Show("Não é possível atualizar um aluno que ainda não foi cadastrado");
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
