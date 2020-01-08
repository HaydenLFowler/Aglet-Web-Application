using Microsoft.EntityFrameworkCore.Migrations;

namespace AgletCoreMVC.Data.Migrations
{
    public partial class MakeFKsNullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_User_Contact_ContactID",
                table: "User");

            migrationBuilder.DropForeignKey(
                name: "FK_User_PaymentCard_PaymentCardID",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_User_ContactID",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_User_PaymentCardID",
                table: "User");

            migrationBuilder.AlterColumn<int>(
                name: "PaymentCardID",
                table: "User",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ContactID",
                table: "User",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "AdressID",
                table: "User",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<string>(
                name: "PaymentCardID1",
                table: "User",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_User_ContactID",
                table: "User",
                column: "ContactID",
                unique: true,
                filter: "[ContactID] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_User_PaymentCardID1",
                table: "User",
                column: "PaymentCardID1");

            migrationBuilder.AddForeignKey(
                name: "FK_User_Contact_ContactID",
                table: "User",
                column: "ContactID",
                principalTable: "Contact",
                principalColumn: "ContactID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_User_PaymentCard_PaymentCardID1",
                table: "User",
                column: "PaymentCardID1",
                principalTable: "PaymentCard",
                principalColumn: "PaymentCardID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_User_Contact_ContactID",
                table: "User");

            migrationBuilder.DropForeignKey(
                name: "FK_User_PaymentCard_PaymentCardID1",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_User_ContactID",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_User_PaymentCardID1",
                table: "User");

            migrationBuilder.DropColumn(
                name: "PaymentCardID1",
                table: "User");

            migrationBuilder.AlterColumn<string>(
                name: "PaymentCardID",
                table: "User",
                nullable: true,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ContactID",
                table: "User",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AdressID",
                table: "User",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_User_ContactID",
                table: "User",
                column: "ContactID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_User_PaymentCardID",
                table: "User",
                column: "PaymentCardID");

            migrationBuilder.AddForeignKey(
                name: "FK_User_Contact_ContactID",
                table: "User",
                column: "ContactID",
                principalTable: "Contact",
                principalColumn: "ContactID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_User_PaymentCard_PaymentCardID",
                table: "User",
                column: "PaymentCardID",
                principalTable: "PaymentCard",
                principalColumn: "PaymentCardID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
