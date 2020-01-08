using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AgletCoreMVC.Data.Migrations
{
    public partial class CorrectPaymentCard : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_User_PaymentCard_PaymentCardID1",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_User_PaymentCardID1",
                table: "User");

            migrationBuilder.DropColumn(
                name: "PaymentCardID1",
                table: "User");

            migrationBuilder.AlterColumn<string>(
                name: "CardNumber",
                table: "PaymentCard",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(long),
                oldMaxLength: 16);

            migrationBuilder.AlterColumn<int>(
                name: "PaymentCardID",
                table: "PaymentCard",
                nullable: false,
                oldClrType: typeof(string))
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.CreateIndex(
                name: "IX_User_PaymentCardID",
                table: "User",
                column: "PaymentCardID");

            migrationBuilder.AddForeignKey(
                name: "FK_User_PaymentCard_PaymentCardID",
                table: "User",
                column: "PaymentCardID",
                principalTable: "PaymentCard",
                principalColumn: "PaymentCardID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_User_PaymentCard_PaymentCardID",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_User_PaymentCardID",
                table: "User");

            migrationBuilder.AddColumn<string>(
                name: "PaymentCardID1",
                table: "User",
                nullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "CardNumber",
                table: "PaymentCard",
                maxLength: 16,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "PaymentCardID",
                table: "PaymentCard",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.CreateIndex(
                name: "IX_User_PaymentCardID1",
                table: "User",
                column: "PaymentCardID1");

            migrationBuilder.AddForeignKey(
                name: "FK_User_PaymentCard_PaymentCardID1",
                table: "User",
                column: "PaymentCardID1",
                principalTable: "PaymentCard",
                principalColumn: "PaymentCardID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
