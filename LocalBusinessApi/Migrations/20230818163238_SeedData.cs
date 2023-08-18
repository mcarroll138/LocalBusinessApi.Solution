using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LocalBusinessApi.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Businesses",
                columns: new[] { "BusinessId", "BusinessType", "Description", "Name", "Reviews" },
                values: new object[] { 1, "Convieniece Store", "Beer, wine, and snacks", "The Corner Store", "Basic seletion of snacks, good selection of beer, however the wine is not organic" });

            migrationBuilder.InsertData(
                table: "Businesses",
                columns: new[] { "BusinessId", "BusinessType", "Description", "Name", "Reviews" },
                values: new object[] { 2, "Resturant", "Casual Dining with full menu and bar", "Taste of PDX", "Good place for group dinners and happy hour" });

            migrationBuilder.InsertData(
                table: "Businesses",
                columns: new[] { "BusinessId", "BusinessType", "Description", "Name", "Reviews" },
                values: new object[] { 3, "Hardware Store", "Locally owned hardware store", "Shelly's Hardware", "Small hardware store with decent selection of DIY home repair" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 3);
        }
    }
}
