using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebMVC.Data.Migrations
{
    public partial class Exclusa_DataDeNascimento_TabelaPessoa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataDeNascimento",
                table: "Pessoas");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DataDeNascimento",
                table: "Pessoas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
