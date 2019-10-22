using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Fiap.Infra.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Receita",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IdUsuarioAlteracao = table.Column<int>(nullable: true),
                    IdUsuarioCriacao = table.Column<int>(nullable: true),
                    DataAlteracao = table.Column<DateTime>(type: "datetime", nullable: true),
                    DataExclusao = table.Column<DateTime>(type: "datetime", nullable: true),
                    DataCriacao = table.Column<DateTime>(type: "datetime", nullable: false),
                    Nome = table.Column<string>(type: "varchar", maxLength: 100, nullable: true),
                    Ingredientes = table.Column<string>(type: "varchar(max)", nullable: true),
                    Preparo = table.Column<string>(type: "varchar(max)", nullable: true),
                    TempoPreparo = table.Column<int>(type: "int", nullable: false),
                    Tags = table.Column<string>(type: "varchar(max)", nullable: true),
                    QuantidadePessoas = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Receita", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Receita");
        }
    }
}
