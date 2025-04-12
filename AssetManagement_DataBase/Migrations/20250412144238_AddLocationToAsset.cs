using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AssetManagement_DataBase.Migrations
{
    /// <inheritdoc />
    public partial class AddLocationToAsset : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Location",
                table: "Assets",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Location",
                table: "Assets");
        }
    }
}
