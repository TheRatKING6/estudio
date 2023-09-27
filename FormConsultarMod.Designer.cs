
namespace estudio
{
    partial class FormConsultarMod
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
            this.groupBoxModalidade = new System.Windows.Forms.GroupBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.txtQtdAulas = new System.Windows.Forms.TextBox();
            this.txtQtdAlunos = new System.Windows.Forms.TextBox();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.lblQtdAulas = new System.Windows.Forms.Label();
            this.lblQtdAlunos = new System.Windows.Forms.Label();
            this.lblPreco = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.cbxModalidade = new System.Windows.Forms.ComboBox();
            this.groupBoxModalidade.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxModalidade
            // 
            this.groupBoxModalidade.Controls.Add(this.cbxModalidade);
            this.groupBoxModalidade.Controls.Add(this.btnConsultar);
            this.groupBoxModalidade.Controls.Add(this.txtQtdAulas);
            this.groupBoxModalidade.Controls.Add(this.txtQtdAlunos);
            this.groupBoxModalidade.Controls.Add(this.txtPreco);
            this.groupBoxModalidade.Controls.Add(this.lblQtdAulas);
            this.groupBoxModalidade.Controls.Add(this.lblQtdAlunos);
            this.groupBoxModalidade.Controls.Add(this.lblPreco);
            this.groupBoxModalidade.Controls.Add(this.lblDescricao);
            this.groupBoxModalidade.Location = new System.Drawing.Point(75, 45);
            this.groupBoxModalidade.Name = "groupBoxModalidade";
            this.groupBoxModalidade.Size = new System.Drawing.Size(650, 335);
            this.groupBoxModalidade.TabIndex = 1;
            this.groupBoxModalidade.TabStop = false;
            this.groupBoxModalidade.Text = "Modalidades";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(54, 240);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(483, 23);
            this.btnConsultar.TabIndex = 8;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // txtQtdAulas
            // 
            this.txtQtdAulas.Location = new System.Drawing.Point(154, 187);
            this.txtQtdAulas.Name = "txtQtdAulas";
            this.txtQtdAulas.Size = new System.Drawing.Size(383, 20);
            this.txtQtdAulas.TabIndex = 7;
            // 
            // txtQtdAlunos
            // 
            this.txtQtdAlunos.Location = new System.Drawing.Point(154, 146);
            this.txtQtdAlunos.Name = "txtQtdAlunos";
            this.txtQtdAlunos.Size = new System.Drawing.Size(383, 20);
            this.txtQtdAlunos.TabIndex = 6;
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(154, 99);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(383, 20);
            this.txtPreco.TabIndex = 5;
            // 
            // lblQtdAulas
            // 
            this.lblQtdAulas.AutoSize = true;
            this.lblQtdAulas.Location = new System.Drawing.Point(51, 194);
            this.lblQtdAulas.Name = "lblQtdAulas";
            this.lblQtdAulas.Size = new System.Drawing.Size(56, 13);
            this.lblQtdAulas.TabIndex = 3;
            this.lblQtdAulas.Text = "Qtd Aulas:";
            // 
            // lblQtdAlunos
            // 
            this.lblQtdAlunos.AutoSize = true;
            this.lblQtdAlunos.Location = new System.Drawing.Point(51, 153);
            this.lblQtdAlunos.Name = "lblQtdAlunos";
            this.lblQtdAlunos.Size = new System.Drawing.Size(62, 13);
            this.lblQtdAlunos.TabIndex = 2;
            this.lblQtdAlunos.Text = "Qtd Alunos:";
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Location = new System.Drawing.Point(51, 106);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(38, 13);
            this.lblPreco.TabIndex = 1;
            this.lblPreco.Text = "Preço:";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(51, 67);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(58, 13);
            this.lblDescricao.TabIndex = 0;
            this.lblDescricao.Text = "Descrição:";
            // 
            // cbxModalidade
            // 
            this.cbxModalidade.FormattingEnabled = true;
            this.cbxModalidade.Location = new System.Drawing.Point(154, 58);
            this.cbxModalidade.Name = "cbxModalidade";
            this.cbxModalidade.Size = new System.Drawing.Size(383, 21);
            this.cbxModalidade.TabIndex = 9;
            // 
            // FormConsultarMod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxModalidade);
            this.Name = "FormConsultarMod";
            this.Text = "FormConsultarMod";
            this.groupBoxModalidade.ResumeLayout(false);
            this.groupBoxModalidade.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxModalidade;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.TextBox txtQtdAulas;
        private System.Windows.Forms.TextBox txtQtdAlunos;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Label lblQtdAulas;
        private System.Windows.Forms.Label lblQtdAlunos;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.ComboBox cbxModalidade;
    }
}