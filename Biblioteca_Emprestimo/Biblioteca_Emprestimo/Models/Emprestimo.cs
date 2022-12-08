using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

namespace Biblioteca_Emprestimo.Models
{
    public class Emprestimo
    {
        
        public int IdEmprestimo { get; set; }
        public int idLivro { get; set; }
        public int idPessoa{ get; set;}
        public DateTime DataEmprestimo{ get; set;} 
        public DateTime DataDevolucao { get; set;}  
    }
}
