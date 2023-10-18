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

            //Coloca as modalidades do banco no datagridview
            Modalidade mod = new Modalidade();
            MySqlDataReader reader = mod.consultarTodasModalidade();

            while (reader.Read())
            {
                if(!(reader["ativa"].ToString() == "1")) //verifica se aturma ta ativa ou n
                {
                    dataGridViewMod.Rows.Add(reader["descricaoModalidade"].ToString());
                }
                
            }
            DAO_Conexao.con.Close();
        }

        private void FormCadastrarTurma_Load(object sender, EventArgs e)
        {

        }

        private void dataGridViewMod_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //a celuala do datagridview que voce clicar vai jogar no campo de texto da modalidade
            string modalidade = null;
            try
            {
                modalidade = dataGridViewMod.CurrentCell.Value.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Você precisa selecionar entre as modalidades existentes!" + ex.ToString()); //se vc clicar numa celula sem nada era pra aparecer isso, mas da exception e fecha mesmo com o try catch
            }
            finally
            {
                txtModalidade.Text = modalidade;
            }
            
            
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            //Pega o id da modalidade selecionada
            int idModalidade = 0;

            Modalidade mod = new Modalidade(txtModalidade.Text);

            MySqlDataReader rd = mod.consultarNomeModalidade();

            while(rd.Read())
            {
                idModalidade = int.Parse(rd["idEstudio_Modalidade"].ToString());
            }

            DAO_Conexao.con.Close();

            //pega os outros atributos da turma
            string professor = txtProfessor.Text;
            string diaSemana = txtDiaSemana.Text;
            string hora = txtHora.Text;
            int numAlunos = int.Parse(txtNumAlunos.Text);

            Turma t1 = new Turma(professor, diaSemana, hora, idModalidade, numAlunos);

            if (t1.cadastrarTurma())
            {
                MessageBox.Show("Turma cadastrada com sucesso!");
            }
            else
            {
                MessageBox.Show("Erro ao cadastrar a turma");
            }

            //limpa os campos
            txtModalidade.Text = null;
            txtProfessor.Text = null;
            txtDiaSemana.Text = null;
            txtHora.Text = null;
            txtNumAlunos.Text = null;
        }
    }
}
