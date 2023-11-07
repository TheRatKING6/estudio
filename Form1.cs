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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            WindowState = FormWindowState.Maximized;
            menuStrip1.Enabled = false;

            if (DAO_Conexao.getConexao("143.106.241.3", "cl202249", "cl202249", "cl*01102006"))
            {
                Console.WriteLine("Conectado");
            }
            else
            {
                Console.WriteLine("Erro de conexâo");
            }
                

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cadastrarLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //cadLogin cad_login = new cadLogin();
            //cad_login.MdiParent = this;
            //cad_login.Show();
            Form2 form2 = new Form2();
            form2.MdiParent = this;
            form2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int tipo = DAO_Conexao.VerificaLogin(textBox1.Text, textBox2.Text);
            if(tipo == 0)
            {
                MessageBox.Show("Usuário ou senha inválidos");
            }
            else if(tipo == 1)
            {
                //MessageBox.Show("Conta administrativa", "Aviso", MessageBoxButtons.OK);
                groupBox1.Visible = false;
                menuStrip1.Enabled = true;
                

            }
            else if(tipo == 2)
            {
                groupBox1.Visible = false;
                menuStrip1.Enabled = true;
                //cadastrarAlunoToolStripMenuItem.Enabled = false;
                cadastrarLoginToolStripMenuItem.Visible = false;
                inserirToolStripMenuItem.Visible = false;
                excluirToolStripMenuItem.Visible = false;
                atualizarToolStripMenuItem.Visible = false;
                cadastrarToolStripMenuItem.Visible = false;
                excluirToolStripMenuItem1.Visible = false;
            }
        }

        private void cadastrarAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.MdiParent = this;
            form3.Show();
        }

        private void excluirAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.MdiParent = this;
            form4.Show();
        }

        private void inserirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInserirModalidade form = new FormInserirModalidade();
            form.MdiParent = this;
            form.Show();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConsultarMod form = new FormConsultarMod();
            form.MdiParent = this;
            form.Show();
        }

        private void excluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormExcluirModalidade form = new FormExcluirModalidade();
            form.MdiParent = this;
            form.Show();
        }

        private void atualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAtualizarModalidade form = new FormAtualizarModalidade();
            form.MdiParent = this;
            form.Show();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadastrarTurma form = new FormCadastrarTurma();
            form.MdiParent = this;
            form.Show();
        }

        private void excluirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormExcluirTurma form = new FormExcluirTurma();
            form.MdiParent = this;
            form.Show();
        }

        private void consultarAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConsultarAluno form = new FormConsultarAluno();
            form.MdiParent = this;
            form.Show();
        }

        private void consultarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormConsultarTurma form = new FormConsultarTurma();
            form.MdiParent = this;
            form.Show();
        }

        private void atualizarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormAtualizarTurma form = new FormAtualizarTurma();
            form.MdiParent = this;
            form.Show();
        }

        private void cadastarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadastrarAlunoTurma form = new FormCadastrarAlunoTurma();
            form.MdiParent = this;
            form.Show();
        }
    }
}
