using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignment2.Data.Migrations
{
    public partial class NewColums : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Budget",
                table: "Teams");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Budget",
                table: "Teams",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
