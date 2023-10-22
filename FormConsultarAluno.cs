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
    public partial class FormConsultarAluno : Form
    {
        public FormConsultarAluno()
        {
            InitializeComponent();

            txtBairro.Enabled = false;
            txtCidade.Enabled = false;
            txtComp.Enabled = false;
            txtEmail.Enabled = false;
            txtEnd.Enabled = false;
            txtEstado.Enabled = false;
            txtNome.Enabled = false;
            txtNum.Enabled = false;
            mskCep.Enabled = false;
            mskTel.Enabled = false;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Aluno aluno = new Aluno(mskCpf.Text);

            if (aluno.consultarAluno())
            {
                MySqlDataReader reader = aluno.consultarDadosAluno();

                while (reader.Read())
                {
                    if(int.Parse(reader["ativo"].ToString()) == 0)
                    {
                        txtBairro.Text = reader["bairroAluno"].ToString();
                        txtEnd.Text = reader["ruaAluno"].ToString();
                        txtCidade.Text = reader["cidadeAluno"].ToString();
                        txtNome.Text = reader["nomeAluno"].ToString();
                        txtNum.Text = reader["numeroAluno"].ToString();
                        txtComp.Text = reader["complementoAluno"].ToString();
                        mskCep.Text = reader["CEPAluno"].ToString();
                        txtEstado.Text = reader["estadoAluno"].ToString();
                        mskTel.Text = reader["telefoneAluno"].ToString();
                        txtEmail.Text = reader["emailAluno"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("O aluno pelo qual você está buscando não está mais ativo");
                    }
                }
                DAO_Conexao.con.Close();
            }
            else
            {
                MessageBox.Show("Não exite nenhum aluno cadastrado com esse cpf");
            }
        }

        private void FormConsultarAluno_Load(object sender, EventArgs e)
        {
            


        }
    }
}
