using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace SGEstudante.Infrastructure.Migrations
{
    public partial class AtualizaClasseEstudanteContato : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Incricao",
                table: "Estudante");
            migrationBuilder.AddColumn<int>(
                name: "Inscricao",
                table: "Estudante",
                type: "varchar(8)",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Inscricao",
                table: "Estudante");

            migrationBuilder.AddColumn<int>(
                name: "Incricao",
                table: "Estudante",
                nullable: false,
                defaultValue: 0);
        }
    }
}
