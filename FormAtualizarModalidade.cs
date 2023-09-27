using MySql.Data.MySqlClient;
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
    public partial class FormAtualizarModalidade : Form
    {
        public FormAtualizarModalidade()
        {
            InitializeComponent();
            Modalidade mod = new Modalidade();
            MySqlDataReader dr = mod.consultarTodasModalidade();

            while (dr.Read())
            {
                cbxModalidade.Items.Add(dr["descricaoModalidade"].ToString());
            }
            DAO_Conexao.con.Close();
            btnAtivar.Visible = false;
        }

        private void FormAtualizarModalidade_Load(object sender, EventArgs e)
        {
            
        }

        private void cbxModalidade_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cbxModalidade.SelectedIndex;
            Modalidade mod = new Modalidade();
            MySqlDataReader reader = mod.consultarModalidade(index + 1);
            int ativo = 0;

            while (reader.Read())
            {
                txtPreco.Text = reader["precoModalidade"].ToString(); //Por algum motivo o banco de dados sql não está armazenando o número como float (a virgula n aparece lol)
                txtQtdAlunos.Text = reader["qtdeAlunos"].ToString();
                txtQtdAulas.Text = reader["qtdeAulas"].ToString();
                ativo = int.Parse(reader["ativa"].ToString());
            }
            DAO_Conexao.con.Close();

            if(ativo == 1)
            {
                btnAtivar.Visible = true;
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            Modalidade mod = new Modalidade(cbxModalidade.Text, float.Parse(txtPreco.Text), int.Parse(txtQtdAlunos.Text), int.Parse(txtQtdAulas.Text));

            int index = cbxModalidade.SelectedIndex;

            if (mod.atualizarModalidade(index + 1))
            {
                MessageBox.Show("Modalidades Atualizada com sucesso");
            }
            else
            {
                MessageBox.Show("Erro ao atualizar a modalidade");
            }
        }

        private void btnAtivar_Click(object sender, EventArgs e)
        {
            int index = cbxModalidade.SelectedIndex;

            Modalidade mod = new Modalidade();

            if(mod.ativarModalidade(index + 1))
            {
                MessageBox.Show("Modalidade reativada com sucesso");
            }
            else
            {
                MessageBox.Show("Erro ao reativar modalidade");
            }

            btnAtivar.Visible = false;
        }
    }
}
