using Biblioteca_Livros_Emprestimo.DataContext;
using Biblioteca_Livros_Emprestimo.DataModels;
using Biblioteca_Livros_Emprestimo.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca_Livros_Emprestimo
{
    public partial class Cadastro_de_Livros : Form
    {
        private Menu_Principal menuPrincipal;
        public Cadastro_de_Livros()
        {
            InitializeComponent();
        }

       public Cadastro_de_Livros(Menu_Principal menu)
        {
            menuPrincipal = menu;
            InitializeComponent();
            ExibirTd();
        }
        private void button_VoltarMenu_Click(object sender, EventArgs e)
        {
            menuPrincipal.Show();
            this.Close();
        }

        private void button_CadastrarLivro_Click(object sender, EventArgs e)
        {
            Livro livro = new Livro();

            livro.Titulo = textBox_TituloCd.Text;
            livro.Autor = textBox_AutorCd.Text;
            livro.Editora = textBox_EditoraCd.Text;
            livro.Edicao = textBox_EdicaoCd.Text;
            livro.Genero = textBox_GeneroCd.Text;

            bool retorno = livro.gravarLivro();

            if (retorno)
            {
                MessageBox.Show("Gravado com sucesso!");
            }
            else
            {
                MessageBox.Show("Erro ao gravar!");
            }
        }

        private void button_EditarLivro_Click(object sender, EventArgs e)
        {
            Livro livro = new Livro();

            livro.Titulo = textBox_TituloEd.Text;
            livro.Autor = textBox_AutorEd.Text;
            livro.Editora = textBox_EditoraEd.Text;
            livro.Edicao = textBox_EdicaoEd.Text;
            livro.Genero = textBox_GeneroEd.Text;
            livro.IdLivro = int.Parse(textBox_IdLivroEd.Text);

            bool retorno = livro.EditarLivro();

            if (retorno)
            {
                MessageBox.Show("Alterado com sucesso!");
            }
            else
            {
                MessageBox.Show("Erro ao alterar!");
            }
        }

        private void button_ExcluirLivro_Click(object sender, EventArgs e)
        {
            Livro livro = new Livro();
            livro.IdLivro = int.Parse(textBox1_ExcluirId.Text);

            livro = livro.ConsultaLivro(livro.IdLivro);

            if (livro == null)
            {
                MessageBox.Show("Erro ao excluir: O livro não foi encontrado (404)!");
                return;
            }

            bool retorno = livro.ExcluirLivro();

            if (retorno == true)
            {
                MessageBox.Show("Excluído com sucesso!");
            }
            else
            {
                MessageBox.Show("Erro ao executar a exclusão!");
            }
        }

        private void button_ConsultaTitulo_Click(object sender, EventArgs e)
        {
            Contexto contexto = new Contexto();

            string sql = "select * from Livros where Titulo = '" + textBox1_ConsultaTitulo.Text + "'";

            DataTable dt = new DataTable();

            dt = contexto.executarConsultaGenerica(sql);

            dataGridView1_Livro.DataSource = dt;
        }

        private void button_ConsultarLivroId_Click(object sender, EventArgs e)
        {
            Livro livro= new Livro();
            livro.ConsultaLivro(int.Parse(textBox_ConsultaId.Text));
            MessageBox.Show(livro.Titulo);
        }

        private void button_ConsultarTodos_Click(object sender, EventArgs e)
        {
            ExibirTd();
        }

        private void ExibirTd()
        {
           Contexto contexto = new Contexto();

            string sql = "select * from Livros";

            DataTable dt = new DataTable();

            dt = contexto.executarConsultaGenerica(sql);

            dataGridView1_Livro.DataSource = dt;

        }
    }
}

