using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Biblioteca_Emprestimo.Models
{
    public class Contexto : DbContext
    {
        public DbSet<Livro> Livro { get; set; }
        public DbSet<Pessoa> Pessoa { get; set; }
        public DbSet<Emprestimo> Emprestimo { get; set; }
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Livro>(p =>
            {
                p.ToTable("Livro");
                p.HasKey(p => p.IdLivro);
                p.Property(p => p.Titulo).HasColumnType("VARCHAR(40)").IsRequired();
                p.Property(p => p.Autor).HasColumnType("VARCHAR(40)").IsRequired();
                p.Property(p => p.Editora).HasColumnType("VARCHAR(40)").IsRequired();
                p.Property(p => p.Edicao).HasColumnType("VARCHAR(40)").IsRequired();
            });

            modelBuilder.Entity<Pessoa>(p =>

            {
                p.ToTable("Pessoa");
                p.HasKey(p => p.IdPessoa);
                p.Property(p => p.Nome).HasColumnType("VARCHAR(40)").IsRequired();
                p.Property(p => p.Endereco).HasColumnType("VARCHAR(40)").IsRequired();
                p.Property(p => p.Cpf).HasColumnType("VARCHAR(40)").IsRequired();
                p.Property(p => p.Telefone).HasColumnType("VARCHAR(40)").IsRequired();
            });


            modelBuilder.Entity<Emprestimo>(p =>

            {
                p.ToTable("Empréstimo");
                p.HasKey(p => p.IdEmprestimo);
                p.HasOne(d => d.idLivro).WithMany(p => p.Emprestimo)
                    .HasForeignKey(d => d.FkPessoa)
                    .HasConstraintName("FK__Emails__fk_pesso__267ABA7A");
             
                p.Property(p => p.DataEmprestimo).HasDefaultValueSql("Date").ValueGeneratedOnAdd();
                p.Property(p => p.DataDevolucao).HasDefaultValueSql("Date").ValueGeneratedOnAdd();

            });

           
        }

    }
}

   
