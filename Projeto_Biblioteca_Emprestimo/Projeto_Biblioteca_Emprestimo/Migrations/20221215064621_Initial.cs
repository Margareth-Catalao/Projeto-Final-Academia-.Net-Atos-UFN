using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoBibliotecaEmprestimo.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Emprestimos",
                columns: table => new
                {
                    IdEmprestimo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdLeitor = table.Column<int>(type: "int", nullable: false),
                    IdLivro = table.Column<int>(type: "int", nullable: false),
                    DataInicio = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    DataTermino = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    Status = table.Column<string>(type: "VARCHAR (20)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Emprestimos", x => x.IdEmprestimo);
                });

            migrationBuilder.CreateTable(
                name: "Leitores",
                columns: table => new
                {
                    IdLeitor = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "VARCHAR(60)", nullable: false),
                    Endereco = table.Column<string>(type: "VARCHAR(60)", nullable: false),
                    Cpf = table.Column<string>(type: "VARCHAR(20)", nullable: false),
                    Telefone = table.Column<string>(type: "VARCHAR(20)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Leitores", x => x.IdLeitor);
                });

            migrationBuilder.CreateTable(
                name: "Livros",
                columns: table => new
                {
                    IdLivro = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titulo = table.Column<string>(type: "VARCHAR (60)", nullable: false),
                    Autor = table.Column<string>(type: "VARCHAR (60)", nullable: false),
                    Editora = table.Column<string>(type: "VARCHAR (60)", nullable: false),
                    Edicao = table.Column<string>(type: "VARCHAR (60)", nullable: false),
                    Genero = table.Column<string>(type: "VARCHAR (60)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Livros", x => x.IdLivro);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Emprestimos");

            migrationBuilder.DropTable(
                name: "Leitores");

            migrationBuilder.DropTable(
                name: "Livros");
        }
    }
}
