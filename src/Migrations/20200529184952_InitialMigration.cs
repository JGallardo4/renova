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
                    FullImages = table.Column<string>(nullable: true),
                    ThumbnailImages = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.ProjectId);
                });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "ProjectId", "DisplayName", "FullImages", "Name", "ThumbnailImage", "ThumbnailImages" },
                values: new object[] { 1, "Before and After Gallery", "/images/gallery/before-after/full-resolution/0_duggan_before_bathroom.jpg;/images/gallery/before-after/full-resolution/1_duggan_after_bathroom.jpg;/images/gallery/before-after/full-resolution/2_duggan_before_livingroom.jpg;/images/gallery/before-after/full-resolution/3_duggan_after_livingroom.jpg;/images/gallery/before-after/full-resolution/4_duggan_before_kitchen.jpg;/images/gallery/before-after/full-resolution/5_duggan_after_kitchen.jpg", "before-after", "", "/images/gallery/before-after/thumbnails/0_duggan_before_bathroom.jpg;/images/gallery/before-after/thumbnails/1_duggan_after_bathroom.jpg;/images/gallery/before-after/thumbnails/2_duggan_before_livingroom.jpg;/images/gallery/before-after/thumbnails/3_duggan_after_livingroom.jpg;/images/gallery/before-after/thumbnails/4_duggan_before_kitchen.jpg;/images/gallery/before-after/thumbnails/5_duggan_after_kitchen.jpg" });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "ProjectId", "DisplayName", "FullImages", "Name", "ThumbnailImage", "ThumbnailImages" },
                values: new object[] { 2, "Duggan Project", "/images/gallery/duggan/full-resolution/duggan_after_backentrance.jpg;/images/gallery/duggan/full-resolution/duggan_after_bathroom.jpg;/images/gallery/duggan/full-resolution/duggan_after_bathroom2.jpg;/images/gallery/duggan/full-resolution/duggan_after_decoratedwide.jpg;/images/gallery/duggan/full-resolution/duggan_after_diningarea.jpg;/images/gallery/duggan/full-resolution/duggan_after_kitchen1.jpg;/images/gallery/duggan/full-resolution/duggan_after_kitchen2.jpg;/images/gallery/duggan/full-resolution/duggan_after_kitchen3.jpg;/images/gallery/duggan/full-resolution/duggan_after_kitchen4.jpg;/images/gallery/duggan/full-resolution/duggan_after_kitchen5.jpg;/images/gallery/duggan/full-resolution/duggan_after_livingroom.jpg;/images/gallery/duggan/full-resolution/duggan_after_livingroom2.jpg;/images/gallery/duggan/full-resolution/duggan_after_livingroom3.jpg;/images/gallery/duggan/full-resolution/duggan_after_wideshot.jpg", "duggan", "", "/images/gallery/duggan/thumbnails/duggan_after_backentrance.jpg;/images/gallery/duggan/thumbnails/duggan_after_bathroom.jpg;/images/gallery/duggan/thumbnails/duggan_after_bathroom2.jpg;/images/gallery/duggan/thumbnails/duggan_after_decoratedwide.jpg;/images/gallery/duggan/thumbnails/duggan_after_diningarea.jpg;/images/gallery/duggan/thumbnails/duggan_after_kitchen1.jpg;/images/gallery/duggan/thumbnails/duggan_after_kitchen2.jpg;/images/gallery/duggan/thumbnails/duggan_after_kitchen3.jpg;/images/gallery/duggan/thumbnails/duggan_after_kitchen4.jpg;/images/gallery/duggan/thumbnails/duggan_after_kitchen5.jpg;/images/gallery/duggan/thumbnails/duggan_after_livingroom.jpg;/images/gallery/duggan/thumbnails/duggan_after_livingroom2.jpg;/images/gallery/duggan/thumbnails/duggan_after_livingroom3.jpg;/images/gallery/duggan/thumbnails/duggan_after_wideshot.jpg" });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "ProjectId", "DisplayName", "FullImages", "Name", "ThumbnailImage", "ThumbnailImages" },
                values: new object[] { 3, "Millwoods Project", "/images/gallery/millwoods/full-resolution/millwoods_after_bathroom1.jpg;/images/gallery/millwoods/full-resolution/millwoods_after_bathroom2.jpg;/images/gallery/millwoods/full-resolution/millwoods_after_bathroom3.jpg;/images/gallery/millwoods/full-resolution/millwoods_after_dining1.jpg;/images/gallery/millwoods/full-resolution/millwoods_after_kitchen1.jpg;/images/gallery/millwoods/full-resolution/millwoods_after_kitchen2.jpg", "millwoods", "", "/images/gallery/millwoods/thumbnails/millwoods_after_bathroom1.jpg;/images/gallery/millwoods/thumbnails/millwoods_after_bathroom2.jpg;/images/gallery/millwoods/thumbnails/millwoods_after_bathroom3.jpg;/images/gallery/millwoods/thumbnails/millwoods_after_dining1.jpg;/images/gallery/millwoods/thumbnails/millwoods_after_kitchen1.jpg;/images/gallery/millwoods/thumbnails/millwoods_after_kitchen2.jpg" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Projects");
        }
    }
}
