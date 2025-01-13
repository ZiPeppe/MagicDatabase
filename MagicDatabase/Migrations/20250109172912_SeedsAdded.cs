using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MagicDatabase.Migrations
{
    /// <inheritdoc />
    public partial class SeedsAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cards_CardArtType_CardArtTypeId",
                table: "Cards");

            migrationBuilder.DropForeignKey(
                name: "FK_Cards_CardLanguage_CardLanguageId",
                table: "Cards");

            migrationBuilder.DropForeignKey(
                name: "FK_Cards_CardRarity_CardRarityId",
                table: "Cards");

            migrationBuilder.DropForeignKey(
                name: "FK_Cards_CardStatus_CardStatusId",
                table: "Cards");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CardStatus",
                table: "CardStatus");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CardRarity",
                table: "CardRarity");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CardLanguage",
                table: "CardLanguage");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CardArtType",
                table: "CardArtType");

            migrationBuilder.RenameTable(
                name: "CardStatus",
                newName: "CardStatuses");

            migrationBuilder.RenameTable(
                name: "CardRarity",
                newName: "CardRarities");

            migrationBuilder.RenameTable(
                name: "CardLanguage",
                newName: "CardLanguages");

            migrationBuilder.RenameTable(
                name: "CardArtType",
                newName: "CardArtTypes");

            migrationBuilder.AlterColumn<string>(
                name: "CardCategoryName",
                table: "CardCategory",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AddPrimaryKey(
                name: "PK_CardStatuses",
                table: "CardStatuses",
                column: "CardStatusId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CardRarities",
                table: "CardRarities",
                column: "CardRarityId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CardLanguages",
                table: "CardLanguages",
                column: "CardLanguageId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CardArtTypes",
                table: "CardArtTypes",
                column: "CardArtTypeId");

            migrationBuilder.InsertData(
                table: "CardArtTypes",
                columns: new[] { "CardArtTypeId", "CardArtTypeName" },
                values: new object[,]
                {
                    { 1, "Foil" },
                    { 2, "Foil Etched" },
                    { 3, "Reverse Foil" },
                    { 4, "Full Art" },
                    { 5, "Full Art Foil" },
                    { 6, "Full Art Other Foilage" },
                    { 7, "Double Art" },
                    { 8, "Double Art Foil" },
                    { 9, "Borderless" },
                    { 10, "Borderless Foil" },
                    { 11, "Alternative Art" },
                    { 12, "Alternative Art Foil" },
                    { 13, "Promo" },
                    { 14, "Promo Foil" },
                    { 15, "Missprint" }
                });

            migrationBuilder.InsertData(
                table: "CardLanguages",
                columns: new[] { "CardLanguageId", "CardLanguageName" },
                values: new object[,]
                {
                    { 1, "Italian" },
                    { 2, "English" },
                    { 3, "Japanese" },
                    { 4, "French" },
                    { 5, "German" },
                    { 6, "Russian" },
                    { 7, "Spanish" },
                    { 8, "Portuguese" },
                    { 9, "Chinese" },
                    { 10, "Korean" }
                });

            migrationBuilder.InsertData(
                table: "CardRarities",
                columns: new[] { "CardRarityId", "CardRarityName" },
                values: new object[,]
                {
                    { 1, "Common" },
                    { 2, "Uncommon" },
                    { 3, "Rare" },
                    { 4, "Mythic Rare" }
                });

            migrationBuilder.InsertData(
                table: "CardStatuses",
                columns: new[] { "CardStatusId", "CardStatusName" },
                values: new object[,]
                {
                    { 1, "Trashed" },
                    { 2, "Damaged" },
                    { 3, "Poor" },
                    { 4, "Heavily Played" },
                    { 5, "Lightly Played" },
                    { 6, "Good" },
                    { 7, "Excellent" },
                    { 8, "Near Mint" },
                    { 9, "Mint" },
                    { 10, "Sealed" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Cards_CardArtTypes_CardArtTypeId",
                table: "Cards",
                column: "CardArtTypeId",
                principalTable: "CardArtTypes",
                principalColumn: "CardArtTypeId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Cards_CardLanguages_CardLanguageId",
                table: "Cards",
                column: "CardLanguageId",
                principalTable: "CardLanguages",
                principalColumn: "CardLanguageId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Cards_CardRarities_CardRarityId",
                table: "Cards",
                column: "CardRarityId",
                principalTable: "CardRarities",
                principalColumn: "CardRarityId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Cards_CardStatuses_CardStatusId",
                table: "Cards",
                column: "CardStatusId",
                principalTable: "CardStatuses",
                principalColumn: "CardStatusId",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cards_CardArtTypes_CardArtTypeId",
                table: "Cards");

            migrationBuilder.DropForeignKey(
                name: "FK_Cards_CardLanguages_CardLanguageId",
                table: "Cards");

            migrationBuilder.DropForeignKey(
                name: "FK_Cards_CardRarities_CardRarityId",
                table: "Cards");

            migrationBuilder.DropForeignKey(
                name: "FK_Cards_CardStatuses_CardStatusId",
                table: "Cards");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CardStatuses",
                table: "CardStatuses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CardRarities",
                table: "CardRarities");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CardLanguages",
                table: "CardLanguages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CardArtTypes",
                table: "CardArtTypes");

            migrationBuilder.DeleteData(
                table: "CardArtTypes",
                keyColumn: "CardArtTypeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CardArtTypes",
                keyColumn: "CardArtTypeId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CardArtTypes",
                keyColumn: "CardArtTypeId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CardArtTypes",
                keyColumn: "CardArtTypeId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "CardArtTypes",
                keyColumn: "CardArtTypeId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "CardArtTypes",
                keyColumn: "CardArtTypeId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "CardArtTypes",
                keyColumn: "CardArtTypeId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "CardArtTypes",
                keyColumn: "CardArtTypeId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "CardArtTypes",
                keyColumn: "CardArtTypeId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "CardArtTypes",
                keyColumn: "CardArtTypeId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "CardArtTypes",
                keyColumn: "CardArtTypeId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "CardArtTypes",
                keyColumn: "CardArtTypeId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "CardArtTypes",
                keyColumn: "CardArtTypeId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "CardArtTypes",
                keyColumn: "CardArtTypeId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "CardArtTypes",
                keyColumn: "CardArtTypeId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "CardLanguages",
                keyColumn: "CardLanguageId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CardLanguages",
                keyColumn: "CardLanguageId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CardLanguages",
                keyColumn: "CardLanguageId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CardLanguages",
                keyColumn: "CardLanguageId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "CardLanguages",
                keyColumn: "CardLanguageId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "CardLanguages",
                keyColumn: "CardLanguageId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "CardLanguages",
                keyColumn: "CardLanguageId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "CardLanguages",
                keyColumn: "CardLanguageId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "CardLanguages",
                keyColumn: "CardLanguageId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "CardLanguages",
                keyColumn: "CardLanguageId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "CardRarities",
                keyColumn: "CardRarityId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CardRarities",
                keyColumn: "CardRarityId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CardRarities",
                keyColumn: "CardRarityId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CardRarities",
                keyColumn: "CardRarityId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "CardStatuses",
                keyColumn: "CardStatusId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CardStatuses",
                keyColumn: "CardStatusId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CardStatuses",
                keyColumn: "CardStatusId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CardStatuses",
                keyColumn: "CardStatusId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "CardStatuses",
                keyColumn: "CardStatusId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "CardStatuses",
                keyColumn: "CardStatusId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "CardStatuses",
                keyColumn: "CardStatusId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "CardStatuses",
                keyColumn: "CardStatusId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "CardStatuses",
                keyColumn: "CardStatusId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "CardStatuses",
                keyColumn: "CardStatusId",
                keyValue: 10);

            migrationBuilder.RenameTable(
                name: "CardStatuses",
                newName: "CardStatus");

            migrationBuilder.RenameTable(
                name: "CardRarities",
                newName: "CardRarity");

            migrationBuilder.RenameTable(
                name: "CardLanguages",
                newName: "CardLanguage");

            migrationBuilder.RenameTable(
                name: "CardArtTypes",
                newName: "CardArtType");

            migrationBuilder.AlterColumn<string>(
                name: "CardCategoryName",
                table: "CardCategory",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CardStatus",
                table: "CardStatus",
                column: "CardStatusId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CardRarity",
                table: "CardRarity",
                column: "CardRarityId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CardLanguage",
                table: "CardLanguage",
                column: "CardLanguageId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CardArtType",
                table: "CardArtType",
                column: "CardArtTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cards_CardArtType_CardArtTypeId",
                table: "Cards",
                column: "CardArtTypeId",
                principalTable: "CardArtType",
                principalColumn: "CardArtTypeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cards_CardLanguage_CardLanguageId",
                table: "Cards",
                column: "CardLanguageId",
                principalTable: "CardLanguage",
                principalColumn: "CardLanguageId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cards_CardRarity_CardRarityId",
                table: "Cards",
                column: "CardRarityId",
                principalTable: "CardRarity",
                principalColumn: "CardRarityId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cards_CardStatus_CardStatusId",
                table: "Cards",
                column: "CardStatusId",
                principalTable: "CardStatus",
                principalColumn: "CardStatusId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
