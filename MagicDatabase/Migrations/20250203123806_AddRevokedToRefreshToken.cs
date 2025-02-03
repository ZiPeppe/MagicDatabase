using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagicDatabase.Migrations
{
    /// <inheritdoc />
    public partial class AddRevokedToRefreshToken : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEKjoMC6eGqroONRG0bL9QtCltlkYW7kuJAcRe+8guLskScy2nHJtQ0xLcNKC7b80VQ==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEDGm9i0zw5UsXrJKIaIBW2XCJgm6zFeMeMpbLjEYyPpKtDnVmcbvqXMoTyQqSLvWKA==");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEI2RanpfJR3wiwFhEgJsh5adMJqTY+oZzgxRgPdD79wyyaF3FTTu0GQsrUvswj9JhQ==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEIh35SbHX1Si4lHd98rnmZHaztV4dwslSI2aHPPRAW+oHR+J8jhVLZIRx4WCGrO4zg==");
        }
    }
}
