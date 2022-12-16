namespace Projeto_Biblioteca_Emprestimo
{
    partial class Menu_Principal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_Cadastro_de_Livros = new System.Windows.Forms.Button();
            this.button_Cadastro_de_Leitores = new System.Windows.Forms.Button();
            this.button_Registro_de_Emprestimos = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_Cadastro_de_Livros
            // 
            this.button_Cadastro_de_Livros.BackColor = System.Drawing.Color.Transparent;
            this.button_Cadastro_de_Livros.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_Cadastro_de_Livros.ForeColor = System.Drawing.Color.DarkRed;
            this.button_Cadastro_de_Livros.Location = new System.Drawing.Point(49, 203);
            this.button_Cadastro_de_Livros.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_Cadastro_de_Livros.Name = "button_Cadastro_de_Livros";
            this.button_Cadastro_de_Livros.Size = new System.Drawing.Size(219, 62);
            this.button_Cadastro_de_Livros.TabIndex = 0;
            this.button_Cadastro_de_Livros.Text = "Livros";
            this.button_Cadastro_de_Livros.UseVisualStyleBackColor = false;
            this.button_Cadastro_de_Livros.Click += new System.EventHandler(this.button_Cadastro_de_Livros_Click);
            // 
            // button_Cadastro_de_Leitores
            // 
            this.button_Cadastro_de_Leitores.BackColor = System.Drawing.Color.Transparent;
            this.button_Cadastro_de_Leitores.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_Cadastro_de_Leitores.ForeColor = System.Drawing.Color.DarkRed;
            this.button_Cadastro_de_Leitores.Location = new System.Drawing.Point(49, 317);
            this.button_Cadastro_de_Leitores.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_Cadastro_de_Leitores.Name = "button_Cadastro_de_Leitores";
            this.button_Cadastro_de_Leitores.Size = new System.Drawing.Size(219, 70);
            this.button_Cadastro_de_Leitores.TabIndex = 1;
            this.button_Cadastro_de_Leitores.Text = "Leitores";
            this.button_Cadastro_de_Leitores.UseVisualStyleBackColor = false;
            this.button_Cadastro_de_Leitores.Click += new System.EventHandler(this.button_Cadastro_de_Leitores_Click);
            // 
            // button_Registro_de_Emprestimos
            // 
            this.button_Registro_de_Emprestimos.BackColor = System.Drawing.Color.Transparent;
            this.button_Registro_de_Emprestimos.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_Registro_de_Emprestimos.ForeColor = System.Drawing.Color.DarkRed;
            this.button_Registro_de_Emprestimos.Location = new System.Drawing.Point(49, 432);
            this.button_Registro_de_Emprestimos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_Registro_de_Emprestimos.Name = "button_Registro_de_Emprestimos";
            this.button_Registro_de_Emprestimos.Size = new System.Drawing.Size(219, 77);
            this.button_Registro_de_Emprestimos.TabIndex = 2;
            this.button_Registro_de_Emprestimos.Text = "Empréstimos";
            this.button_Registro_de_Emprestimos.UseVisualStyleBackColor = false;
            this.button_Registro_de_Emprestimos.Click += new System.EventHandler(this.button_Registro_de_Emprestimos_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(49, 40);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(534, 44);
            this.label3.TabIndex = 3;
            this.label3.Text = "Seja bem-vindo a nossa biblioteca!";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.DarkRed;
            this.label4.Location = new System.Drawing.Point(49, 113);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 36);
            this.label4.TabIndex = 4;
            this.label4.Text = "Menu Principal";
            // 
            // Menu_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projeto_Biblioteca_Emprestimo.Properties.Resources.download;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1143, 750);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_Registro_de_Emprestimos);
            this.Controls.Add(this.button_Cadastro_de_Leitores);
            this.Controls.Add(this.button_Cadastro_de_Livros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Menu_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button button_Cadastro_de_Livros;
        private Button button_Cadastro_de_Leitores;
        private Button button_Registro_de_Emprestimos;
        private Label label3;
        private Label label4;
    }
}