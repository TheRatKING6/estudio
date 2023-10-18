using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estudio
{
    class Aluno
    {
        #region
        private string cpf;
        private string nome;
        private string rua;
        private string numero;
        private string bairro;
        private string complemento;
        private string cep;
        private string cidade;
        private string estado;
        private string telefone;
        private string email;
        private byte[] foto;
        private bool ativo;
        #endregion



        //contrutores, getters & setters
        public Aluno(string cpf, string nome, string rua, string numero, string bairro, string complemento, string cep, string cidade, string estado, string telefone, string email)
        {
            setCpf(cpf);
            setNome(nome);
            setRua(rua);
            setNum(numero);
            setBairro(bairro);
            setComp(complemento);
            setCep(cep);
            setCidade(cidade);
            setEstado(estado);
            setTel(telefone);
            setEmail(email);
            
        }

        public Aluno()
        {

        }

        public Aluno(string cpf)
        {
            setCpf(cpf);
        }

        public void setCpf(string cpf)
        {
            this.cpf = cpf;
        }

        public void setNome(string nome)
        {
            this.nome = nome;
        }

        public void setRua(string rua)
        {
            this.rua = rua;
        }

        public void setNum(string num)
        {
            this.numero = num;
        }

        public void setBairro(string bairro)
        {
            this.bairro = bairro;
        }

        public void setComp(string complemento)
        {
            this.complemento = complemento;
        }

        public void setCep(string cep)
        {
            this.cep = cep;
        }

        public void setCidade(string cidade)
        {
            this.cidade = cidade;
        }

        public void setEstado(string estado)
        {
            this.estado = estado;
        }

        public void setTel(string telefone)
        {
            this.telefone = telefone;
        }

        public void setEmail(string email)
        {
            this.email = email;
        }

        public void setFoto(byte[] foto)
        {
            this.foto = foto;
        }
        //Lembrar: fazer metodos get dps kkkk

        //cadastro de alunos:
        public bool cadastrarAluno()
        {
            bool cad = false;

            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand insere = new MySqlCommand("insert into Estudio_Aluno (CPFAluno, nomeAluno, ruaAluno, numeroAluno, bairroAluno, complementoAluno, CEPAluno, cidadeAluno, estadoAluno, " +
                    "telefoneAluno, emailAluno) values('" + cpf + "','" + nome + "','" + rua + "','" + numero + "','" + bairro + "','" + complemento + "','" + cep + "','" + cidade + 
                    "','" + estado + "','" + telefone + "','" + email + "')", DAO_Conexao.con);
                insere.ExecuteNonQuery();
                cad = true;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();
            }

            return cad;
        }

        public bool consultarAluno()
        {
            bool existe = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand consulta = new MySqlCommand("select * from Estudio_Aluno where CPFAluno='" + cpf + "'", DAO_Conexao.con);
                MySqlDataReader resultado = consulta.ExecuteReader();
                if (resultado.Read())
                {
                    existe = true;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();
            }

            return existe;
        }

        public bool excluirAluno()
        {
            bool exc = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand exclui = new MySqlCommand("update Estudio_Aluno set ativo = 1 where CPFAluno='" + cpf + "'", DAO_Conexao.con);
                exclui.ExecuteNonQuery();
                exc = true;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();
            }

            return exc;
        }

        public bool atualizarAluno()
        {
            bool upd = false;

            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand atualizar = new MySqlCommand("update Estudio_Aluno set nomeAluno='" + nome + "', ruaAluno='" + rua + "', numeroAluno='" + numero + "', bairroAluno='" + bairro + "', " +
                    "complementoAluno='" + complemento + "', CEPAluno='" + cep + "', cidadeAluno='" + cidade + "', estadoAluno='" + estado + "', telefoneAluno='" + telefone + "', emailAluno='" + email + "' " +
                    "where CPFAluno='" + cpf + "'", DAO_Conexao.con);
                atualizar.ExecuteNonQuery();
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

        public bool verificaCPF() //string CPF - sem parâmetro
        {
            int soma, resto, cont = 0;

            soma = 0;

            string CPF = this.cpf;

            CPF = CPF.Trim();
            CPF = CPF.Replace(".", "");
            CPF = CPF.Replace("-", "");

            for (int i = 0; i < CPF.Length; i++)
            {
                int a = CPF[0] - '0';
                int b = CPF[i] - '0';

                if (a == b)
                {
                    cont++;
                }
            }

            if (cont == 11)
            {
                return false;
            }

            for (int i = 1; i <= 9; i++)
            {
                soma += int.Parse(CPF.Substring(i - 1, 1)) * (11 - i);
            }

            resto = (soma * 10) % 11;

            if ((resto == 10) || (resto == 11))
            {
                resto = 0;
            }

            if (resto != int.Parse(CPF.Substring(9, 1)))
            {
                return false;
            }

            soma = 0;

            for (int i = 1; i <= 10; i++)
            {
                soma += int.Parse(CPF.Substring(i - 1, 1)) * (12 - i);
            }

            resto = (soma * 10) % 11;

            if ((resto == 10) || (resto == 11))
            {
                resto = 0;
            }

            if (resto != int.Parse(CPF.Substring(10, 1)))
            {
                return false;
            }

            return true;
        }

        public MySqlDataReader consultarDadosAluno()
        {
            MySqlDataReader aluno = null;

            try
            {
                DAO_Conexao.con.Open();

                MySqlCommand select = new MySqlCommand("select * from Estudio_Aluno where CPFAluno='" + cpf + "'", DAO_Conexao.con);

                aluno = select.ExecuteReader();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return aluno;
        }

        public bool reativarAluno()
        {
            bool exc = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand exclui = new MySqlCommand("update Estudio_Aluno set ativo = 0 where CPFAluno='" + cpf + "'", DAO_Conexao.con);
                exclui.ExecuteNonQuery();
                exc = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();
            }

            return exc;
        }

    }

    
}
