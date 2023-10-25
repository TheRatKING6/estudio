
namespace estudio
{
    partial class FormAtualizarTurma
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAtualizarTurma = new System.Windows.Forms.Button();
            this.cbxHora = new System.Windows.Forms.ComboBox();
            this.cbxDia = new System.Windows.Forms.ComboBox();
            this.cbxModaliade = new System.Windows.Forms.ComboBox();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblDia = new System.Windows.Forms.Label();
            this.lblModalidade = new System.Windows.Forms.Label();
            this.lblProfessor = new System.Windows.Forms.Label();
            this.lblQtdAl = new System.Windows.Forms.Label();
            this.cbxProfessor = new System.Windows.Forms.ComboBox();
            this.cbxQtdAluno = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxQtdAluno);
            this.groupBox1.Controls.Add(this.cbxProfessor);
            this.groupBox1.Controls.Add(this.lblQtdAl);
            this.groupBox1.Controls.Add(this.lblProfessor);
            this.groupBox1.Controls.Add(this.btnAtualizarTurma);
            this.groupBox1.Controls.Add(this.cbxHora);
            this.groupBox1.Controls.Add(this.cbxDia);
            this.groupBox1.Controls.Add(this.cbxModaliade);
            this.groupBox1.Controls.Add(this.lblHora);
            this.groupBox1.Controls.Add(this.lblDia);
            this.groupBox1.Controls.Add(this.lblModalidade);
            this.groupBox1.Location = new System.Drawing.Point(108, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(552, 295);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Turma";
            // 
            // btnAtualizarTurma
            // 
            this.btnAtualizarTurma.Location = new System.Drawing.Point(88, 254);
            this.btnAtualizarTurma.Name = "btnAtualizarTurma";
            this.btnAtualizarTurma.Size = new System.Drawing.Size(361, 23);
            this.btnAtualizarTurma.TabIndex = 6;
            this.btnAtualizarTurma.Text = "Atualizar";
            this.btnAtualizarTurma.UseVisualStyleBackColor = true;
            // 
            // cbxHora
            // 
            this.cbxHora.FormattingEnabled = true;
            this.cbxHora.Location = new System.Drawing.Point(177, 104);
            this.cbxHora.Name = "cbxHora";
            this.cbxHora.Size = new System.Drawing.Size(272, 21);
            this.cbxHora.TabIndex = 5;
            this.cbxHora.SelectedIndexChanged += new System.EventHandler(this.cbxHora_SelectedIndexChanged);
            // 
            // cbxDia
            // 
            this.cbxDia.FormattingEnabled = true;
            this.cbxDia.Location = new System.Drawing.Point(177, 65);
            this.cbxDia.Name = "cbxDia";
            this.cbxDia.Size = new System.Drawing.Size(272, 21);
            this.cbxDia.TabIndex = 4;
            this.cbxDia.SelectedIndexChanged += new System.EventHandler(this.cbxDia_SelectedIndexChanged);
            // 
            // cbxModaliade
            // 
            this.cbxModaliade.FormattingEnabled = true;
            this.cbxModaliade.Location = new System.Drawing.Point(177, 28);
            this.cbxModaliade.Name = "cbxModaliade";
            this.cbxModaliade.Size = new System.Drawing.Size(272, 21);
            this.cbxModaliade.TabIndex = 3;
            this.cbxModaliade.SelectedIndexChanged += new System.EventHandler(this.cbxModaliade_SelectedIndexChanged);
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(85, 107);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(44, 13);
            this.lblHora.TabIndex = 2;
            this.lblHora.Text = "Horário:";
            // 
            // lblDia
            // 
            this.lblDia.AutoSize = true;
            this.lblDia.Location = new System.Drawing.Point(85, 68);
            this.lblDia.Name = "lblDia";
            this.lblDia.Size = new System.Drawing.Size(83, 13);
            this.lblDia.TabIndex = 1;
            this.lblDia.Text = "Dia da Semana:";
            // 
            // lblModalidade
            // 
            this.lblModalidade.AutoSize = true;
            this.lblModalidade.Location = new System.Drawing.Point(85, 31);
            this.lblModalidade.Name = "lblModalidade";
            this.lblModalidade.Size = new System.Drawing.Size(65, 13);
            this.lblModalidade.TabIndex = 0;
            this.lblModalidade.Text = "Modalidade:";
            // 
            // lblProfessor
            // 
            this.lblProfessor.AutoSize = true;
            this.lblProfessor.Location = new System.Drawing.Point(85, 151);
            this.lblProfessor.Name = "lblProfessor";
            this.lblProfessor.Size = new System.Drawing.Size(54, 13);
            this.lblProfessor.TabIndex = 7;
            this.lblProfessor.Text = "Professor:";
            // 
            // lblQtdAl
            // 
            this.lblQtdAl.AutoSize = true;
            this.lblQtdAl.Location = new System.Drawing.Point(88, 189);
            this.lblQtdAl.Name = "lblQtdAl";
            this.lblQtdAl.Size = new System.Drawing.Size(78, 13);
            this.lblQtdAl.TabIndex = 8;
            this.lblQtdAl.Text = "Qtd max aluno:";
            // 
            // cbxProfessor
            // 
            this.cbxProfessor.FormattingEnabled = true;
            this.cbxProfessor.Location = new System.Drawing.Point(177, 151);
            this.cbxProfessor.Name = "cbxProfessor";
            this.cbxProfessor.Size = new System.Drawing.Size(272, 21);
            this.cbxProfessor.TabIndex = 9;
            // 
            // cbxQtdAluno
            // 
            this.cbxQtdAluno.FormattingEnabled = true;
            this.cbxQtdAluno.Location = new System.Drawing.Point(177, 189);
            this.cbxQtdAluno.Name = "cbxQtdAluno";
            this.cbxQtdAluno.Size = new System.Drawing.Size(272, 21);
            this.cbxQtdAluno.TabIndex = 10;
            // 
            // FormAtualizarTurma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 582);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormAtualizarTurma";
            this.Text = "Atualizar";
            this.Load += new System.EventHandler(this.FormAtualizarTurma_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbxQtdAluno;
        private System.Windows.Forms.ComboBox cbxProfessor;
        private System.Windows.Forms.Label lblQtdAl;
        private System.Windows.Forms.Label lblProfessor;
        private System.Windows.Forms.Button btnAtualizarTurma;
        private System.Windows.Forms.ComboBox cbxHora;
        private System.Windows.Forms.ComboBox cbxDia;
        private System.Windows.Forms.ComboBox cbxModaliade;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblDia;
        private System.Windows.Forms.Label lblModalidade;
    }
}