using Microsoft.EntityFrameworkCore.Migrations;

namespace Renova.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    ProjectId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    Directory = table.Column<string>(nullable: false),
                    Images = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.ProjectId);
                });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "ProjectId", "Directory", "Images", "Name" },
                values: new object[] { 1, "/images/gallery/Millwoods/after/", "house1_after_backentrance.jpg;house1_after_bathroom.jpg;house1_after_bathroom2.jpg;house1_after_decoratedwide.jpg;house1_after_diningarea.jpg;house1_after_kitchen1.jpg;house1_after_kitchen2.jpg;house1_after_kitchen3.jpg;house1_after_kitchen4.jpg;house1_after_livingroom.jpg;house1_after_livingroom2.jpg;house1_after_livingroom3.jpg;house1_after_wideshot.jpg;kitchen1_after_1.jpg", "Millwoods Project" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Projects");
        }
    }
}
