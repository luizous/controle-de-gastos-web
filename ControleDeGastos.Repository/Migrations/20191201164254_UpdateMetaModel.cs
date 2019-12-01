using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ControleDeGastos.Repository.Migrations
{
    public partial class UpdateMetaModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Conquistada",
                table: "Meta",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "DataFinal",
                table: "Meta",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Conquistada",
                table: "Meta");

            migrationBuilder.DropColumn(
                name: "DataFinal",
                table: "Meta");
        }
    }
}
