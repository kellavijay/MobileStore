using Microsoft.EntityFrameworkCore.Migrations;

namespace MobileStore.Migrations
{
    public partial class thumbmodMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ImageThumbnailUrl",
                table: "Mobiles",
                newName: "ImageThumbUrl");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ImageThumbUrl",
                table: "Mobiles",
                newName: "ImageThumbnailUrl");
        }
    }
}
