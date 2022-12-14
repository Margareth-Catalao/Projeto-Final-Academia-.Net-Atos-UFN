using Biblioteca_Livros_Emprestimo.DataModels;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Livros_Emprestimo.DataContext
{
    public class Contexto : DbContext
    {
        public DbSet <Livro> Livros { get; set; }
        public DbSet<Cadastro_de_Leitores> Leitores { get; set; }
        public DbSet<Emprestimo> Emprestimos { get; set; }
        public DbSet<EmprestimoLivros> EmprestimoLivros { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer("Data Source=localhost; "
            + "initial Catalog=Biblioteca_de_Livro_Emprestimo_db;User ID=usuario; "
            + "password=andrade2021;language=Portuguese;Trusted_Connection=True;"
            + "TrustServerCertificate=True;");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Livro>(entity =>
            {
                entity.ToTable("Livros");
                entity.HasKey(p => p.IdLivro);
                entity.Property(p => p.Titulo).HasColumnType("VARCHAR (60)").IsRequired();
                entity.Property(p => p.Autor).HasColumnType("VARCHAR (60)").IsRequired();
                entity.Property(p => p.Editora).HasColumnType("VARCHAR (60)").IsRequired();
                entity.Property(p => p.Edicao).HasColumnType("VARCHAR (60)").IsRequired();
                entity.Property(p => p.Genero).HasColumnType("VARCHAR (60)").IsRequired();
            });

            modelBuilder.Entity<DataModels.Leitor>(entity=>
            {
                entity.ToTable("Leitores");
                entity.HasKey(p => p.IdLeitor);
                entity.Property(p => p.Nome).HasColumnType("VARCHAR(60)").IsRequired();
                entity.Property(p => p.Endereco).HasColumnType("VARCHAR(60)");
                entity.Property(p => p.Cpf).HasColumnType("VARCHAR(20)").IsRequired();
                entity.Property(p => p.Telefone).HasColumnType("VARCHAR(20)").IsRequired();
            });

            modelBuilder.Entity<Emprestimo>(entity =>
            {
                entity.ToTable("Emprestimos");
                entity.HasKey(p => p.IdEmprestimo);
                entity.Property(p => p.DataInicio).HasDefaultValueSql("GETDATE()").ValueGeneratedOnAdd();
                entity.Property(p => p.DataTermino).HasDefaultValueSql("GETDATE()").ValueGeneratedOnAdd();
                entity.Property(p => p.Status).HasColumnType("VARCHAR (20)");
    
                entity.HasMany(p => p.Itens)
                     .WithOne(p => p.Emprestimo)
                     .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<EmprestimoLivros>(entity =>
            {
                entity.ToTable("EmprestimosLivros");
                entity.HasKey(p => p.IdEmprestimoLivros); 
                entity.Property(p => p.Quantidade).HasDefaultValue(1).IsRequired();
            });


        }

        private SqlConnection cn;
        private void conexao()
        {
            cn = new SqlConnection("Data Source=localhost; "
           + "initial Catalog=Biblioteca_de_Livro_Emprestimo_db;User ID=usuario; "
           + "password=andrade2021;language=Portuguese;Trusted_Connection=True;"
           + "TrustServerCertificate=True;");
        }
        public SqlConnection abrirConexao()
        {
            try
            {
                conexao();
                cn.Open();

                return cn;
            }
            catch (Exception ex)
            {
               
                return null;
            }
        }

        public void fecharConexao()
        {
            try
            {
                cn.Close();
            }
            catch (Exception ex)
            {
                return;
            }
        }
        public DataTable executarConsultaGenerica(string sql)
        {
            try
            {
                abrirConexao();

                SqlCommand command = new SqlCommand(sql, cn);
                command.ExecuteNonQuery();

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                fecharConexao();
            }
        }
    }
}
