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
    public partial class FormConsultarTurma : Form
    {
        public FormConsultarTurma()
        {
            InitializeComponent();
            Modalidade mod = new Modalidade();
            Turma tr = new Turma();

            MySqlDataReader rd = mod.consultarTodasModalidade();
            

            while (rd.Read())
            {
                if (!(rd["ativa"].ToString() == "1"))
                {
                    cbxModaliade.Items.Add(rd["descricaoModalidade"].ToString());
                }

            }

            DAO_Conexao.con.Close();

            MySqlDataReader rdTurma = tr.consultarTurma();

            while (rdTurma.Read())
            {
                cbxDia.Items.Add(rdTurma["diaSemanaTurma"].ToString());
                cbxHora.Items.Add(rdTurma["horaTurma"].ToString());
            }
            DAO_Conexao.con.Close();

            cbxModaliade.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxHora.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxDia.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void FormConsultarTurma_Load(object sender, EventArgs e)
        {

        }

        private void btnConsultarTurma_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(cbxModaliade.Text) || String.IsNullOrEmpty(cbxDia.Text) || String.IsNullOrEmpty(cbxHora.Text))
            {
                MessageBox.Show("Por favor preencha o9s 3 campos antes de iniciar a busca");
            }
            else
            {
                //PEga o id da modalidade para poder excluir a turma
                Modalidade mod = new Modalidade(cbxModaliade.Text);

                int idModalidade = 0;

                MySqlDataReader reader = mod.consultarNomeModalidade();

                while (reader.Read())
                {
                    idModalidade = int.Parse(reader["idEstudio_Modalidade"].ToString());
                }

                DAO_Conexao.con.Close();

                string professor = "";
                string diaSemana = cbxDia.Text;
                string hora = cbxHora.Text;

                Turma t1 = new Turma(professor, diaSemana, hora, idModalidade);

                MySqlDataReader consulta = t1.consultarTurma01();

                if (consulta.Read())
                {
                    DAO_Conexao.con.Close();

                    consulta = t1.consultarTurma01();
                    while (consulta.Read())
                    {
                        //consulta["idTurma"].ToString(), cbxModalidade.Text, consulta["ProfessorTurma"].ToString(), cbxDia.Text, cbxHora.Text, consulta["nAlunosTurma"].ToString()

                        lbxTurmas.Items.Add("ID: " + consulta["idEstudio_Turma"].ToString() + " / Modalidade: " + cbxModaliade.Text + " / Professor: " + consulta["ProfessorTurma"].ToString() + " / Dias da semana: " + cbxDia.Text + " / Horario: " + cbxHora.Text + " / Num madx de alunos: " + consulta["nAlunosTurma"].ToString());
                    }
                }
                else
                {
                    MessageBox.Show("Nao foi encontrada nenhuma turma com essas informações");
                }

                DAO_Conexao.con.Close();

            }
        }
    }
}
