using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Projeto.Infrastructure.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TB_CLIENTE",
                columns: table => new
                {
                    ClienteId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "varchar(200)", nullable: false),
                    CPF = table.Column<string>(type: "varchar(11)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_CLIENTE", x => x.ClienteId);
                });

            migrationBuilder.CreateTable(
                name: "TB_PROFISSAO",
                columns: table => new
                {
                    ProfissaoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true),
                    Descricao = table.Column<string>(nullable: true),
                    CBO = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_PROFISSAO", x => x.ProfissaoId);
                });

            migrationBuilder.CreateTable(
                name: "TB_CONTATO",
                columns: table => new
                {
                    ContatoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "varchar(200)", nullable: false),
                    Telefone = table.Column<string>(type: "varchar(15)", nullable: true),
                    Email = table.Column<string>(type: "varchar(100)", nullable: false),
                    ClienteId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_CONTATO", x => x.ContatoId);
                    table.ForeignKey(
                        name: "FK_TB_CONTATO_TB_CLIENTE_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "TB_CLIENTE",
                        principalColumn: "ClienteId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TB_ENDERECO",
                columns: table => new
                {
                    EnderecoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Logradouro = table.Column<string>(nullable: true),
                    Bairro = table.Column<string>(nullable: true),
                    CEP = table.Column<string>(nullable: true),
                    Referencia = table.Column<string>(nullable: true),
                    ClienteId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_ENDERECO", x => x.EnderecoId);
                    table.ForeignKey(
                        name: "FK_TB_ENDERECO_TB_CLIENTE_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "TB_CLIENTE",
                        principalColumn: "ClienteId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TB_PROFISSAO_CLIENTE",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ClienteId = table.Column<int>(nullable: false),
                    ProfissaoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_PROFISSAO_CLIENTE", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TB_PROFISSAO_CLIENTE_TB_CLIENTE_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "TB_CLIENTE",
                        principalColumn: "ClienteId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TB_PROFISSAO_CLIENTE_TB_PROFISSAO_ProfissaoId",
                        column: x => x.ProfissaoId,
                        principalTable: "TB_PROFISSAO",
                        principalColumn: "ProfissaoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TB_CONTATO_ClienteId",
                table: "TB_CONTATO",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_TB_ENDERECO_ClienteId",
                table: "TB_ENDERECO",
                column: "ClienteId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TB_PROFISSAO_CLIENTE_ClienteId",
                table: "TB_PROFISSAO_CLIENTE",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_TB_PROFISSAO_CLIENTE_ProfissaoId",
                table: "TB_PROFISSAO_CLIENTE",
                column: "ProfissaoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TB_CONTATO");

            migrationBuilder.DropTable(
                name: "TB_ENDERECO");

            migrationBuilder.DropTable(
                name: "TB_PROFISSAO_CLIENTE");

            migrationBuilder.DropTable(
                name: "TB_CLIENTE");

            migrationBuilder.DropTable(
                name: "TB_PROFISSAO");
        }
    }
}
