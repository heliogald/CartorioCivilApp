using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CartorioCivilApp.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Nascimentos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DataRegistro = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DataNascimento = table.Column<DateTime>(type: "TEXT", nullable: false),
                    NomeRegistrado = table.Column<string>(type: "TEXT", nullable: false),
                    NomePai = table.Column<string>(type: "TEXT", nullable: false),
                    NomeMae = table.Column<string>(type: "TEXT", nullable: false),
                    DataNascimentoPai = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DataNascimentoMae = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CpfPai = table.Column<string>(type: "TEXT", nullable: false),
                    CpfMae = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nascimentos", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Nascimentos");
        }
    }
}
