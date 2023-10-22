
namespace estudio
{
    partial class FormCadastrarTurma
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gpbTurma = new System.Windows.Forms.GroupBox();
            this.txtNumAlunos = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txtHora = new System.Windows.Forms.TextBox();
            this.txtDiaSemana = new System.Windows.Forms.TextBox();
            this.txtProfessor = new System.Windows.Forms.TextBox();
            this.txtModalidade = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewMod = new System.Windows.Forms.DataGridView();
            this.modalidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpbTurma.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMod)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbTurma
            // 
            this.gpbTurma.Controls.Add(this.txtNumAlunos);
            this.gpbTurma.Controls.Add(this.label5);
            this.gpbTurma.Controls.Add(this.btnCadastrar);
            this.gpbTurma.Controls.Add(this.txtHora);
            this.gpbTurma.Controls.Add(this.txtDiaSemana);
            this.gpbTurma.Controls.Add(this.txtProfessor);
            this.gpbTurma.Controls.Add(this.txtModalidade);
            this.gpbTurma.Controls.Add(this.label4);
            this.gpbTurma.Controls.Add(this.label3);
            this.gpbTurma.Controls.Add(this.label2);
            this.gpbTurma.Controls.Add(this.label1);
            this.gpbTurma.Location = new System.Drawing.Point(44, 22);
            this.gpbTurma.Name = "gpbTurma";
            this.gpbTurma.Size = new System.Drawing.Size(606, 249);
            this.gpbTurma.TabIndex = 0;
            this.gpbTurma.TabStop = false;
            this.gpbTurma.Text = "Turma";
            // 
            // txtNumAlunos
            // 
            this.txtNumAlunos.Location = new System.Drawing.Point(100, 174);
            this.txtNumAlunos.Name = "txtNumAlunos";
            this.txtNumAlunos.Size = new System.Drawing.Size(100, 20);
            this.txtNumAlunos.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Num Max Alunos:";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(90, 208);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(434, 23);
            this.btnCadastrar.TabIndex = 8;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txtHora
            // 
            this.txtHora.Location = new System.Drawing.Point(100, 141);
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(100, 20);
            this.txtHora.TabIndex = 7;
            // 
            // txtDiaSemana
            // 
            this.txtDiaSemana.Location = new System.Drawing.Point(100, 111);
            this.txtDiaSemana.Name = "txtDiaSemana";
            this.txtDiaSemana.Size = new System.Drawing.Size(434, 20);
            this.txtDiaSemana.TabIndex = 6;
            // 
            // txtProfessor
            // 
            this.txtProfessor.Location = new System.Drawing.Point(100, 76);
            this.txtProfessor.Name = "txtProfessor";
            this.txtProfessor.Size = new System.Drawing.Size(434, 20);
            this.txtProfessor.TabIndex = 5;
            // 
            // txtModalidade
            // 
            this.txtModalidade.Location = new System.Drawing.Point(100, 38);
            this.txtModalidade.Name = "txtModalidade";
            this.txtModalidade.Size = new System.Drawing.Size(434, 20);
            this.txtModalidade.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Horário:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dia da Semana:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Professor:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modalidade:";
            // 
            // dataGridViewMod
            // 
            this.dataGridViewMod.AllowUserToAddRows = false;
            this.dataGridViewMod.AllowUserToDeleteRows = false;
            this.dataGridViewMod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMod.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.modalidade});
            this.dataGridViewMod.Location = new System.Drawing.Point(44, 295);
            this.dataGridViewMod.Name = "dataGridViewMod";
            this.dataGridViewMod.ReadOnly = true;
            this.dataGridViewMod.Size = new System.Drawing.Size(606, 223);
            this.dataGridViewMod.TabIndex = 1;
            this.dataGridViewMod.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMod_CellClick);
            // 
            // modalidade
            // 
            this.modalidade.HeaderText = "Modalidade";
            this.modalidade.Name = "modalidade";
            this.modalidade.ReadOnly = true;
            // 
            // FormCadastrarTurma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 540);
            this.Controls.Add(this.dataGridViewMod);
            this.Controls.Add(this.gpbTurma);
            this.Name = "FormCadastrarTurma";
            this.Text = "FormCadastrarTurma";
            this.Load += new System.EventHandler(this.FormCadastrarTurma_Load);
            this.gpbTurma.ResumeLayout(false);
            this.gpbTurma.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMod)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbTurma;
        private System.Windows.Forms.TextBox txtModalidade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txtHora;
        private System.Windows.Forms.TextBox txtDiaSemana;
        private System.Windows.Forms.TextBox txtProfessor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNumAlunos;
        private System.Windows.Forms.DataGridView dataGridViewMod;
        private System.Windows.Forms.DataGridViewTextBoxColumn modalidade;
    }
}