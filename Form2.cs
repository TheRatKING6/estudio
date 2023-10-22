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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DAO_Conexao.VerificaLoginRepetido(textBox1.Text))
            {
                int tipo = 0;
                if(comboBox1.SelectedIndex == 0)
                {
                    tipo = 1; //adm
                }
                else if(comboBox1.SelectedIndex == 1)
                {
                    tipo = 2; //restrito
                }

                if(DAO_Conexao.CadLogin(textBox1.Text, textBox2.Text, tipo))
                {
                    textBox1.Text = null;
                    textBox2.Text = null;
                    comboBox1.Text = null;
                    MessageBox.Show("Cadastro realizado com sucesso");
                }
                else
                {
                    MessageBox.Show("Erro de cadastro");
                }
            }
            else
            {
                MessageBox.Show("Escolha outro nome de usuário: login já existente");
            }
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
