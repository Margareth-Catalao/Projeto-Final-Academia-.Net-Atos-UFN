using Projeto_Biblioteca_Emprestimo.DataModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Biblioteca_Emprestimo.Forms
{
 
    public partial class Registro_de_Emprestimos : Form
    {
        private Menu_Principal menuPrincipal;
        public Registro_de_Emprestimos()
        {
            InitializeComponent();
        }

        public Registro_de_Emprestimos(Menu_Principal menu)
        {
            menuPrincipal = menu;
            InitializeComponent();
        }

        private void button_VoltarMenu_Click(object sender, EventArgs e)
        {
            menuPrincipal.Show();
            this.Close();
        }

        private void button_GravarEmprestimo_Click(object sender, EventArgs e)
        {
            Emprestimo emprestimo = new Emprestimo();
            emprestimo.IdLeitor = int.Parse(textBox_IdLeitorEmprestimoCd.Text);
            emprestimo.IdLivro = int.Parse(textBox_IdLivroEmprestimoCd.Text);
            emprestimo.DataInicio = DateTime.Parse(dateTimePicker_InicioEmpretimo.Text);
            emprestimo.DataTermino = DateTime.Parse(dateTimePicker_FimEmprestimo.Text);
            emprestimo.Status = textBox_StatusEmprestimo.Text;


            bool retorno = emprestimo.GravarEmprestimo();

            if (retorno)
            {
                MessageBox.Show("Gravado com sucesso!");
            }
            else
            {
                MessageBox.Show("Erro ao gravar!");
            }
        }

        private void button_EditarEmprestimo_Click(object sender, EventArgs e)
        {
            Emprestimo emprestimo = new Emprestimo();
            emprestimo.IdLeitor = int.Parse(textBox_IdLeitorEd.Text);
            emprestimo.IdLivro = int.Parse(textBox_IdLivroEmprestimoCd.Text);
            emprestimo.DataInicio = DateTime.Parse(dateTimePicker_InicioEmprestimoEd.Text);
            emprestimo.DataTermino = DateTime.Parse(dateTimePicker5_FimEmprestimoEd.Text);
            emprestimo.Status = textBox_StatusEmprestimoEd.Text;

            bool retorno = emprestimo.EditarEmprestimo();

            if (retorno)
            {
                MessageBox.Show("Alterado com sucesso!");
            }
            else
            {
                MessageBox.Show("Erro ao alterar!");
            }
        }

        private void button_ConsultaEmprestimoId_Click(object sender, EventArgs e)
        {
            Emprestimo emprestimo = new Emprestimo();
            emprestimo.ConsultaEmprestimo(int.Parse(textBox_IdEmprestimoConsulta.Text));
            MessageBox.Show(emprestimo.Status);
        }

        private void ExibirTd()
        {
            Contexto contexto = new Contexto();

            string sql = "select * from Emprestimo";

            DataTable dt = new DataTable();

            dt = contexto.executarConsultaGenerica(sql);

            dataGridVie_Emprestimo.DataSource = dt;

        }

        private void button_ExcluirIdEmprestimo_Click(object sender, EventArgs e)
        {
            Emprestimo emprestimo = new Emprestimo();
            emprestimo.IdEmprestimo = int.Parse(textBox_ExcluirId.Text);

            emprestimo = emprestimo.ConsultaEmprestimo(emprestimo.IdEmprestimo);

            if (emprestimo == null)
            {
                MessageBox.Show("Erro ao excluir: O Emprestimo não foi encontrado (404)!");
                return;
            }

            bool retorno = emprestimo.ExcluirEmprestimo();

            if (retorno == true)
            {
                MessageBox.Show("Excluído com sucesso!");
            }
            else
            {
                MessageBox.Show("Erro ao executar a exclusão!");
            }
        }

       
    }
}
