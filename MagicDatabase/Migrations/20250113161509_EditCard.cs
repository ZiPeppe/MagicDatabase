using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagicDatabase.Migrations
{
    /// <inheritdoc />
    public partial class EditCard : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cards_CardCategories_CardCategoryId",
                table: "Cards");

            migrationBuilder.RenameColumn(
                name: "CardCategoryId",
                table: "Cards",
                newName: "CardSubCategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Cards_CardCategoryId",
                table: "Cards",
                newName: "IX_Cards_CardSubCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cards_CardSubCategories_CardSubCategoryId",
                table: "Cards",
                column: "CardSubCategoryId",
                principalTable: "CardSubCategories",
                principalColumn: "CardSubCategoryId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cards_CardSubCategories_CardSubCategoryId",
                table: "Cards");

            migrationBuilder.RenameColumn(
                name: "CardSubCategoryId",
                table: "Cards",
                newName: "CardCategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Cards_CardSubCategoryId",
                table: "Cards",
                newName: "IX_Cards_CardCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cards_CardCategories_CardCategoryId",
                table: "Cards",
                column: "CardCategoryId",
                principalTable: "CardCategories",
                principalColumn: "CardCategoryId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
