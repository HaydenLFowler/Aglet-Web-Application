using Microsoft.EntityFrameworkCore.Migrations;

namespace AgletCoreMVC.Migrations
{
    public partial class ExtendPrintLength : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Print",
                table: "Lace",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 15,
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Print",
                table: "Lace",
                maxLength: 15,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldNullable: true);
        }
    }
}
