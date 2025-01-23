using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagicDatabase.Migrations
{
    /// <inheritdoc />
    public partial class UpdateRefreshToken : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RefreshTokens",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Token = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Revoked = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefreshTokens", x => x.Id);
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RefreshTokens");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEMVUlKtY3x2yMSJ/oh1jEI4bKa8OFclK9ww5mwVv2XQFXVOiSDd7YVs+4edhAWnXdg==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEJ7AVf4o8R7MGZ8xeEcB1tN3b8q8djNBMC5Z3oEW+o+L8WL8xNjDgMfiI1r4Y07U9g==");
        }
    }
}
