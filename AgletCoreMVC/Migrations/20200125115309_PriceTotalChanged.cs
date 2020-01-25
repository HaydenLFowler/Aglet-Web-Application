using Microsoft.EntityFrameworkCore.Migrations;

namespace AgletCoreMVC.Migrations
{
    public partial class PriceTotalChanged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Price",
                table: "Item",
                newName: "Total");

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Lace",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "Lace");

            migrationBuilder.RenameColumn(
                name: "Total",
                table: "Item",
                newName: "Price");
        }
    }
}
