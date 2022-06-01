using Microsoft.EntityFrameworkCore.Migrations;

namespace Resturaunt_web.Data.Migrations
{
    public partial class registeredCustomers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Registered_Customers",
                columns: table => new
                {
                    CustomerID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerName = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    CustomerEmail = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    CustomerPhone = table.Column<int>(type: "int", nullable: false),
                    CustomerPassword = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Registered_Customers", x => x.CustomerID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Registered_Customers");
        }
    }
}
