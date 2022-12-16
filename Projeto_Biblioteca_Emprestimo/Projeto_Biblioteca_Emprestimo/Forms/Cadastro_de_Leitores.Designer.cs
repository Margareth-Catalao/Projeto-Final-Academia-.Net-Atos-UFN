namespace Projeto_Biblioteca_Emprestimo.Forms
{
    partial class Cadastro_de_Leitores
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_CadastrarLeitor = new System.Windows.Forms.Button();
            this.textBox_TelefoneCd = new System.Windows.Forms.TextBox();
            this.textBox_EnderecoCd = new System.Windows.Forms.TextBox();
            this.textBox_NomeLeitorCd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1_Cpf_Cd = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_IdLeitorEd = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.button_EditarInformacoes = new System.Windows.Forms.Button();
            this.textBox_Telefone_Ed = new System.Windows.Forms.TextBox();
            this.textBox_Cpf_Ed = new System.Windows.Forms.TextBox();
            this.textBox_EnderecoLeitorEd = new System.Windows.Forms.TextBox();
            this.textBoxNomeLeitorEd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView_Leitor = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox_NomeConsultaLeitor = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.button_NomeConsultaLeitor = new System.Windows.Forms.Button();
            this.button_ConsultaTodos = new System.Windows.Forms.Button();
            this.button_ConsultaIdLeitor = new System.Windows.Forms.Button();
            this.textBox_IdLeitorConsulta = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button_IdLeitorEx = new System.Windows.Forms.Button();
            this.textBox_IdLeitorEx = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button_VoltarMenu = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Leitor)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.button_CadastrarLeitor);
            this.groupBox2.Controls.Add(this.textBox_TelefoneCd);
            this.groupBox2.Controls.Add(this.textBox_EnderecoCd);
            this.groupBox2.Controls.Add(this.textBox_NomeLeitorCd);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.textBox1_Cpf_Cd);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(27, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(391, 289);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cadastrar Leitor";
            // 
            // button_CadastrarLeitor
            // 
            this.button_CadastrarLeitor.Location = new System.Drawing.Point(134, 229);
            this.button_CadastrarLeitor.Name = "button_CadastrarLeitor";
            this.button_CadastrarLeitor.Size = new System.Drawing.Size(239, 42);
            this.button_CadastrarLeitor.TabIndex = 19;
            this.button_CadastrarLeitor.Text = "Cadastrar";
            this.button_CadastrarLeitor.UseVisualStyleBackColor = true;
            this.button_CadastrarLeitor.Click += new System.EventHandler(this.button_CadastrarLeitor_Click);
            // 
            // textBox_TelefoneCd
            // 
            this.textBox_TelefoneCd.Location = new System.Drawing.Point(134, 179);
            this.textBox_TelefoneCd.Name = "textBox_TelefoneCd";
            this.textBox_TelefoneCd.Size = new System.Drawing.Size(239, 37);
            this.textBox_TelefoneCd.TabIndex = 14;
            // 
            // textBox_EnderecoCd
            // 
            this.textBox_EnderecoCd.Location = new System.Drawing.Point(134, 93);
            this.textBox_EnderecoCd.Name = "textBox_EnderecoCd";
            this.textBox_EnderecoCd.Size = new System.Drawing.Size(239, 37);
            this.textBox_EnderecoCd.TabIndex = 18;
            // 
            // textBox_NomeLeitorCd
            // 
            this.textBox_NomeLeitorCd.Location = new System.Drawing.Point(134, 50);
            this.textBox_NomeLeitorCd.Name = "textBox_NomeLeitorCd";
            this.textBox_NomeLeitorCd.Size = new System.Drawing.Size(239, 37);
            this.textBox_NomeLeitorCd.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 29);
            this.label7.TabIndex = 15;
            this.label7.Text = "Endereço:";
            // 
            // textBox1_Cpf_Cd
            // 
            this.textBox1_Cpf_Cd.Location = new System.Drawing.Point(134, 136);
            this.textBox1_Cpf_Cd.Name = "textBox1_Cpf_Cd";
            this.textBox1_Cpf_Cd.Size = new System.Drawing.Size(239, 37);
            this.textBox1_Cpf_Cd.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 179);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 29);
            this.label8.TabIndex = 11;
            this.label8.Text = "Telefone:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(74, 139);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 29);
            this.label9.TabIndex = 10;
            this.label9.Text = "Cpf:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(47, 50);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 29);
            this.label10.TabIndex = 13;
            this.label10.Text = "Nome:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.textBox_IdLeitorEd);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.button_EditarInformacoes);
            this.groupBox1.Controls.Add(this.textBox_Telefone_Ed);
            this.groupBox1.Controls.Add(this.textBox_Cpf_Ed);
            this.groupBox1.Controls.Add(this.textBox_EnderecoLeitorEd);
            this.groupBox1.Controls.Add(this.textBoxNomeLeitorEd);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(27, 344);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(391, 337);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Editar Informações";
            // 
            // textBox_IdLeitorEd
            // 
            this.textBox_IdLeitorEd.Location = new System.Drawing.Point(128, 54);
            this.textBox_IdLeitorEd.Name = "textBox_IdLeitorEd";
            this.textBox_IdLeitorEd.Size = new System.Drawing.Size(239, 37);
            this.textBox_IdLeitorEd.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(28, 57);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 29);
            this.label11.TabIndex = 9;
            this.label11.Text = "IdLeitor:";
            // 
            // button_EditarInformacoes
            // 
            this.button_EditarInformacoes.Location = new System.Drawing.Point(134, 269);
            this.button_EditarInformacoes.Name = "button_EditarInformacoes";
            this.button_EditarInformacoes.Size = new System.Drawing.Size(233, 46);
            this.button_EditarInformacoes.TabIndex = 8;
            this.button_EditarInformacoes.Text = "Editar";
            this.button_EditarInformacoes.UseVisualStyleBackColor = true;
            this.button_EditarInformacoes.Click += new System.EventHandler(this.button_EditarInformacoes_Click);
            // 
            // textBox_Telefone_Ed
            // 
            this.textBox_Telefone_Ed.Location = new System.Drawing.Point(128, 226);
            this.textBox_Telefone_Ed.Name = "textBox_Telefone_Ed";
            this.textBox_Telefone_Ed.Size = new System.Drawing.Size(239, 37);
            this.textBox_Telefone_Ed.TabIndex = 7;
            // 
            // textBox_Cpf_Ed
            // 
            this.textBox_Cpf_Ed.Location = new System.Drawing.Point(128, 183);
            this.textBox_Cpf_Ed.Name = "textBox_Cpf_Ed";
            this.textBox_Cpf_Ed.Size = new System.Drawing.Size(239, 37);
            this.textBox_Cpf_Ed.TabIndex = 6;
            // 
            // textBox_EnderecoLeitorEd
            // 
            this.textBox_EnderecoLeitorEd.Location = new System.Drawing.Point(128, 140);
            this.textBox_EnderecoLeitorEd.Name = "textBox_EnderecoLeitorEd";
            this.textBox_EnderecoLeitorEd.Size = new System.Drawing.Size(239, 37);
            this.textBox_EnderecoLeitorEd.TabIndex = 5;
            // 
            // textBoxNomeLeitorEd
            // 
            this.textBoxNomeLeitorEd.Location = new System.Drawing.Point(128, 97);
            this.textBoxNomeLeitorEd.Name = "textBoxNomeLeitorEd";
            this.textBoxNomeLeitorEd.Size = new System.Drawing.Size(239, 37);
            this.textBoxNomeLeitorEd.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefone:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cpf:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Endereço:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // dataGridView_Leitor
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dataGridView_Leitor.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_Leitor.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_Leitor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Leitor.Location = new System.Drawing.Point(459, 24);
            this.dataGridView_Leitor.Name = "dataGridView_Leitor";
            this.dataGridView_Leitor.RowHeadersWidth = 62;
            this.dataGridView_Leitor.RowTemplate.Height = 33;
            this.dataGridView_Leitor.Size = new System.Drawing.Size(746, 294);
            this.dataGridView_Leitor.TabIndex = 5;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.textBox_NomeConsultaLeitor);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.button_NomeConsultaLeitor);
            this.groupBox3.Controls.Add(this.button_ConsultaTodos);
            this.groupBox3.Controls.Add(this.button_ConsultaIdLeitor);
            this.groupBox3.Controls.Add(this.textBox_IdLeitorConsulta);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(459, 344);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(322, 357);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Consultar Leitores";
            // 
            // textBox_NomeConsultaLeitor
            // 
            this.textBox_NomeConsultaLeitor.Location = new System.Drawing.Point(22, 66);
            this.textBox_NomeConsultaLeitor.Name = "textBox_NomeConsultaLeitor";
            this.textBox_NomeConsultaLeitor.Size = new System.Drawing.Size(276, 37);
            this.textBox_NomeConsultaLeitor.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(22, 33);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 29);
            this.label12.TabIndex = 8;
            this.label12.Text = "Nome:";
            // 
            // button_NomeConsultaLeitor
            // 
            this.button_NomeConsultaLeitor.Location = new System.Drawing.Point(22, 114);
            this.button_NomeConsultaLeitor.Name = "button_NomeConsultaLeitor";
            this.button_NomeConsultaLeitor.Size = new System.Drawing.Size(276, 38);
            this.button_NomeConsultaLeitor.TabIndex = 7;
            this.button_NomeConsultaLeitor.Text = "Consultar";
            this.button_NomeConsultaLeitor.UseVisualStyleBackColor = true;
            this.button_NomeConsultaLeitor.Click += new System.EventHandler(this.button_NomeConsultaLeitor_Click);
            // 
            // button_ConsultaTodos
            // 
            this.button_ConsultaTodos.Location = new System.Drawing.Point(22, 281);
            this.button_ConsultaTodos.Name = "button_ConsultaTodos";
            this.button_ConsultaTodos.Size = new System.Drawing.Size(276, 44);
            this.button_ConsultaTodos.TabIndex = 6;
            this.button_ConsultaTodos.Text = "Consulta a todos";
            this.button_ConsultaTodos.UseVisualStyleBackColor = true;
            this.button_ConsultaTodos.Click += new System.EventHandler(this.button_ConsultaTodos_Click);
            // 
            // button_ConsultaIdLeitor
            // 
            this.button_ConsultaIdLeitor.Location = new System.Drawing.Point(22, 230);
            this.button_ConsultaIdLeitor.Name = "button_ConsultaIdLeitor";
            this.button_ConsultaIdLeitor.Size = new System.Drawing.Size(276, 45);
            this.button_ConsultaIdLeitor.TabIndex = 5;
            this.button_ConsultaIdLeitor.Text = "Consulta";
            this.button_ConsultaIdLeitor.UseVisualStyleBackColor = true;
            this.button_ConsultaIdLeitor.Click += new System.EventHandler(this.button_ConsultaIdLeitor_Click);
            // 
            // textBox_IdLeitorConsulta
            // 
            this.textBox_IdLeitorConsulta.Location = new System.Drawing.Point(22, 187);
            this.textBox_IdLeitorConsulta.Name = "textBox_IdLeitorConsulta";
            this.textBox_IdLeitorConsulta.Size = new System.Drawing.Size(276, 37);
            this.textBox_IdLeitorConsulta.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 29);
            this.label6.TabIndex = 1;
            this.label6.Text = "IdLeitor:";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.White;
            this.groupBox4.Controls.Add(this.button_IdLeitorEx);
            this.groupBox4.Controls.Add(this.textBox_IdLeitorEx);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox4.ForeColor = System.Drawing.Color.Black;
            this.groupBox4.Location = new System.Drawing.Point(875, 344);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(320, 184);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Excluir Leitor";
            // 
            // button_IdLeitorEx
            // 
            this.button_IdLeitorEx.Location = new System.Drawing.Point(41, 114);
            this.button_IdLeitorEx.Name = "button_IdLeitorEx";
            this.button_IdLeitorEx.Size = new System.Drawing.Size(253, 38);
            this.button_IdLeitorEx.TabIndex = 2;
            this.button_IdLeitorEx.Text = "Excluir";
            this.button_IdLeitorEx.UseVisualStyleBackColor = true;
            this.button_IdLeitorEx.Click += new System.EventHandler(this.button_IdLeitorEx_Click);
            // 
            // textBox_IdLeitorEx
            // 
            this.textBox_IdLeitorEx.Location = new System.Drawing.Point(41, 65);
            this.textBox_IdLeitorEx.Name = "textBox_IdLeitorEx";
            this.textBox_IdLeitorEx.Size = new System.Drawing.Size(244, 37);
            this.textBox_IdLeitorEx.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 29);
            this.label5.TabIndex = 0;
            this.label5.Text = "IdLeitor:";
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox5.Controls.Add(this.button_VoltarMenu);
            this.groupBox5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox5.Location = new System.Drawing.Point(875, 559);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(294, 142);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Voltar ao Menu Principal";
            // 
            // button_VoltarMenu
            // 
            this.button_VoltarMenu.Location = new System.Drawing.Point(94, 66);
            this.button_VoltarMenu.Name = "button_VoltarMenu";
            this.button_VoltarMenu.Size = new System.Drawing.Size(112, 34);
            this.button_VoltarMenu.TabIndex = 0;
            this.button_VoltarMenu.Text = "Voltar";
            this.button_VoltarMenu.UseVisualStyleBackColor = true;
            this.button_VoltarMenu.Click += new System.EventHandler(this.button_VoltarMenu_Click);
            // 
            // Cadastro_de_Leitores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 40F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projeto_Biblioteca_Emprestimo.Properties.Resources.LivroForm;
            this.ClientSize = new System.Drawing.Size(1257, 749);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dataGridView_Leitor);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Cadastro_de_Leitores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro_de_Leitores";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Leitor)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox2;
        private Button button_CadastrarLeitor;
        private TextBox textBox_TelefoneCd;
        private TextBox textBox_EnderecoCd;
        private TextBox textBox_NomeLeitorCd;
        private Label label7;
        private TextBox textBox1_Cpf_Cd;
        private Label label8;
        private Label label9;
        private Label label10;
        private GroupBox groupBox1;
        private TextBox textBox_IdLeitorEd;
        private Label label11;
        private Button button_EditarInformacoes;
        private TextBox textBox_Telefone_Ed;
        private TextBox textBox_Cpf_Ed;
        private TextBox textBox_EnderecoLeitorEd;
        private TextBox textBoxNomeLeitorEd;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dataGridView_Leitor;
        private GroupBox groupBox3;
        private TextBox textBox_NomeConsultaLeitor;
        private Label label12;
        private Button button_NomeConsultaLeitor;
        private Button button_ConsultaTodos;
        private Button button_ConsultaIdLeitor;
        private TextBox textBox_IdLeitorConsulta;
        private Label label6;
        private GroupBox groupBox4;
        private Button button_IdLeitorEx;
        private TextBox textBox_IdLeitorEx;
        private Label label5;
        private GroupBox groupBox5;
        private Button button_VoltarMenu;
    }
}