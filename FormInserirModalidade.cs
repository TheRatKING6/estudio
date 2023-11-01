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
    public partial class FormInserirModalidade : Form
    {
        public FormInserirModalidade()
        {
            InitializeComponent();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            Modalidade mod = new Modalidade(txtDescricao.Text, float.Parse(txtPreco.Text), int.Parse(txtQtdAlunos.Text), int.Parse(txtQtdAulas.Text));

            MySqlDataReader existe = mod.consultarNomeModalidade();

            

            if (existe.Read())
            {
                MessageBox.Show("Já existe uma modalidade cadastrada com essa descrição!");
            }
            else
            {
                DAO_Conexao.con.Close();
                if (mod.cadastrarModalidade())
                {
                    MessageBox.Show("Modalidade cadastrada com sucesso!");
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar");
                }
            }

            

            txtDescricao.Text = null;
            txtPreco.Text = null;
            txtQtdAlunos.Text = null;
            txtQtdAulas.Text = null;
        }

        private void FormInserirModalidade_Load(object sender, EventArgs e)
        {

        }
    }
}
