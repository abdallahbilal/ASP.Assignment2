using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignment2.Data.Migrations
{
    public partial class dropPurchase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PurchasePrice",
                table: "Players");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PurchasePrice",
                table: "Players",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
