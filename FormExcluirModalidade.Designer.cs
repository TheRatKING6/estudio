
namespace estudio
{
    partial class FormExcluirModalidade
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
            this.gpbModalidades = new System.Windows.Forms.GroupBox();
            this.cbxModalidades = new System.Windows.Forms.ComboBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.gpbModalidades.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbModalidades
            // 
            this.gpbModalidades.Controls.Add(this.btnExcluir);
            this.gpbModalidades.Controls.Add(this.lblDescricao);
            this.gpbModalidades.Controls.Add(this.cbxModalidades);
            this.gpbModalidades.Location = new System.Drawing.Point(46, 49);
            this.gpbModalidades.Name = "gpbModalidades";
            this.gpbModalidades.Size = new System.Drawing.Size(574, 183);
            this.gpbModalidades.TabIndex = 0;
            this.gpbModalidades.TabStop = false;
            this.gpbModalidades.Text = "Modalidades";
            // 
            // cbxModalidades
            // 
            this.cbxModalidades.FormattingEnabled = true;
            this.cbxModalidades.Location = new System.Drawing.Point(120, 47);
            this.cbxModalidades.Name = "cbxModalidades";
            this.cbxModalidades.Size = new System.Drawing.Size(401, 21);
            this.cbxModalidades.TabIndex = 0;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(32, 55);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(58, 13);
            this.lblDescricao.TabIndex = 1;
            this.lblDescricao.Text = "Descrição:";
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(70, 132);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(451, 23);
            this.btnExcluir.TabIndex = 2;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // FormExcluirModalidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 302);
            this.Controls.Add(this.gpbModalidades);
            this.Name = "FormExcluirModalidade";
            this.Text = "FormExcluirModalidade";
            this.Load += new System.EventHandler(this.FormExcluirModalidade_Load);
            this.gpbModalidades.ResumeLayout(false);
            this.gpbModalidades.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbModalidades;
        private System.Windows.Forms.ComboBox cbxModalidades;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Label lblDescricao;
    }
}