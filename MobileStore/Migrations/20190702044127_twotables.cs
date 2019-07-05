using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MobileStore.Migrations
{
    public partial class twotables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    uId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    uName = table.Column<string>(nullable: true),
                    userType = table.Column<string>(nullable: true),
                    uProfileImageUrl = table.Column<string>(nullable: true),
                    MobileNumber = table.Column<double>(nullable: false),
                    uEmail = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.uId);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "uId", "MobileNumber", "uEmail", "uName", "uProfileImageUrl", "userType" },
                values: new object[] { 1, 9030718891.0, "kellavijay@gmail.com", "Vijay Kumar", null, "Admin" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "uId", "MobileNumber", "uEmail", "uName", "uProfileImageUrl", "userType" },
                values: new object[] { 2, 9030715591.0, "ajay@gmail.com", "Ajay Kumar", null, "Customer" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "uId", "MobileNumber", "uEmail", "uName", "uProfileImageUrl", "userType" },
                values: new object[] { 3, 9030717791.0, "prasad@gmail.com", "Prasad", null, "Customer" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
