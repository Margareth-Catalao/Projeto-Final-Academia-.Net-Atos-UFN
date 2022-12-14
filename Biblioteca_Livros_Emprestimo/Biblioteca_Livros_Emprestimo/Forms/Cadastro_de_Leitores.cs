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
    public partial class Cadastro_de_Leitores : Form
    {
        private Menu_Principal menuPrincipal;
        public Cadastro_de_Leitores()
        {
            InitializeComponent();
        }

        public Cadastro_de_Leitores(Menu_Principal menu)
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

        private void button_CadastrarLeitor_Click(object sender, EventArgs e)
        {
            Leitor leitor = new Leitor();
            leitor.Nome = textBox_NomeLeitorCd.Text;
            leitor.Endereco = textBox_EnderecoCd.Text;
            leitor.Cpf = textBox1_Cpf_Cd.Text;
            leitor.Telefone = textBox_TelefoneCd.Text;

            bool retorno = leitor.GravarLeitor();

            if (retorno)
            {
                MessageBox.Show("Gravado com sucesso!");
            }
            else
            {
                MessageBox.Show("Erro ao gravar!");
            }
        }

        private void button_EditarInformacoes_Click(object sender, EventArgs e)
        {

            Leitor leitor = new Leitor();
            leitor.Nome = textBoxNomeLeitorEd.Text;
            leitor.Endereco =textBox_EnderecoLeitorEd .Text;
            leitor.Cpf = textBox_Cpf_Ed.Text;
            leitor.Telefone = textBox_Telefone_Ed.Text;

            bool retorno = leitor.EditarLeitor();

            if (retorno)
            {
                MessageBox.Show("Alterado com sucesso!");
            }
            else
            {
                MessageBox.Show("Erro ao alterar!");
            }
        }

        private void button_IdLeitorEx_Click(object sender, EventArgs e)
        {
            Leitor leitor = new Leitor();
            leitor.IdLeitor = int.Parse(textBox_IdLeitorEx.Text);

            leitor = leitor.ConsultaLeitor(leitor.IdLeitor);

            if (leitor == null)
            {
                MessageBox.Show("Erro ao excluir: O Leitor não foi encontrado (404)!");
                return;
            }

            bool retorno = leitor.ExcluirLeitor();

            if (retorno == true)
            {
                MessageBox.Show("Excluído com sucesso!");
            }
            else
            {
                MessageBox.Show("Erro ao executar a exclusão!");
            }
        }

        private void button_NomeConsultaLeitor_Click(object sender, EventArgs e)
        {

            Contexto contexto = new Contexto();
            string sql = "select * from Leitores where Nome = '" + textBox_NomeConsultaLeitor.Text + "'";

            DataTable dt = new DataTable();

            dt = contexto.executarConsultaGenerica(sql);

            dataGridView_Leitor.DataSource = dt;
        }

        private void button_ConsultaIdLeitor_Click(object sender, EventArgs e)
        {
            Leitor leitor = new Leitor();
            leitor.ConsultaLeitor(int.Parse(textBox_IdLeitorConsulta.Text));
            MessageBox.Show(leitor.Nome);
        }

        private void button_ConsultaTodos_Click(object sender, EventArgs e)
        {
            ExibirTd();
        }

        private void ExibirTd()
        {
            Contexto contexto = new Contexto();

            string sql = "select * from Leitores";

            DataTable dt = new DataTable();

            dt = contexto.executarConsultaGenerica(sql);

            dataGridView_Leitor.DataSource = dt;

        }
    }
}
