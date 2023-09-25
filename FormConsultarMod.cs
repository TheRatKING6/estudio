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
    public partial class FormConsultarMod : Form
    {
        public FormConsultarMod()
        {
            
            InitializeComponent();
            Modalidade mod = new Modalidade();
            MySqlDataReader dr = mod.consultarTodasModalidade();

            while (dr.Read())
            {
                cbxModalidade.Items.Add(dr["descricaoModalidade"].ToString());
            }
            DAO_Conexao.con.Close();

            txtPreco.Enabled = false;
            txtQtdAlunos.Enabled = false;
            txtQtdAulas.Enabled = false;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
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
