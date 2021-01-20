using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Infrastructure.Migrations
{
    public partial class FistMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "sistema_escolar");

            migrationBuilder.CreateTable(
                name: "ano_letivo",
                schema: "sistema_escolar",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    ano = table.Column<string>(type: "char(4)", nullable: false),
                    data_inicio = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    data_final = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    vigente = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ano_letivo", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "estado",
                schema: "sistema_escolar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nome = table.Column<string>(type: "text", nullable: false),
                    sigla = table.Column<string>(type: "char(2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_estado", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "cidade",
                schema: "sistema_escolar",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nome = table.Column<string>(type: "text", nullable: false),
                    id_estado = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cidade", x => x.id);
                    table.ForeignKey(
                        name: "fk_c_estado",
                        column: x => x.id_estado,
                        principalSchema: "sistema_escolar",
                        principalTable: "estado",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "endereco",
                schema: "sistema_escolar",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    logradouro = table.Column<string>(type: "text", nullable: false),
                    numero = table.Column<int>(type: "integer", nullable: true),
                    complemento = table.Column<string>(type: "text", nullable: true),
                    bairro = table.Column<string>(type: "text", nullable: false),
                    cep = table.Column<string>(type: "char(8)", nullable: false),
                    id_cidade = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_endereco", x => x.id);
                    table.ForeignKey(
                        name: "fk_e_cidade",
                        column: x => x.id_cidade,
                        principalSchema: "sistema_escolar",
                        principalTable: "cidade",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "pessoa",
                schema: "sistema_escolar",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    nome = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    data_nascimento = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    genero = table.Column<string>(type: "text", nullable: false),
                    cpf = table.Column<string>(type: "char(11)", nullable: true),
                    estado_civil = table.Column<string>(type: "text", nullable: false),
                    email = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    telefone = table.Column<string>(type: "character varying(15)", maxLength: 15, nullable: true),
                    celular = table.Column<string>(type: "character varying(15)", maxLength: 15, nullable: true),
                    ativo = table.Column<bool>(type: "boolean", nullable: false),
                    foto = table.Column<string>(type: "text", nullable: true),
                    data_cadastro = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    data_alteracao = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    data_exclusao = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    id_endereco = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pessoa", x => x.id);
                    table.ForeignKey(
                        name: "FK_pessoa_endereco_id_endereco",
                        column: x => x.id_endereco,
                        principalSchema: "sistema_escolar",
                        principalTable: "endereco",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_cidade_id_estado",
                schema: "sistema_escolar",
                table: "cidade",
                column: "id_estado");

            migrationBuilder.CreateIndex(
                name: "IX_endereco_id_cidade",
                schema: "sistema_escolar",
                table: "endereco",
                column: "id_cidade");

            migrationBuilder.CreateIndex(
                name: "IX_pessoa_id_endereco",
                schema: "sistema_escolar",
                table: "pessoa",
                column: "id_endereco");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ano_letivo",
                schema: "sistema_escolar");

            migrationBuilder.DropTable(
                name: "pessoa",
                schema: "sistema_escolar");

            migrationBuilder.DropTable(
                name: "endereco",
                schema: "sistema_escolar");

            migrationBuilder.DropTable(
                name: "cidade",
                schema: "sistema_escolar");

            migrationBuilder.DropTable(
                name: "estado",
                schema: "sistema_escolar");
        }
    }
}
