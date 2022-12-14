// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Projeto_Biblioteca_Emprestimo.DataModels;

#nullable disable

namespace ProjetoBibliotecaEmprestimo.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20221215064621_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Projeto_Biblioteca_Emprestimo.DataModels.Emprestimo", b =>
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

                    b.Property<int>("IdLivro")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("VARCHAR (20)");

                    b.HasKey("IdEmprestimo");

                    b.ToTable("Emprestimos", (string)null);
                });

            modelBuilder.Entity("Projeto_Biblioteca_Emprestimo.DataModels.Leitor", b =>
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

            modelBuilder.Entity("Projeto_Biblioteca_Emprestimo.DataModels.Livro", b =>
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
#pragma warning restore 612, 618
        }
    }
}
