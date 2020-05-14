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
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    Images = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.Name);
                });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Name", "Images" },
                values: new object[] { "Duggan", "/images/gallery/Duggan/after/duggan_after_kitchen2.jpg;/images/gallery/Duggan/after/duggan_after_kitchen5.jpg;/images/gallery/Duggan/after/duggan_after_livingroom3.jpg;/images/gallery/Duggan/after/duggan_after_bathroom2.jpg;/images/gallery/Duggan/after/duggan_after_livingroom.jpg;/images/gallery/Duggan/after/duggan_after_wideshot.jpg;/images/gallery/Duggan/after/duggan_after_diningarea.jpg;/images/gallery/Duggan/after/duggan_after_kitchen1.jpg;/images/gallery/Duggan/after/duggan_after_kitchen4.jpg;/images/gallery/Duggan/after/duggan_after_kitchen3.jpg;/images/gallery/Duggan/after/duggan_after_bathroom.jpg;/images/gallery/Duggan/after/duggan_after_decoratedwide.jpg;/images/gallery/Duggan/after/duggan_after_livingroom2.jpg;/images/gallery/Duggan/after/duggan_after_backentrance.jpg" });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Name", "Images" },
                values: new object[] { "Millwoods", "/images/gallery/Millwoods/after/millwoods_after_bathroom1.jpg;/images/gallery/Millwoods/after/millwoods_after_dining1.jpg;/images/gallery/Millwoods/after/millwoods_after_bathroom3.jpg;/images/gallery/Millwoods/after/millwoods_after_kitchen2.jpg;/images/gallery/Millwoods/after/millwoods_after_bathroom2.jpg;/images/gallery/Millwoods/after/millwoods_after_kitchen1.jpg" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Projects");
        }
    }
}
