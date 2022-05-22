using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class EditFeature : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "NameFalue",
                table: "Features",
                type: "nvarchar(max)",
                nullable: true,
                computedColumnSql: "[FeatureName]+' : '+[FeatureValu]");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NameFalue",
                table: "Features");
        }
    }
}
