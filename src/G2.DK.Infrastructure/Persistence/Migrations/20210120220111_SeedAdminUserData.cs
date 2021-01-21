using Microsoft.EntityFrameworkCore.Migrations;

namespace G2.DK.Infrastructure.Persistence.Migrations
{
    public partial class SeedAdminUserData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Login", "Password" },
                values: new object[] { 1, "admin", "AL2VQb6sLPN7W8pMtKdEwnXoHT3IPvneF2cTJogEdcM41Dy27bxPzaL9B0aKhVtGKQ==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1);
        }
    }
}
