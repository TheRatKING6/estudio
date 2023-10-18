using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estudio
{
    class Modalidade
    {
        private string descricao;
        private float preco;
        private int qtde_alunos, qtde_aulas;

        public string Descricao { get => descricao; set => descricao = value; }
        public float Preco { get => preco; set => preco = value; }
        public int Qtde_alunos { get => qtde_alunos; set => qtde_alunos = value; }
        public int Qtde_aulas { get => qtde_aulas; set => qtde_aulas = value; }

        public Modalidade(string descricao, float preco, int qtde_alunos, int qtde_aulas)
        {
            this.descricao = descricao;
            this.preco = preco;
            this.qtde_alunos = qtde_alunos;
            this.qtde_aulas = qtde_aulas;
        }

        public Modalidade(string descricao)
        {
            this.descricao = descricao;
        }

        public Modalidade()
        {

        }

        public bool cadastrarModalidade()
        {
            bool cad = false;

            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand insere = new MySqlCommand("insert into Estudio_Modalidade (descricaoModalidade, precoModalidade, qtdeAlunos, qtdeAulas) " +
                    "values('" + descricao + "'," + preco + "," + qtde_alunos + "," + qtde_aulas + ")", DAO_Conexao.con);
                insere.ExecuteNonQuery();
                cad = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();
            }

            return cad;
        }

        public MySqlDataReader consultarTodasModalidade()
        {
            MySqlDataReader reader = null;

            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand select = new MySqlCommand("select * from Estudio_Modalidade", DAO_Conexao.con);
                
                reader = select.ExecuteReader();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                
            }

            return reader;
        }

        public MySqlDataReader consultarModalidade(int id)
        {
            MySqlDataReader reader = null;

            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand select = new MySqlCommand("select * from Estudio_Modalidade where idEstudio_Modalidade=" + id, DAO_Conexao.con);

                reader = select.ExecuteReader();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {

            }

            return reader;
        }

        public bool excluirModalidade(int id)
        {
            bool del = false;

            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand delete = new MySqlCommand("update Estudio_Modalidade set ativa = 1 where idEstudio_Modalidade=" + id, DAO_Conexao.con);

                delete.ExecuteNonQuery();
                del = true;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();
            }

            return del;
        }

        public bool atualizarModalidade(int id)
        {
            bool upd = false;

            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand update = new MySqlCommand("update Estudio_Modalidade set descricaoModalidade='"+descricao+"', precoModalidade="+preco+", " +
                    "qtdeAlunos="+qtde_alunos+", qtdeAulas="+qtde_aulas+" where idEstudio_Modalidade=" + id, DAO_Conexao.con);

                update.ExecuteNonQuery();
                upd = true;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();
            }

            return upd;
        }

        public bool ativarModalidade(int id)
        {
            bool atv = false;

            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand ativado = new MySqlCommand("update Estudio_Modalidade set ativa = 0 where idEstudio_Modalidade=" + id, DAO_Conexao.con);

                ativado.ExecuteNonQuery();
                atv = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();
            }

            return atv;
        }

        public MySqlDataReader consultarNomeModalidade()
        {
            MySqlDataReader reader = null;

            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand consulta = new MySqlCommand("select * from Estudio_Modalidade where descricaoModalidade ='" + descricao + "'", DAO_Conexao.con);

                reader = consulta.ExecuteReader();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return reader;
        }

        /*
         * Estava tentando fazer um metodo para modalidades em que ele retorna um MySqlDataReader contendo todos os Id's de modalidade que tambem aparecem na tabela Turma
         * usar INNER JOIN (?)
         * rever as aulas da elaine
         * 
        public MySqlDataReader consultarModalidadesComTurmas()
        {
            MySqlDataReader reader = null;

            try
            {
                DAO_Conexao.con.Open();

                MySqlCommand consulta = new MySqlCommand("");
            }
        }

        */
    }
}
