using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AssetManagement_DataBase.Migrations
{
    /// <inheritdoc />
    public partial class SeedInitialData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Assets",
                columns: new[] { "Id", "Category", "Currency", "DateCreatedInDb", "Location", "Name", "Value" },
                values: new object[] { "1", "Furniture", "ZAR", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Main Office", "Office Chair", 1000f });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: "1");
        }
    }
}
