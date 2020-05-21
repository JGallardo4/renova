using Microsoft.EntityFrameworkCore.Metadata;
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
                    ProjectId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    DisplayName = table.Column<string>(maxLength: 100, nullable: false),
                    ThumbnailImage = table.Column<string>(maxLength: 100, nullable: false),
                    Images = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.ProjectId);
                });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "ProjectId", "DisplayName", "Images", "Name", "ThumbnailImage" },
                values: new object[] { 1, "Before and After Gallery", "", "before-after", "" });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "ProjectId", "DisplayName", "Images", "Name", "ThumbnailImage" },
                values: new object[] { 2, "Duggan Project", "/images/gallery/duggan/after/duggan_after_kitchen2.jpg;/images/gallery/duggan/after/duggan_after_kitchen5.jpg;/images/gallery/duggan/after/duggan_after_livingroom3.jpg;/images/gallery/duggan/after/duggan_after_bathroom2.jpg;/images/gallery/duggan/after/duggan_after_livingroom.jpg;/images/gallery/duggan/after/duggan_after_wideshot.jpg;/images/gallery/duggan/after/duggan_after_diningarea.jpg;/images/gallery/duggan/after/duggan_after_kitchen1.jpg;/images/gallery/duggan/after/duggan_after_kitchen4.jpg;/images/gallery/duggan/after/duggan_after_kitchen3.jpg;/images/gallery/duggan/after/duggan_after_bathroom.jpg;/images/gallery/duggan/after/duggan_after_decoratedwide.jpg;/images/gallery/duggan/after/duggan_after_livingroom2.jpg;/images/gallery/duggan/after/duggan_after_backentrance.jpg", "duggan", "" });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "ProjectId", "DisplayName", "Images", "Name", "ThumbnailImage" },
                values: new object[] { 3, "Millwoods Project", "/images/gallery/millwoods/after/millwoods_after_bathroom1.jpg;/images/gallery/millwoods/after/millwoods_after_dining1.jpg;/images/gallery/millwoods/after/millwoods_after_bathroom3.jpg;/images/gallery/millwoods/after/millwoods_after_kitchen2.jpg;/images/gallery/millwoods/after/millwoods_after_bathroom2.jpg;/images/gallery/millwoods/after/millwoods_after_kitchen1.jpg", "millwoods", "" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Projects");
        }
    }
}
