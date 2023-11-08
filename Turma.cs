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

        public Turma() { }

        public Turma(int modalidade)
        {
            this.modalidade = modalidade;
        }

        public Turma(int modalidade, string diaSemana, string hora)
        {
            this.modalidade = modalidade;
            dia_semana = diaSemana;
            this.hora = hora;
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
            this.numeroAlunos = numeroAlunos;
        }

        public Turma(string professor, string dia_semana, int numeroAlunos, string hora)
        {
            this.professor = professor;
            this.dia_semana = dia_semana;
            this.hora = hora;
            this.numeroAlunos = numeroAlunos;
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
                MySqlCommand insert = new MySqlCommand("insert into Estudio_Turma (idModalidade, ProfessorTurma, diaSemanaTurma, horaTurma, nAlunosTurma) " +
                    "values ("+modalidade+", '"+professor+"','"+ dia_semana+"','"+ hora +"',"+ numeroAlunos+")", DAO_Conexao.con);
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
            bool excluido = false;

            try
            {
                DAO_Conexao.con.Open();

                MySqlCommand delete = new MySqlCommand("delete from Estudio_Turma where idModalidade=" + modalidade + "" +
                    " and diaSemanaTurma='" + dia_semana + "' and horaTurma='" + hora + "'", DAO_Conexao.con);

                delete.ExecuteNonQuery();

                excluido = true;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();
            }

            return excluido;
        }

        public MySqlDataReader consultarTurma()
        {
            MySqlDataReader consulta = null;

            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand select = new MySqlCommand("select * from Estudio_Turma", DAO_Conexao.con);

                consulta = select.ExecuteReader();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return consulta;
        }

        public MySqlDataReader consultarTurma01()
        {
            MySqlDataReader buscar = null;

            try
            {
                DAO_Conexao.con.Open();

                MySqlCommand select = new MySqlCommand("select * from Estudio_Turma where idModalidade=" + modalidade + " " +
                    "and diaSemanaTurma='" + dia_semana + "' and horaTurma='" + hora + "'", DAO_Conexao.con);

                buscar = select.ExecuteReader();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return buscar;
        }

        public MySqlDataReader consultarDiaSemana()
        {
            MySqlDataReader buscar = null;

            try
            {
                DAO_Conexao.con.Open();

                MySqlCommand select = new MySqlCommand("select * from Estudio_Turma where idModalidade=" + modalidade, DAO_Conexao.con);

                buscar = select.ExecuteReader();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return buscar;
        }

        public MySqlDataReader consultarHoras()
        {
            MySqlDataReader buscar = null;

            try
            {
                DAO_Conexao.con.Open();

                MySqlCommand select = new MySqlCommand("select * from Estudio_Turma where idModalidade=" + modalidade + " and diaSemanaTurma='" + dia_semana + "'", DAO_Conexao.con);

                buscar = select.ExecuteReader();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return buscar;
        }

        public MySqlDataReader consultarProfessor()
        {
            MySqlDataReader buscar = null;

            try
            {
                DAO_Conexao.con.Open();

                MySqlCommand select = new MySqlCommand("select * from Estudio_Turma where idModalidade=" + modalidade + " " +
                    "and diaSemanaTurma='" + dia_semana + "' and horaTurma='" + hora + "' and ProfessorTurma='"+professor+"'", DAO_Conexao.con);

                buscar = select.ExecuteReader();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return buscar;
        }

        public MySqlDataReader consultarTudoTurma()
        {
            MySqlDataReader buscar = null;

            try
            {
                DAO_Conexao.con.Open();

                MySqlCommand select = new MySqlCommand("select * from Estudio_Turma where idModalidade=" + modalidade + " " +
                    "and diaSemanaTurma='" + dia_semana + "' and horaTurma='" + hora + "' and ProfessorTurma='" + professor + "' and nAlunosTurma="+numeroAlunos, DAO_Conexao.con);

                buscar = select.ExecuteReader();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return buscar;
        }

        public bool atualizarTurma(int id)
        {
            bool atualizar = false;

            try
            {
                DAO_Conexao.con.Open();

                MySqlCommand update = new MySqlCommand("update Estudio_Turma set diaSemanaTurma='" + dia_semana + "', horaTurma='" + hora + "', " +
                    "ProfessorTurma='" + professor + "', nAlunosTurma=" + numeroAlunos + " where idEstudio_Turma=" + id, DAO_Conexao.con);

                update.ExecuteNonQuery();

                atualizar = true;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();
            }

            return atualizar;
        }

        public bool verificaMaximoAlunos(int id)
        {
            bool cheio = false;
            int qtdAlunos = 0;
            try
            {
                DAO_Conexao.con.Open();

                MySqlCommand selectQtdAlunos = new MySqlCommand("select count(*) from Estudio_Turma_Aluno where idTurma= " + id, DAO_Conexao.con);
                
                qtdAlunos = Convert.ToInt32(selectQtdAlunos.ExecuteScalar()); //pega o resultado do count e transforma em int

                

                MySqlCommand selectMaxAlunos = new MySqlCommand("select nAlunosTurma from Estudio_Turma where idEstudio_Turma = " + id, DAO_Conexao.con);

                int maxAlunos = Convert.ToInt32(selectMaxAlunos.ExecuteScalar()); //pega o resultado e transforma em int
                //Console.WriteLine("\n\n\n" + maxAlunos + "\n\n\n");
                if (qtdAlunos >= maxAlunos)
                {
                    cheio = true;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                DAO_Conexao.con.Close();
            }

            return cheio;
        }

        public bool verificaAlunoCadastrado(string cpf, int id)
        {
            bool cadastrado = false;

            try
            {
                DAO_Conexao.con.Open();

                MySqlCommand select = new MySqlCommand("select * from Estudio_Turma_Aluno where CPFAluno ='" + cpf + "' and idTurma="+ id, DAO_Conexao.con);

                MySqlDataReader rd = select.ExecuteReader();

                if (rd.Read())
                {
                    cadastrado = true;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                DAO_Conexao.con.Close();
            }

            return cadastrado;
        }

    }
}
