using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MagicDatabase.Migrations
{
    /// <inheritdoc />
    public partial class EditCardCategoryAndSubCategory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cards_CardCategory_CardCategoryId",
                table: "Cards");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CardCategory",
                table: "CardCategory");

            migrationBuilder.RenameTable(
                name: "CardCategory",
                newName: "CardCategories");

            migrationBuilder.AlterColumn<string>(
                name: "CardCategoryName",
                table: "CardCategories",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CardCategories",
                table: "CardCategories",
                column: "CardCategoryId");

            migrationBuilder.CreateTable(
                name: "CardSubCategories",
                columns: table => new
                {
                    CardSubCategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CardSubCategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CardCategoryID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CardSubCategories", x => x.CardSubCategoryId);
                    table.ForeignKey(
                        name: "FK_CardSubCategories_CardCategories_CardCategoryID",
                        column: x => x.CardCategoryID,
                        principalTable: "CardCategories",
                        principalColumn: "CardCategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "CardCategories",
                columns: new[] { "CardCategoryId", "CardCategoryName" },
                values: new object[,]
                {
                    { 1, "Creatura" },
                    { 2, "Incantesimo" },
                    { 3, "Artefatto" }
                });

            migrationBuilder.InsertData(
                table: "CardSubCategories",
                columns: new[] { "CardSubCategoryId", "CardCategoryID", "CardSubCategoryName" },
                values: new object[,]
                {
                    { 1, 1, "Elfo" },
                    { 2, 1, "Zombie" },
                    { 3, 2, "Aura" },
                    { 4, 3, "Equipaggiamento" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CardSubCategories_CardCategoryID",
                table: "CardSubCategories",
                column: "CardCategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_Cards_CardCategories_CardCategoryId",
                table: "Cards",
                column: "CardCategoryId",
                principalTable: "CardCategories",
                principalColumn: "CardCategoryId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cards_CardCategories_CardCategoryId",
                table: "Cards");

            migrationBuilder.DropTable(
                name: "CardSubCategories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CardCategories",
                table: "CardCategories");

            migrationBuilder.DeleteData(
                table: "CardCategories",
                keyColumn: "CardCategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CardCategories",
                keyColumn: "CardCategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CardCategories",
                keyColumn: "CardCategoryId",
                keyValue: 3);

            migrationBuilder.RenameTable(
                name: "CardCategories",
                newName: "CardCategory");

            migrationBuilder.AlterColumn<string>(
                name: "CardCategoryName",
                table: "CardCategory",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AddPrimaryKey(
                name: "PK_CardCategory",
                table: "CardCategory",
                column: "CardCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cards_CardCategory_CardCategoryId",
                table: "Cards",
                column: "CardCategoryId",
                principalTable: "CardCategory",
                principalColumn: "CardCategoryId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
