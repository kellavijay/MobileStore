using Microsoft.EntityFrameworkCore.Migrations;

namespace MobileStore.Migrations
{
    public partial class seedMobilesTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Mobiles",
                columns: new[] { "Id", "FullDescription", "ImageThumbnailUrl", "ImageUrl", "IsMobileOfTheDay", "Name", "Price", "TinyDescription" },
                values: new object[] { 102, null, null, null, false, "RedmiGO", 4500m, "Smart Mobile Under Budget" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Mobiles",
                keyColumn: "Id",
                keyValue: 102);
        }
    }
}
