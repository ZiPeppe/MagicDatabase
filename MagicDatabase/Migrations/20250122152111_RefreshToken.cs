using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagicDatabase.Migrations
{
    /// <inheritdoc />
    public partial class RefreshToken : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEMgGyTNY+63SxWRQvr8BMWgLU1/BEBmnDUmIJiULsodH4E4ZIdOzTyDeRVPjGWzeiQ==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEBOEswCXnqyE9WOQXrq6ZWGg1OvbhUACNp+UptJqhXGSQTilKJ77zmGhHpolW6cHLA==");
        }
    }
}
