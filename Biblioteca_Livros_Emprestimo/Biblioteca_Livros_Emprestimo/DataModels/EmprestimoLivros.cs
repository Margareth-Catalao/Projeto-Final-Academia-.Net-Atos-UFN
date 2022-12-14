using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Livros_Emprestimo.DataModels
{
    public class EmprestimoLivros
    { 

        public int IdEmprestimoLivros { get; set; } 
        public int IdEmprestimo { get; set; }   
        public Emprestimo Emprestimo { get; set; }
        public int IdLivro { get; set; }
        public Livro Livro { get; set; }
        public int Quantidade { get; set; } 


    }
}
