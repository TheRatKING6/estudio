using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estudio
{
    class Turma
    {
        private string professor, dia_semana, hora;
        private int modalidade, numeroAlunos;

        public Turma(int modalidade)
        {
            this.modalidade = modalidade;
        }

        public Turma(string professor, string dia_semana, string hora, int modalidade)
        {
            this.professor = professor;
            this.dia_semana = dia_semana;
            this.hora = hora;
            this.modalidade = modalidade;
        }

        public Turma(int modalidade, string dia_semana)
        {
            this.modalidade = modalidade;
            this.dia_semana = dia_semana;
        }

        public Turma(string professor, string dia_semana, string hora, int modalidade, int numeroAlunos)
        {
            this.professor = professor;
            this.dia_semana = dia_semana;
            this.hora = hora;
            this.modalidade = modalidade;
            this.NumeroAlunos = numeroAlunos;
        }

        public string Professor { get => professor; set => professor = value; }
        public string Dia_semana { get => dia_semana; set => dia_semana = value; }
        public string Hora { get => hora; set => hora = value; }
        public int Modalidade { get => modalidade; set => modalidade = value; }
        public int NumeroAlunos { get => numeroAlunos; set => numeroAlunos = value; }

        public bool cadastrarTurma()
        {
            bool cad = false;

            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand insert = new MySqlCommand("insert into Estudio_Turma (idModalidade, ProfessorTurma, diaSemanaTurma, nAlunosTurma) " +
                    "values (modalidade, professor, dia_semana, numeroAlunos)", DAO_Conexao.con);
                insert.ExecuteNonQuery();
                cad = true;
                
            }
            catch(Exception ex)
            {
                Console.WriteLine("\nErro: " + ex.ToString() + "\n");
            }
            finally
            {
                DAO_Conexao.con.Close();
            }

            return cad;
        }

        public bool excluirTurma()
        {
            return false;
        }

        /*public MySqlDataReader consultarTurma()
        {

        }*/

        /*public MySqlDataReader consultarTurma01()
        {

        }*/
    }
}
