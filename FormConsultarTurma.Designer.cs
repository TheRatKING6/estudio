
namespace estudio
{
    partial class FormConsultarTurma
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
            this.btnConsultarTurma = new System.Windows.Forms.Button();
            this.cbxHora = new System.Windows.Forms.ComboBox();
            this.cbxDia = new System.Windows.Forms.ComboBox();
            this.cbxModaliade = new System.Windows.Forms.ComboBox();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblDia = new System.Windows.Forms.Label();
            this.lblModalidade = new System.Windows.Forms.Label();
            this.lbxTurmas = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnConsultarTurma);
            this.groupBox1.Controls.Add(this.cbxHora);
            this.groupBox1.Controls.Add(this.cbxDia);
            this.groupBox1.Controls.Add(this.cbxModaliade);
            this.groupBox1.Controls.Add(this.lblHora);
            this.groupBox1.Controls.Add(this.lblDia);
            this.groupBox1.Controls.Add(this.lblModalidade);
            this.groupBox1.Location = new System.Drawing.Point(77, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(552, 211);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Turma";
            // 
            // btnConsultarTurma
            // 
            this.btnConsultarTurma.Location = new System.Drawing.Point(88, 177);
            this.btnConsultarTurma.Name = "btnConsultarTurma";
            this.btnConsultarTurma.Size = new System.Drawing.Size(361, 23);
            this.btnConsultarTurma.TabIndex = 6;
            this.btnConsultarTurma.Text = "Consultar";
            this.btnConsultarTurma.UseVisualStyleBackColor = true;
            this.btnConsultarTurma.Click += new System.EventHandler(this.btnConsultarTurma_Click);
            // 
            // cbxHora
            // 
            this.cbxHora.FormattingEnabled = true;
            this.cbxHora.Location = new System.Drawing.Point(177, 104);
            this.cbxHora.Name = "cbxHora";
            this.cbxHora.Size = new System.Drawing.Size(272, 21);
            this.cbxHora.TabIndex = 5;
            // 
            // cbxDia
            // 
            this.cbxDia.FormattingEnabled = true;
            this.cbxDia.Location = new System.Drawing.Point(177, 65);
            this.cbxDia.Name = "cbxDia";
            this.cbxDia.Size = new System.Drawing.Size(272, 21);
            this.cbxDia.TabIndex = 4;
            // 
            // cbxModaliade
            // 
            this.cbxModaliade.FormattingEnabled = true;
            this.cbxModaliade.Location = new System.Drawing.Point(177, 28);
            this.cbxModaliade.Name = "cbxModaliade";
            this.cbxModaliade.Size = new System.Drawing.Size(272, 21);
            this.cbxModaliade.TabIndex = 3;
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
            // lbxTurmas
            // 
            this.lbxTurmas.FormattingEnabled = true;
            this.lbxTurmas.Location = new System.Drawing.Point(77, 295);
            this.lbxTurmas.Name = "lbxTurmas";
            this.lbxTurmas.Size = new System.Drawing.Size(655, 199);
            this.lbxTurmas.TabIndex = 2;
            // 
            // FormConsultarTurma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 604);
            this.Controls.Add(this.lbxTurmas);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormConsultarTurma";
            this.Text = "Consultar";
            this.Load += new System.EventHandler(this.FormConsultarTurma_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnConsultarTurma;
        private System.Windows.Forms.ComboBox cbxHora;
        private System.Windows.Forms.ComboBox cbxDia;
        private System.Windows.Forms.ComboBox cbxModaliade;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblDia;
        private System.Windows.Forms.Label lblModalidade;
        private System.Windows.Forms.ListBox lbxTurmas;
    }
}