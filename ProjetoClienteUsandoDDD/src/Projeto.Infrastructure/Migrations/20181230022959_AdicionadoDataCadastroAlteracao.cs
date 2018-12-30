using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Projeto.Infrastructure.Migrations
{
    public partial class AdicionadoDataCadastroAlteracao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DataAlteracao",
                table: "TB_PROFISSAO",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DataCadastro",
                table: "TB_PROFISSAO",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DataAlteracao",
                table: "TB_ENDERECO",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DataCadastro",
                table: "TB_ENDERECO",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DataAlteracao",
                table: "TB_CONTATO",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DataCadastro",
                table: "TB_CONTATO",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DataAlteracao",
                table: "TB_CLIENTE",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DataCadastro",
                table: "TB_CLIENTE",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataAlteracao",
                table: "TB_PROFISSAO");

            migrationBuilder.DropColumn(
                name: "DataCadastro",
                table: "TB_PROFISSAO");

            migrationBuilder.DropColumn(
                name: "DataAlteracao",
                table: "TB_ENDERECO");

            migrationBuilder.DropColumn(
                name: "DataCadastro",
                table: "TB_ENDERECO");

            migrationBuilder.DropColumn(
                name: "DataAlteracao",
                table: "TB_CONTATO");

            migrationBuilder.DropColumn(
                name: "DataCadastro",
                table: "TB_CONTATO");

            migrationBuilder.DropColumn(
                name: "DataAlteracao",
                table: "TB_CLIENTE");

            migrationBuilder.DropColumn(
                name: "DataCadastro",
                table: "TB_CLIENTE");
        }
    }
}
