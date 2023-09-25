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
        }

        private void FormAtualizarModalidade_Load(object sender, EventArgs e)
        {
            int index = cbxModalidade.SelectedIndex;
            Modalidade mod = new Modalidade(cbxModalidade.Text, float.Parse(txtPreco.Text), int.Parse(txtQtdAlunos.Text), int.Parse(txtQtdAulas.Text)); 
            MySqlDataReader reader = mod.consultarModalidade(index + 1);

            if(mod.atualizarModalidade(index = 1))
            {
                //MessageBox.Show() //Continuar daqui
            }
        }

        private void cbxModalidade_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cbxModalidade.SelectedIndex;
            Modalidade mod = new Modalidade();
            MySqlDataReader reader = mod.consultarModalidade(index + 1);

            while (reader.Read())
            {
                txtPreco.Text = reader["precoModalidade"].ToString(); //Por algum motivo o banco de dados sql não está armazenando o número como float (a virgula n aparece lol)
                txtQtdAlunos.Text = reader["qtdeAlunos"].ToString();
                txtQtdAulas.Text = reader["qtdeAulas"].ToString();
            }
            DAO_Conexao.con.Close();
        }
    }
}
