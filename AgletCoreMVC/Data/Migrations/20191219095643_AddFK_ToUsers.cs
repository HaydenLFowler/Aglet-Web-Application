using Microsoft.EntityFrameworkCore.Migrations;

namespace AgletCoreMVC.Data.Migrations
{
    public partial class AddFK_ToUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contact_User_UserID",
                table: "Contact");

            migrationBuilder.DropIndex(
                name: "IX_Contact_UserID",
                table: "Contact");

            migrationBuilder.DropColumn(
                name: "UserID",
                table: "Contact");

            migrationBuilder.AddColumn<int>(
                name: "AdressID",
                table: "User",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ContactID",
                table: "User",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_User_ContactID",
                table: "User",
                column: "ContactID",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_User_Contact_ContactID",
                table: "User",
                column: "ContactID",
                principalTable: "Contact",
                principalColumn: "ContactID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_User_Contact_ContactID",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_User_ContactID",
                table: "User");

            migrationBuilder.DropColumn(
                name: "AdressID",
                table: "User");

            migrationBuilder.DropColumn(
                name: "ContactID",
                table: "User");

            migrationBuilder.AddColumn<int>(
                name: "UserID",
                table: "Contact",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Contact_UserID",
                table: "Contact",
                column: "UserID",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Contact_User_UserID",
                table: "Contact",
                column: "UserID",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
