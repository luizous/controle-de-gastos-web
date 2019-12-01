using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ControleDeGastos.Repository.Migrations
{
    public partial class AddDataDeposito : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DataDeposito",
                table: "Poupanca",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataDeposito",
                table: "Poupanca");
        }
    }
}
