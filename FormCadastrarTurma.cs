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
    public partial class FormCadastrarTurma : Form
    {
        public FormCadastrarTurma()
        {
            InitializeComponent();
            Modalidade mod = new Modalidade();
            MySqlDataReader reader = mod.consultarTodasModalidade();

            while (reader.Read())
            {
                dataGridViewMod.Rows.Add(reader["descricaoModalidade"].ToString());
            }
            DAO_Conexao.con.Close();
        }

        private void FormCadastrarTurma_Load(object sender, EventArgs e)
        {

        }

        private void dataGridViewMod_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string modalidade = null;
            try
            {
                modalidade = dataGridViewMod.CurrentCell.Value.ToString();  //Por algum motivo isso tá dando erro mesmo com o try-catch. ??????????????????
            }
            catch(NullReferenceException ex)
            {
                MessageBox.Show("Você precisa selecionar entre as modalidades existentes!");
            }
            
            txtModalidade.Text = modalidade;
        }
    }
}
