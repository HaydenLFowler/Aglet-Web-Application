using Microsoft.EntityFrameworkCore.Migrations;

namespace AgletCoreMVC.Data.Migrations
{
    public partial class AddCards : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PaymentCard",
                columns: table => new
                {
                    PaymentCardID = table.Column<string>(nullable: false),
                    CardName = table.Column<string>(maxLength: 30, nullable: false),
                    CardNumber = table.Column<string>(maxLength: 30, nullable: false),
                    SecurityCode = table.Column<int>(nullable: false),
                    ExpiryMonth = table.Column<int>(nullable: false),
                    ExpiryYear = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentCard", x => x.PaymentCardID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PaymentCard");
        }
    }
}
