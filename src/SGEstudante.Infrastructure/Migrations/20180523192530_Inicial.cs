using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace SGEstudante.Infrastructure.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Curso",
                columns: table => new
                {
                    CursoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Codigo = table.Column<string>(nullable: true),
                    Descricao = table.Column<string>(nullable: true),
                    Materia = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Curso", x => x.CursoId);
                });

            migrationBuilder.CreateTable(
                name: "Estudante",
                columns: table => new
                {
                    EstudanteId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CPF = table.Column<string>(type: "varchar(11)", nullable: false),
                    Inscricao = table.Column<int>(type: "varchar(8)", nullable: false),
                    Nome = table.Column<string>(type: "varchar(200)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estudante", x => x.EstudanteId);
                });

            migrationBuilder.CreateTable(
                name: "Contato",
                columns: table => new
                {
                    ContatoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Email = table.Column<string>(type: "varchar(100)", nullable: false),
                    EstudanteId = table.Column<int>(nullable: false),
                    Nome = table.Column<string>(type: "varchar(200)", nullable: false),
                    Telefone = table.Column<string>(type: "varchar(15)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contato", x => x.ContatoId);
                    table.ForeignKey(
                        name: "FK_Contato_Estudante_EstudanteId",
                        column: x => x.EstudanteId,
                        principalTable: "Estudante",
                        principalColumn: "EstudanteId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CursoEstudante",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CursoId = table.Column<int>(nullable: false),
                    EstudanteId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CursoEstudante", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CursoEstudante_Curso_CursoId",
                        column: x => x.CursoId,
                        principalTable: "Curso",
                        principalColumn: "CursoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CursoEstudante_Estudante_EstudanteId",
                        column: x => x.EstudanteId,
                        principalTable: "Estudante",
                        principalColumn: "EstudanteId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Endereco",
                columns: table => new
                {
                    EnderecoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Bairro = table.Column<string>(nullable: true),
                    CPE = table.Column<string>(nullable: true),
                    EstudanteId = table.Column<int>(nullable: false),
                    Lougradouro = table.Column<string>(nullable: true),
                    Referencia = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Endereco", x => x.EnderecoId);
                    table.ForeignKey(
                        name: "FK_Endereco_Estudante_EstudanteId",
                        column: x => x.EstudanteId,
                        principalTable: "Estudante",
                        principalColumn: "EstudanteId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Contato_EstudanteId",
                table: "Contato",
                column: "EstudanteId");

            migrationBuilder.CreateIndex(
                name: "IX_CursoEstudante_CursoId",
                table: "CursoEstudante",
                column: "CursoId");

            migrationBuilder.CreateIndex(
                name: "IX_CursoEstudante_EstudanteId",
                table: "CursoEstudante",
                column: "EstudanteId");

            migrationBuilder.CreateIndex(
                name: "IX_Endereco_EstudanteId",
                table: "Endereco",
                column: "EstudanteId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contato");

            migrationBuilder.DropTable(
                name: "CursoEstudante");

            migrationBuilder.DropTable(
                name: "Endereco");

            migrationBuilder.DropTable(
                name: "Curso");

            migrationBuilder.DropTable(
                name: "Estudante");
        }
    }
}
