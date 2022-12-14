// <auto-generated />
using System;
using Biblioteca_Livros_Emprestimo.DataContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BibliotecaLivrosEmprestimo.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20221211194756_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Biblioteca_Livros_Emprestimo.DataModels.Emprestimo", b =>
                {
                    b.Property<int>("IdEmprestimo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdEmprestimo"));

                    b.Property<DateTime>("DataInicio")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<DateTime>("DataTermino")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<int>("IdLeitor")
                        .HasColumnType("int");

                    b.Property<int>("LeitorIdLeitor")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("VARCHAR (20)");

                    b.HasKey("IdEmprestimo");

                    b.HasIndex("LeitorIdLeitor");

                    b.ToTable("Emprestimos", (string)null);
                });

            modelBuilder.Entity("Biblioteca_Livros_Emprestimo.DataModels.EmprestimoLivros", b =>
                {
                    b.Property<int>("IdEmprestimoLivros")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdEmprestimoLivros"));

                    b.Property<int>("EmprestimoIdEmprestimo")
                        .HasColumnType("int");

                    b.Property<int>("IdEmprestimo")
                        .HasColumnType("int");

                    b.Property<int>("IdLivro")
                        .HasColumnType("int");

                    b.Property<int>("LivroIdLivro")
                        .HasColumnType("int");

                    b.Property<int>("Quantidade")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(1);

                    b.HasKey("IdEmprestimoLivros");

                    b.HasIndex("EmprestimoIdEmprestimo");

                    b.HasIndex("LivroIdLivro");

                    b.ToTable("EmprestimosLivros", (string)null);
                });

            modelBuilder.Entity("Biblioteca_Livros_Emprestimo.DataModels.Leitor", b =>
                {
                    b.Property<int>("IdLeitor")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdLeitor"));

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasColumnType("VARCHAR(20)");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasColumnType("VARCHAR(60)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("VARCHAR(60)");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("VARCHAR(20)");

                    b.HasKey("IdLeitor");

                    b.ToTable("Leitores", (string)null);
                });

            modelBuilder.Entity("Biblioteca_Livros_Emprestimo.DataModels.Livro", b =>
                {
                    b.Property<int>("IdLivro")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdLivro"));

                    b.Property<string>("Autor")
                        .IsRequired()
                        .HasColumnType("VARCHAR (60)");

                    b.Property<string>("Edicao")
                        .IsRequired()
                        .HasColumnType("VARCHAR (60)");

                    b.Property<string>("Editora")
                        .IsRequired()
                        .HasColumnType("VARCHAR (60)");

                    b.Property<string>("Genero")
                        .IsRequired()
                        .HasColumnType("VARCHAR (60)");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("VARCHAR (60)");

                    b.HasKey("IdLivro");

                    b.ToTable("Livros", (string)null);
                });

            modelBuilder.Entity("Biblioteca_Livros_Emprestimo.DataModels.Emprestimo", b =>
                {
                    b.HasOne("Biblioteca_Livros_Emprestimo.DataModels.Leitor", "Leitor")
                        .WithMany()
                        .HasForeignKey("LeitorIdLeitor")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Leitor");
                });

            modelBuilder.Entity("Biblioteca_Livros_Emprestimo.DataModels.EmprestimoLivros", b =>
                {
                    b.HasOne("Biblioteca_Livros_Emprestimo.DataModels.Emprestimo", "Emprestimo")
                        .WithMany("Itens")
                        .HasForeignKey("EmprestimoIdEmprestimo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Biblioteca_Livros_Emprestimo.DataModels.Livro", "Livro")
                        .WithMany()
                        .HasForeignKey("LivroIdLivro")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Emprestimo");

                    b.Navigation("Livro");
                });

            modelBuilder.Entity("Biblioteca_Livros_Emprestimo.DataModels.Emprestimo", b =>
                {
                    b.Navigation("Itens");
                });
#pragma warning restore 612, 618
        }
    }
}
