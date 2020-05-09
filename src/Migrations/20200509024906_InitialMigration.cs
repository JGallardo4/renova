using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Renova.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GallerySections",
                columns: table => new
                {
                    GallerySectionId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GallerySections", x => x.GallerySectionId);
                });

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    ImageId = table.Column<int>(nullable: false),
                    GallerySectionId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Stage = table.Column<int>(nullable: false),
                    ImageUrl = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.ImageId);
                    table.ForeignKey(
                        name: "FK_Images_GallerySections_GallerySectionId",
                        column: x => x.GallerySectionId,
                        principalTable: "GallerySections",
                        principalColumn: "GallerySectionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "GallerySections",
                columns: new[] { "GallerySectionId", "Name" },
                values: new object[,]
                {
                    { 1, "Kitchen" },
                    { 2, "Living Room" },
                    { 3, "Bathroom" },
                    { 4, "Office" },
                    { 5, "Others" }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "ImageId", "GallerySectionId", "ImageUrl", "Stage" },
                values: new object[] { 1, 1, "/images/kitchen/kitchen1_before_1.jpg", 0 });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "ImageId", "GallerySectionId", "ImageUrl", "Stage" },
                values: new object[] { 2, 1, "/images/kitchen/kitchen1_during_1.jpg", 1 });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "ImageId", "GallerySectionId", "ImageUrl", "Stage" },
                values: new object[] { 3, 1, "/images/kitchen/kitchen1_after_1.jpg", 2 });

            migrationBuilder.CreateIndex(
                name: "IX_Images_GallerySectionId",
                table: "Images",
                column: "GallerySectionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DropTable(
                name: "GallerySections");
        }
    }
}
