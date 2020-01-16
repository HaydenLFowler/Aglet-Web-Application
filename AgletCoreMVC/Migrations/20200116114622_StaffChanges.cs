using Microsoft.EntityFrameworkCore.Migrations;

namespace AgletCoreMVC.Migrations
{
    public partial class StaffChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Salary",
                table: "Staff",
                nullable: false,
                oldClrType: typeof(decimal));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Salary",
                table: "Staff",
                nullable: false,
                oldClrType: typeof(string));
        }
    }
}
