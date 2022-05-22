using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class AddBrandIdToFeature : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BrandId",
                table: "Features",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Features_BrandId",
                table: "Features",
                column: "BrandId");

            migrationBuilder.AddForeignKey(
                name: "FK_Features_Brands_BrandId",
                table: "Features",
                column: "BrandId",
                principalTable: "Brands",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Features_Brands_BrandId",
                table: "Features");

            migrationBuilder.DropIndex(
                name: "IX_Features_BrandId",
                table: "Features");

            migrationBuilder.DropColumn(
                name: "BrandId",
                table: "Features");
        }
    }
}
