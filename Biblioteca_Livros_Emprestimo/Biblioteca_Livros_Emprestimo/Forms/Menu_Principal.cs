using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca_Livros_Emprestimo.Forms
{
    public partial class Menu_Principal : Form
    {
        public Menu_Principal()
        {
            InitializeComponent();
        }


        private void button_Cadastro_de_Livros_Click(object sender, EventArgs e)
        {
            var formLivros = new Cadastro_de_Livros(this);
            formLivros.Show();
            this.Hide();
        }

        private void button_Cadastro_de_Leitores_Click(object sender, EventArgs e)
        {
            var formLeitores = new Cadastro_de_Leitores(this);
            formLeitores.Show();
            this.Hide();
        }

        private void button_Registro_de_Emprestimos_Click(object sender, EventArgs e)
        {
            var formEmprestimos = new Registro_de_Emprestimos(this);
            formEmprestimos.Show();
            this.Hide();
        }
    }
}
