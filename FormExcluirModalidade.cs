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
    public partial class FormExcluirModalidade : Form
    {
        public FormExcluirModalidade()
        {
            InitializeComponent();
            Modalidade mod = new Modalidade();
            MySqlDataReader dr = mod.consultarTodasModalidade();

            while (dr.Read())
            {
                cbxModalidades.Items.Add(dr["descricaoModalidade"].ToString());
            }
            DAO_Conexao.con.Close();

        }

        private void FormExcluirModalidade_Load(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int index = cbxModalidades.SelectedIndex;
            Modalidade mod = new Modalidade();

            if(mod.excluirModalidade(index + 1))
            {
                MessageBox.Show("Modalidade excluida com sucesso");
            }
            else
            {
                MessageBox.Show("Erro ao excluir modalidade");
            }
        }
    }
}
