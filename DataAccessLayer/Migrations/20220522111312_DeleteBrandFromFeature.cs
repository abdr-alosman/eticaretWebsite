using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class DeleteBrandFromFeature : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Features_Brands_BrandId",
                table: "Features");

            migrationBuilder.DropIndex(
                name: "IX_Features_BrandId",
                table: "Features");

            migrationBuilder.AlterColumn<int>(
                name: "BrandId",
                table: "Features",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "BrandId",
                table: "Features",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Features_BrandId",
                table: "Features",
                column: "BrandId");

            migrationBuilder.AddForeignKey(
                name: "FK_Features_Brands_BrandId",
                table: "Features",
                column: "BrandId",
                principalTable: "Brands",
                principalColumn: "Id");
        }
    }
}
