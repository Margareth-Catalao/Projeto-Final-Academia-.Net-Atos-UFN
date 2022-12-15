using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Biblioteca_Emprestimo.DataModels
{
     public class Contexto : DbContext
    {
        public Contexto()
        {

        }
        public DbSet<Livro> Livros { get; set; }
        public DbSet<Leitor> Leitores { get; set; }
        public DbSet<Emprestimo> Emprestimos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer("Data Source=localhost; "
            + "initial Catalog=Biblioteca_db;User ID=usuarioBiblioteca; "
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

            modelBuilder.Entity<Leitor>(entity =>
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
                entity.Property(p => p.IdLeitor).HasColumnType("int").IsRequired();
                entity.Property(p => p.IdLivro).HasColumnType("int").IsRequired();
                entity.Property(p => p.DataInicio).HasDefaultValueSql("GETDATE()").ValueGeneratedOnAdd();
                entity.Property(p => p.DataTermino).HasDefaultValueSql("GETDATE()").ValueGeneratedOnAdd();
                entity.Property(p => p.Status).HasColumnType("VARCHAR (20)");

            });

        }

        private SqlConnection cn;
        private void conexao()
        {
            cn = new SqlConnection("Data Source=localhost; "
           + "initial Catalog=Biblioteca_db;User ID=usuarioBiblioteca; "
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
