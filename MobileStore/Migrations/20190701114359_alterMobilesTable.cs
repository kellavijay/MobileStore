using Microsoft.EntityFrameworkCore.Migrations;

namespace MobileStore.Migrations
{
    public partial class alterMobilesTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Mobiles",
                columns: new[] { "Id", "FullDescription", "ImageThumbnailUrl", "ImageUrl", "IsMobileOfTheDay", "Name", "Price", "TinyDescription" },
                values: new object[] { 103, null, null, null, false, "RedmiNote5Pro", 11500m, "Smart Mobile Under Best Suited for taking pictures" });

            migrationBuilder.InsertData(
                table: "Mobiles",
                columns: new[] { "Id", "FullDescription", "ImageThumbnailUrl", "ImageUrl", "IsMobileOfTheDay", "Name", "Price", "TinyDescription" },
                values: new object[] { 104, null, null, null, false, "RedmiNote7Pro", 15500m, "Smart Mobile With 48 Mega Pixel camera" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Mobiles",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Mobiles",
                keyColumn: "Id",
                keyValue: 104);
        }
    }
}
