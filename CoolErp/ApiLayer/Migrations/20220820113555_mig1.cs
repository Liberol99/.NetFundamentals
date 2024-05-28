using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiLayer.Migrations
{
    public partial class mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Accountings",
                columns: table => new
                {
                    AccountingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HesapAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Borc = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Alacak = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Bakiye = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accountings", x => x.AccountingId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Accountings");
        }
    }
}
