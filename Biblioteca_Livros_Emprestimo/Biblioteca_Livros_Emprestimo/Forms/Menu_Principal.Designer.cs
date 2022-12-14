using System;
using System.Windows.Forms;
namespace Biblioteca_Livros_Emprestimo.Forms
{
    partial class Menu_Principal
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_Cadastro_de_Livros = new System.Windows.Forms.Button();
            this.button_Cadastro_de_Leitores = new System.Windows.Forms.Button();
            this.button_Registro_de_Emprestimos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(73, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(496, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bem-vindo a nossa biblioteca!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(69, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "Menu_Principal";
            // 
            // button_Cadastro_de_Livros
            // 
            this.button_Cadastro_de_Livros.ForeColor = System.Drawing.Color.DarkRed;
            this.button_Cadastro_de_Livros.Location = new System.Drawing.Point(73, 186);
            this.button_Cadastro_de_Livros.Name = "button_Cadastro_de_Livros";
            this.button_Cadastro_de_Livros.Size = new System.Drawing.Size(203, 51);
            this.button_Cadastro_de_Livros.TabIndex = 2;
            this.button_Cadastro_de_Livros.Text = "Livros";
            this.button_Cadastro_de_Livros.UseVisualStyleBackColor = true;
            this.button_Cadastro_de_Livros.Click += new System.EventHandler(this.button_Cadastro_de_Livros_Click);
            // 
            // button_Cadastro_de_Leitores
            // 
            this.button_Cadastro_de_Leitores.ForeColor = System.Drawing.Color.DarkRed;
            this.button_Cadastro_de_Leitores.Location = new System.Drawing.Point(73, 280);
            this.button_Cadastro_de_Leitores.Name = "button_Cadastro_de_Leitores";
            this.button_Cadastro_de_Leitores.Size = new System.Drawing.Size(207, 57);
            this.button_Cadastro_de_Leitores.TabIndex = 3;
            this.button_Cadastro_de_Leitores.Text = "Leitores";
            this.button_Cadastro_de_Leitores.UseVisualStyleBackColor = true;
            this.button_Cadastro_de_Leitores.Click += new System.EventHandler(this.button_Cadastro_de_Leitores_Click);
            // 
            // button_Registro_de_Emprestimos
            // 
            this.button_Registro_de_Emprestimos.ForeColor = System.Drawing.Color.DarkRed;
            this.button_Registro_de_Emprestimos.Location = new System.Drawing.Point(69, 387);
            this.button_Registro_de_Emprestimos.Name = "button_Registro_de_Emprestimos";
            this.button_Registro_de_Emprestimos.Size = new System.Drawing.Size(207, 63);
            this.button_Registro_de_Emprestimos.TabIndex = 4;
            this.button_Registro_de_Emprestimos.Text = "Empréstimos";
            this.button_Registro_de_Emprestimos.UseVisualStyleBackColor = true;
            this.button_Registro_de_Emprestimos.Click += new System.EventHandler(this.button_Registro_de_Emprestimos_Click);
            // 
            // Menu_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 38F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Biblioteca_Livros_Emprestimo.Properties.Resources.download;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1200, 684);
            this.Controls.Add(this.button_Registro_de_Emprestimos);
            this.Controls.Add(this.button_Cadastro_de_Leitores);
            this.Controls.Add(this.button_Cadastro_de_Livros);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Menu_Principal";
            this.Text = "Menu_Principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button_Cadastro_de_Livros;
        private Button button_Cadastro_de_Leitores;
        private Button button_Registro_de_Emprestimos;
    }
}