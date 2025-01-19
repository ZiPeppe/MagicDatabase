using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MagicDatabase.Migrations
{
    /// <inheritdoc />
    public partial class UsersTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Password",
                table: "Users",
                newName: "PasswordHash");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Users",
                newName: "UserId");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "PasswordHash", "Role", "Username" },
                values: new object[,]
                {
                    { 1, "AQAAAAIAAYagAAAAEMgGyTNY+63SxWRQvr8BMWgLU1/BEBmnDUmIJiULsodH4E4ZIdOzTyDeRVPjGWzeiQ==", "Admin", "admin" },
                    { 2, "AQAAAAIAAYagAAAAEBOEswCXnqyE9WOQXrq6ZWGg1OvbhUACNp+UptJqhXGSQTilKJ77zmGhHpolW6cHLA==", "User", "user" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2);

            migrationBuilder.RenameColumn(
                name: "PasswordHash",
                table: "Users",
                newName: "Password");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Users",
                newName: "Id");
        }
    }
}
