namespace Projeto_Biblioteca_Emprestimo.Forms
{
    partial class Cadastro_de_Livros
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
            this.button_CadastrarLivro = new System.Windows.Forms.Button();
            this.textBox_GeneroCd = new System.Windows.Forms.TextBox();
            this.textBox_EdicaoCd = new System.Windows.Forms.TextBox();
            this.textBox_EditoraCd = new System.Windows.Forms.TextBox();
            this.textBox_AutorCd = new System.Windows.Forms.TextBox();
            this.textBox_TituloCd = new System.Windows.Forms.TextBox();
            this.label_Genero = new System.Windows.Forms.Label();
            this.label_Edicao = new System.Windows.Forms.Label();
            this.label_Editora = new System.Windows.Forms.Label();
            this.label_Autor = new System.Windows.Forms.Label();
            this.label_Titulo = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox_IdLivroEd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button_EditarLivro = new System.Windows.Forms.Button();
            this.textBox_GeneroEd = new System.Windows.Forms.TextBox();
            this.textBox_EdicaoEd = new System.Windows.Forms.TextBox();
            this.textBox_EditoraEd = new System.Windows.Forms.TextBox();
            this.textBox_AutorEd = new System.Windows.Forms.TextBox();
            this.textBox_TituloEd = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dataGridView1_Livro = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_ConsultarLivroId = new System.Windows.Forms.Button();
            this.textBox_ConsultaId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_ConsultarTodos = new System.Windows.Forms.Button();
            this.button_ConsultaTitulo = new System.Windows.Forms.Button();
            this.textBox1_ConsultaTitulo = new System.Windows.Forms.TextBox();
            this.IdLivro = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button_ExcluirLivro = new System.Windows.Forms.Button();
            this.textBox1_ExcluirId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button_VoltarMenu = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_Livro)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LemonChiffon;
            this.groupBox2.Controls.Add(this.button_CadastrarLivro);
            this.groupBox2.Controls.Add(this.textBox_GeneroCd);
            this.groupBox2.Controls.Add(this.textBox_EdicaoCd);
            this.groupBox2.Controls.Add(this.textBox_EditoraCd);
            this.groupBox2.Controls.Add(this.textBox_AutorCd);
            this.groupBox2.Controls.Add(this.textBox_TituloCd);
            this.groupBox2.Controls.Add(this.label_Genero);
            this.groupBox2.Controls.Add(this.label_Edicao);
            this.groupBox2.Controls.Add(this.label_Editora);
            this.groupBox2.Controls.Add(this.label_Autor);
            this.groupBox2.Controls.Add(this.label_Titulo);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(33, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(400, 325);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cadastar Livro";
            // 
            // button_CadastrarLivro
            // 
            this.button_CadastrarLivro.BackColor = System.Drawing.Color.White;
            this.button_CadastrarLivro.Location = new System.Drawing.Point(122, 262);
            this.button_CadastrarLivro.Name = "button_CadastrarLivro";
            this.button_CadastrarLivro.Size = new System.Drawing.Size(241, 45);
            this.button_CadastrarLivro.TabIndex = 10;
            this.button_CadastrarLivro.Text = "Cadastrar";
            this.button_CadastrarLivro.UseVisualStyleBackColor = false;
            this.button_CadastrarLivro.Click += new System.EventHandler(this.button_CadastrarLivro_Click);
            // 
            // textBox_GeneroCd
            // 
            this.textBox_GeneroCd.Location = new System.Drawing.Point(122, 217);
            this.textBox_GeneroCd.Name = "textBox_GeneroCd";
            this.textBox_GeneroCd.Size = new System.Drawing.Size(241, 37);
            this.textBox_GeneroCd.TabIndex = 9;
            // 
            // textBox_EdicaoCd
            // 
            this.textBox_EdicaoCd.Location = new System.Drawing.Point(122, 174);
            this.textBox_EdicaoCd.Name = "textBox_EdicaoCd";
            this.textBox_EdicaoCd.Size = new System.Drawing.Size(241, 37);
            this.textBox_EdicaoCd.TabIndex = 8;
            // 
            // textBox_EditoraCd
            // 
            this.textBox_EditoraCd.Location = new System.Drawing.Point(122, 131);
            this.textBox_EditoraCd.Name = "textBox_EditoraCd";
            this.textBox_EditoraCd.Size = new System.Drawing.Size(241, 37);
            this.textBox_EditoraCd.TabIndex = 7;
            // 
            // textBox_AutorCd
            // 
            this.textBox_AutorCd.Location = new System.Drawing.Point(122, 88);
            this.textBox_AutorCd.Name = "textBox_AutorCd";
            this.textBox_AutorCd.Size = new System.Drawing.Size(241, 37);
            this.textBox_AutorCd.TabIndex = 6;
            // 
            // textBox_TituloCd
            // 
            this.textBox_TituloCd.BackColor = System.Drawing.Color.White;
            this.textBox_TituloCd.ForeColor = System.Drawing.Color.Black;
            this.textBox_TituloCd.Location = new System.Drawing.Point(122, 45);
            this.textBox_TituloCd.Name = "textBox_TituloCd";
            this.textBox_TituloCd.Size = new System.Drawing.Size(241, 37);
            this.textBox_TituloCd.TabIndex = 5;
            // 
            // label_Genero
            // 
            this.label_Genero.AutoSize = true;
            this.label_Genero.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_Genero.Location = new System.Drawing.Point(6, 231);
            this.label_Genero.Name = "label_Genero";
            this.label_Genero.Size = new System.Drawing.Size(94, 29);
            this.label_Genero.TabIndex = 4;
            this.label_Genero.Text = "Genero:";
            // 
            // label_Edicao
            // 
            this.label_Edicao.AutoSize = true;
            this.label_Edicao.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_Edicao.Location = new System.Drawing.Point(14, 182);
            this.label_Edicao.Name = "label_Edicao";
            this.label_Edicao.Size = new System.Drawing.Size(86, 29);
            this.label_Edicao.TabIndex = 3;
            this.label_Edicao.Text = "Edição:";
            // 
            // label_Editora
            // 
            this.label_Editora.AutoSize = true;
            this.label_Editora.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_Editora.Location = new System.Drawing.Point(8, 139);
            this.label_Editora.Name = "label_Editora";
            this.label_Editora.Size = new System.Drawing.Size(92, 29);
            this.label_Editora.TabIndex = 2;
            this.label_Editora.Text = "Editora:";
            // 
            // label_Autor
            // 
            this.label_Autor.AutoSize = true;
            this.label_Autor.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_Autor.Location = new System.Drawing.Point(19, 96);
            this.label_Autor.Name = "label_Autor";
            this.label_Autor.Size = new System.Drawing.Size(78, 29);
            this.label_Autor.TabIndex = 1;
            this.label_Autor.Text = "Autor:";
            // 
            // label_Titulo
            // 
            this.label_Titulo.AutoSize = true;
            this.label_Titulo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_Titulo.Location = new System.Drawing.Point(19, 52);
            this.label_Titulo.Name = "label_Titulo";
            this.label_Titulo.Size = new System.Drawing.Size(78, 29);
            this.label_Titulo.TabIndex = 0;
            this.label_Titulo.Text = "Título:";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.LemonChiffon;
            this.groupBox3.Controls.Add(this.textBox_IdLivroEd);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.button_EditarLivro);
            this.groupBox3.Controls.Add(this.textBox_GeneroEd);
            this.groupBox3.Controls.Add(this.textBox_EdicaoEd);
            this.groupBox3.Controls.Add(this.textBox_EditoraEd);
            this.groupBox3.Controls.Add(this.textBox_AutorEd);
            this.groupBox3.Controls.Add(this.textBox_TituloEd);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(33, 365);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(400, 373);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Editar Informações";
            // 
            // textBox_IdLivroEd
            // 
            this.textBox_IdLivroEd.Location = new System.Drawing.Point(135, 271);
            this.textBox_IdLivroEd.Name = "textBox_IdLivroEd";
            this.textBox_IdLivroEd.Size = new System.Drawing.Size(241, 37);
            this.textBox_IdLivroEd.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 29);
            this.label3.TabIndex = 22;
            this.label3.Text = "IdLivro:";
            // 
            // button_EditarLivro
            // 
            this.button_EditarLivro.BackColor = System.Drawing.Color.White;
            this.button_EditarLivro.Location = new System.Drawing.Point(135, 317);
            this.button_EditarLivro.Name = "button_EditarLivro";
            this.button_EditarLivro.Size = new System.Drawing.Size(241, 45);
            this.button_EditarLivro.TabIndex = 21;
            this.button_EditarLivro.Text = "Editar";
            this.button_EditarLivro.UseVisualStyleBackColor = false;
            this.button_EditarLivro.Click += new System.EventHandler(this.button_EditarLivro_Click);
            // 
            // textBox_GeneroEd
            // 
            this.textBox_GeneroEd.Location = new System.Drawing.Point(135, 228);
            this.textBox_GeneroEd.Name = "textBox_GeneroEd";
            this.textBox_GeneroEd.Size = new System.Drawing.Size(241, 37);
            this.textBox_GeneroEd.TabIndex = 20;
            // 
            // textBox_EdicaoEd
            // 
            this.textBox_EdicaoEd.Location = new System.Drawing.Point(135, 179);
            this.textBox_EdicaoEd.Name = "textBox_EdicaoEd";
            this.textBox_EdicaoEd.Size = new System.Drawing.Size(241, 37);
            this.textBox_EdicaoEd.TabIndex = 19;
            // 
            // textBox_EditoraEd
            // 
            this.textBox_EditoraEd.Location = new System.Drawing.Point(135, 132);
            this.textBox_EditoraEd.Name = "textBox_EditoraEd";
            this.textBox_EditoraEd.Size = new System.Drawing.Size(241, 37);
            this.textBox_EditoraEd.TabIndex = 18;
            // 
            // textBox_AutorEd
            // 
            this.textBox_AutorEd.Location = new System.Drawing.Point(135, 89);
            this.textBox_AutorEd.Name = "textBox_AutorEd";
            this.textBox_AutorEd.Size = new System.Drawing.Size(241, 37);
            this.textBox_AutorEd.TabIndex = 17;
            // 
            // textBox_TituloEd
            // 
            this.textBox_TituloEd.BackColor = System.Drawing.Color.White;
            this.textBox_TituloEd.ForeColor = System.Drawing.Color.Black;
            this.textBox_TituloEd.Location = new System.Drawing.Point(135, 46);
            this.textBox_TituloEd.Name = "textBox_TituloEd";
            this.textBox_TituloEd.Size = new System.Drawing.Size(241, 37);
            this.textBox_TituloEd.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(19, 228);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 29);
            this.label9.TabIndex = 15;
            this.label9.Text = "Genero:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(32, 179);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 29);
            this.label10.TabIndex = 14;
            this.label10.Text = "Edição:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(21, 132);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 29);
            this.label11.TabIndex = 13;
            this.label11.Text = "Editora:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(32, 89);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 29);
            this.label12.TabIndex = 12;
            this.label12.Text = "Autor:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(32, 48);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(78, 29);
            this.label13.TabIndex = 11;
            this.label13.Text = "Título:";
            // 
            // dataGridView1_Livro
            // 
            this.dataGridView1_Livro.AllowUserToAddRows = false;
            this.dataGridView1_Livro.AllowUserToDeleteRows = false;
            this.dataGridView1_Livro.BackgroundColor = System.Drawing.Color.LemonChiffon;
            this.dataGridView1_Livro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1_Livro.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1_Livro.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1_Livro.Location = new System.Drawing.Point(489, 23);
            this.dataGridView1_Livro.Name = "dataGridView1_Livro";
            this.dataGridView1_Livro.ReadOnly = true;
            this.dataGridView1_Livro.RowHeadersWidth = 62;
            this.dataGridView1_Livro.RowTemplate.Height = 33;
            this.dataGridView1_Livro.Size = new System.Drawing.Size(713, 299);
            this.dataGridView1_Livro.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LemonChiffon;
            this.groupBox1.Controls.Add(this.button_ConsultarLivroId);
            this.groupBox1.Controls.Add(this.textBox_ConsultaId);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button_ConsultarTodos);
            this.groupBox1.Controls.Add(this.button_ConsultaTitulo);
            this.groupBox1.Controls.Add(this.textBox1_ConsultaTitulo);
            this.groupBox1.Controls.Add(this.IdLivro);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(513, 365);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(402, 339);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consultar Livro";
            // 
            // button_ConsultarLivroId
            // 
            this.button_ConsultarLivroId.BackColor = System.Drawing.Color.White;
            this.button_ConsultarLivroId.Location = new System.Drawing.Point(123, 209);
            this.button_ConsultarLivroId.Name = "button_ConsultarLivroId";
            this.button_ConsultarLivroId.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button_ConsultarLivroId.Size = new System.Drawing.Size(198, 44);
            this.button_ConsultarLivroId.TabIndex = 6;
            this.button_ConsultarLivroId.Text = "Consultar";
            this.button_ConsultarLivroId.UseVisualStyleBackColor = false;
            this.button_ConsultarLivroId.Click += new System.EventHandler(this.button_ConsultarLivroId_Click);
            // 
            // textBox_ConsultaId
            // 
            this.textBox_ConsultaId.Location = new System.Drawing.Point(123, 166);
            this.textBox_ConsultaId.Name = "textBox_ConsultaId";
            this.textBox_ConsultaId.Size = new System.Drawing.Size(198, 37);
            this.textBox_ConsultaId.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "IdLivro:";
            // 
            // button_ConsultarTodos
            // 
            this.button_ConsultarTodos.BackColor = System.Drawing.Color.White;
            this.button_ConsultarTodos.Location = new System.Drawing.Point(119, 276);
            this.button_ConsultarTodos.Name = "button_ConsultarTodos";
            this.button_ConsultarTodos.Size = new System.Drawing.Size(198, 46);
            this.button_ConsultarTodos.TabIndex = 3;
            this.button_ConsultarTodos.Text = "Consultar Todos";
            this.button_ConsultarTodos.UseVisualStyleBackColor = false;
            this.button_ConsultarTodos.Click += new System.EventHandler(this.button_ConsultarTodos_Click);
            // 
            // button_ConsultaTitulo
            // 
            this.button_ConsultaTitulo.BackColor = System.Drawing.Color.White;
            this.button_ConsultaTitulo.Location = new System.Drawing.Point(119, 98);
            this.button_ConsultaTitulo.Name = "button_ConsultaTitulo";
            this.button_ConsultaTitulo.Size = new System.Drawing.Size(201, 38);
            this.button_ConsultaTitulo.TabIndex = 2;
            this.button_ConsultaTitulo.Text = "Consultar";
            this.button_ConsultaTitulo.UseVisualStyleBackColor = false;
            this.button_ConsultaTitulo.Click += new System.EventHandler(this.button_ConsultaTitulo_Click);
            // 
            // textBox1_ConsultaTitulo
            // 
            this.textBox1_ConsultaTitulo.Location = new System.Drawing.Point(119, 55);
            this.textBox1_ConsultaTitulo.Name = "textBox1_ConsultaTitulo";
            this.textBox1_ConsultaTitulo.Size = new System.Drawing.Size(198, 37);
            this.textBox1_ConsultaTitulo.TabIndex = 1;
            // 
            // IdLivro
            // 
            this.IdLivro.AutoSize = true;
            this.IdLivro.Location = new System.Drawing.Point(29, 58);
            this.IdLivro.Name = "IdLivro";
            this.IdLivro.Size = new System.Drawing.Size(78, 29);
            this.IdLivro.TabIndex = 0;
            this.IdLivro.Text = "Titulo:";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.LemonChiffon;
            this.groupBox4.Controls.Add(this.button_ExcluirLivro);
            this.groupBox4.Controls.Add(this.textBox1_ExcluirId);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox4.ForeColor = System.Drawing.Color.Black;
            this.groupBox4.Location = new System.Drawing.Point(937, 365);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(265, 159);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Excluir Livro";
            // 
            // button_ExcluirLivro
            // 
            this.button_ExcluirLivro.BackColor = System.Drawing.Color.White;
            this.button_ExcluirLivro.Location = new System.Drawing.Point(108, 98);
            this.button_ExcluirLivro.Name = "button_ExcluirLivro";
            this.button_ExcluirLivro.Size = new System.Drawing.Size(150, 34);
            this.button_ExcluirLivro.TabIndex = 2;
            this.button_ExcluirLivro.Text = "Excluir";
            this.button_ExcluirLivro.UseVisualStyleBackColor = false;
            this.button_ExcluirLivro.Click += new System.EventHandler(this.button_ExcluirLivro_Click);
            // 
            // textBox1_ExcluirId
            // 
            this.textBox1_ExcluirId.Location = new System.Drawing.Point(108, 57);
            this.textBox1_ExcluirId.Name = "textBox1_ExcluirId";
            this.textBox1_ExcluirId.Size = new System.Drawing.Size(150, 37);
            this.textBox1_ExcluirId.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "IdLivro:";
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.LemonChiffon;
            this.groupBox5.Controls.Add(this.button_VoltarMenu);
            this.groupBox5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox5.Location = new System.Drawing.Point(937, 544);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(265, 160);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Voltar ao Menu Principal";
            // 
            // button_VoltarMenu
            // 
            this.button_VoltarMenu.BackColor = System.Drawing.Color.White;
            this.button_VoltarMenu.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_VoltarMenu.Location = new System.Drawing.Point(82, 56);
            this.button_VoltarMenu.Name = "button_VoltarMenu";
            this.button_VoltarMenu.Size = new System.Drawing.Size(112, 45);
            this.button_VoltarMenu.TabIndex = 5;
            this.button_VoltarMenu.Text = "Voltar ";
            this.button_VoltarMenu.UseVisualStyleBackColor = false;
            this.button_VoltarMenu.Click += new System.EventHandler(this.button_VoltarMenu_Click);
            // 
            // Cadastro_de_Livros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 40F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projeto_Biblioteca_Emprestimo.Properties.Resources.istockphoto_929023224_1024x1024;
            this.ClientSize = new System.Drawing.Size(1257, 749);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1_Livro);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Cadastro_de_Livros";
            this.Text = "Cadastro_de_Livros";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_Livro)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox2;
        private Button button_CadastrarLivro;
        private TextBox textBox_GeneroCd;
        private TextBox textBox_EdicaoCd;
        private TextBox textBox_EditoraCd;
        private TextBox textBox_AutorCd;
        private TextBox textBox_TituloCd;
        private Label label_Genero;
        private Label label_Edicao;
        private Label label_Editora;
        private Label label_Autor;
        private Label label_Titulo;
        private GroupBox groupBox3;
        private TextBox textBox_IdLivroEd;
        private Label label3;
        private Button button_EditarLivro;
        private TextBox textBox_GeneroEd;
        private TextBox textBox_EdicaoEd;
        private TextBox textBox_EditoraEd;
        private TextBox textBox_AutorEd;
        private TextBox textBox_TituloEd;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private DataGridView dataGridView1_Livro;
        private GroupBox groupBox1;
        private Button button_ConsultarLivroId;
        private TextBox textBox_ConsultaId;
        private Label label1;
        private Button button_ConsultarTodos;
        private Button button_ConsultaTitulo;
        private TextBox textBox1_ConsultaTitulo;
        private Label IdLivro;
        private GroupBox groupBox4;
        private Button button_ExcluirLivro;
        private TextBox textBox1_ExcluirId;
        private Label label2;
        private GroupBox groupBox5;
        private Button button_VoltarMenu;
    }
}