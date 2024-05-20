using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PierreTreat.Migrations
{
    public partial class FixFlavorTypo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FavorName",
                table: "Flavors",
                newName: "FlavorName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FlavorName",
                table: "Flavors",
                newName: "FavorName");
        }
    }
}
