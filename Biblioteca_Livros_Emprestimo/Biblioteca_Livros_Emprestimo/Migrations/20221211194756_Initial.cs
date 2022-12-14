using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BibliotecaLivrosEmprestimo.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.CreateTable(
                name: "Emprestimos",
                columns: table => new
                {
                    IdEmprestimo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdLeitor = table.Column<int>(type: "int", nullable: false),
                    LeitorIdLeitor = table.Column<int>(type: "int", nullable: false),
                    DataInicio = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    DataTermino = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    Status = table.Column<string>(type: "VARCHAR (20)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Emprestimos", x => x.IdEmprestimo);
                    table.ForeignKey(
                        name: "FK_Emprestimos_Leitores_LeitorIdLeitor",
                        column: x => x.LeitorIdLeitor,
                        principalTable: "Leitores",
                        principalColumn: "IdLeitor",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmprestimosLivros",
                columns: table => new
                {
                    IdEmprestimoLivros = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdEmprestimo = table.Column<int>(type: "int", nullable: false),
                    EmprestimoIdEmprestimo = table.Column<int>(type: "int", nullable: false),
                    IdLivro = table.Column<int>(type: "int", nullable: false),
                    LivroIdLivro = table.Column<int>(type: "int", nullable: false),
                    Quantidade = table.Column<int>(type: "int", nullable: false, defaultValue: 1)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmprestimosLivros", x => x.IdEmprestimoLivros);
                    table.ForeignKey(
                        name: "FK_EmprestimosLivros_Emprestimos_EmprestimoIdEmprestimo",
                        column: x => x.EmprestimoIdEmprestimo,
                        principalTable: "Emprestimos",
                        principalColumn: "IdEmprestimo",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmprestimosLivros_Livros_LivroIdLivro",
                        column: x => x.LivroIdLivro,
                        principalTable: "Livros",
                        principalColumn: "IdLivro",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Emprestimos_LeitorIdLeitor",
                table: "Emprestimos",
                column: "LeitorIdLeitor");

            migrationBuilder.CreateIndex(
                name: "IX_EmprestimosLivros_EmprestimoIdEmprestimo",
                table: "EmprestimosLivros",
                column: "EmprestimoIdEmprestimo");

            migrationBuilder.CreateIndex(
                name: "IX_EmprestimosLivros_LivroIdLivro",
                table: "EmprestimosLivros",
                column: "LivroIdLivro");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmprestimosLivros");

            migrationBuilder.DropTable(
                name: "Emprestimos");

            migrationBuilder.DropTable(
                name: "Livros");

            migrationBuilder.DropTable(
                name: "Leitores");
        }
    }
}
