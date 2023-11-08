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
    public partial class FormCadastrarAlunoTurma : Form
    {

        Turma turmaBuscar;
        public FormCadastrarAlunoTurma()
        {
            InitializeComponent();
            //coloca todas as modalidades no comboBox
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

            Aluno al = new Aluno();

            rd = al.consultarTodosAlunos();
            //verifica se os alunos estao ativos e coloca o nome + o cpf deles na comboBox
            while (rd.Read())
            {
                string nomecpf = String.Empty;

                if (!(rd["ativo"].ToString() == "1"))
                {
                    nomecpf = rd["CPFAluno"].ToString() + " - " + rd["nomeAluno"].ToString();
                    cbxAluno.Items.Add(nomecpf);
                }

               
            }

            DAO_Conexao.con.Close();

            //Desativa a edicao dos negocio
            cbxModaliade.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxHora.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxDia.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxProfessor.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxQtdAluno.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxAluno.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void FormCadastrarAlunoTurma_Load(object sender, EventArgs e)
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
            string diaSemana = cbxDia.Text;
            string hora = cbxHora.Text;

            while (reader.Read())
            {
                idModalidade = int.Parse(reader["idEstudio_Modalidade"].ToString());
            }

            DAO_Conexao.con.Close();


            //Pega todas as turmas com a modalidade, dia e hora selecionados

            Turma t1 = new Turma(idModalidade, diaSemana, hora);

            reader = t1.consultarTurma01();

            while (reader.Read())
            {
                cbxProfessor.Items.Add(reader["ProfessorTurma"].ToString()); //e joga os professores encontradas na comboBox
            }

            DAO_Conexao.con.Close();
        }

        private void cbxProfessor_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Limpa os items dentro do comboBox
            cbxQtdAluno.Items.Clear();

            //Pega o id da modalidade selecionada
            Modalidade mod = new Modalidade(cbxModaliade.Text);

            MySqlDataReader reader = mod.consultarNomeModalidade();

            int idModalidade = 0;
            string diaSemana = cbxDia.Text;
            string hora = cbxHora.Text;
            string professor = cbxProfessor.Text;

            while (reader.Read())
            {
                idModalidade = int.Parse(reader["idEstudio_Modalidade"].ToString());
            }

            DAO_Conexao.con.Close();

            //Pega todas as turmas com a modalidade, dia, hora e professor selecionados

            Turma t1 = new Turma(professor, diaSemana, hora, idModalidade);

            reader = t1.consultarProfessor();

            while (reader.Read())
            {
                cbxQtdAluno.Items.Add(reader["nAlunosTurma"].ToString()); //e joga os limites de alunos encontradas na comboBox
            }

            DAO_Conexao.con.Close();
        }

        private void cbxQtdAluno_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Pega o id da modalidade selecionada
            Modalidade mod = new Modalidade(cbxModaliade.Text);

            MySqlDataReader reader = mod.consultarNomeModalidade();

            int idModalidade = 0;
            string diaSemana = cbxDia.Text;
            string hora = cbxHora.Text;
            string professor = cbxProfessor.Text;
            int nAlunos = int.Parse(cbxQtdAluno.Text);

            while (reader.Read())
            {
                idModalidade = int.Parse(reader["idEstudio_Modalidade"].ToString());
            }

            DAO_Conexao.con.Close();

            //Pega a turma com todas as informãcoes selecionadas

            turmaBuscar = new Turma(professor, diaSemana, hora, idModalidade, nAlunos);
        }

        private void btnCadastrarAluno_Click(object sender, EventArgs e)
        {
            Turma tm = new Turma();

            if(String.IsNullOrEmpty(cbxAluno.Text) || String.IsNullOrEmpty(cbxModaliade.Text) || String.IsNullOrEmpty(cbxProfessor.Text) || String.IsNullOrEmpty(cbxDia.Text) 
                || String.IsNullOrEmpty(cbxHora.Text) || String.IsNullOrEmpty(cbxQtdAluno.Text))
            {
                MessageBox.Show("Por favor preencha todos os campos antes de prosseguir");
            }
            else
            {
                tm = turmaBuscar;
                //pega o id da turma
                MySqlDataReader reader = tm.consultarTudoTurma();
                int idTurma = 0;
                while (reader.Read())
                {
                    idTurma = int.Parse(reader["idEstudio_Turma"].ToString());
                }

                DAO_Conexao.con.Close();

                if (tm.verificaMaximoAlunos(idTurma))
                {
                    MessageBox.Show("A turma que você está tentando se cadastrar já está cheia");
                }
                else
                {
                    string cpfAluno = cbxAluno.Text; //pega todo o texto da cbxAluno

                    cpfAluno = cpfAluno.Substring(0, 14); //pega so o cpf do aluno

                    Aluno al = new Aluno(cpfAluno);
                    if(tm.verificaAlunoCadastrado(cpfAluno, idTurma)) //ve se já ta cadastrado naquela turma especifica
                    {
                        MessageBox.Show("Este aluno já está cadastrado nesta turma");
                    }
                    else if (al.cadastrarAlunoTurma(idTurma)) //cadastra ele
                    {
                        MessageBox.Show("Aluno cadastrado na turma com sucesso");
                    }
                    else
                    {
                        MessageBox.Show("Erro ao cadastrar o aluno na turma");
                    }
                }
            }
        }
    }
}
