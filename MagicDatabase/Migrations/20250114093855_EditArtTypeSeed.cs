using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagicDatabase.Migrations
{
    /// <inheritdoc />
    public partial class EditArtTypeSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "CardArtTypes",
                columns: new[] { "CardArtTypeId", "CardArtTypeName" },
                values: new object[] { 16, "None" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CardArtTypes",
                keyColumn: "CardArtTypeId",
                keyValue: 16);
        }
    }
}
