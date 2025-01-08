using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagicDatabase.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CardArtType",
                columns: table => new
                {
                    CardArtTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CardArtTypeName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CardArtType", x => x.CardArtTypeId);
                });

            migrationBuilder.CreateTable(
                name: "CardCategory",
                columns: table => new
                {
                    CardCategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CardCategoryName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CardCategory", x => x.CardCategoryId);
                });

            migrationBuilder.CreateTable(
                name: "CardLanguage",
                columns: table => new
                {
                    CardLanguageId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CardLanguageName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CardLanguage", x => x.CardLanguageId);
                });

            migrationBuilder.CreateTable(
                name: "CardRarity",
                columns: table => new
                {
                    CardRarityId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CardRarityName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CardRarity", x => x.CardRarityId);
                });

            migrationBuilder.CreateTable(
                name: "CardStatus",
                columns: table => new
                {
                    CardStatusId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CardStatusName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CardStatus", x => x.CardStatusId);
                });

            migrationBuilder.CreateTable(
                name: "Cards",
                columns: table => new
                {
                    CardId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CardName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    CardRarityId = table.Column<int>(type: "int", nullable: false),
                    CardStatusId = table.Column<int>(type: "int", nullable: false),
                    CardCategoryId = table.Column<int>(type: "int", nullable: false),
                    CardLanguageId = table.Column<int>(type: "int", nullable: false),
                    CardArtTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cards", x => x.CardId);
                    table.ForeignKey(
                        name: "FK_Cards_CardArtType_CardArtTypeId",
                        column: x => x.CardArtTypeId,
                        principalTable: "CardArtType",
                        principalColumn: "CardArtTypeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cards_CardCategory_CardCategoryId",
                        column: x => x.CardCategoryId,
                        principalTable: "CardCategory",
                        principalColumn: "CardCategoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cards_CardLanguage_CardLanguageId",
                        column: x => x.CardLanguageId,
                        principalTable: "CardLanguage",
                        principalColumn: "CardLanguageId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cards_CardRarity_CardRarityId",
                        column: x => x.CardRarityId,
                        principalTable: "CardRarity",
                        principalColumn: "CardRarityId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cards_CardStatus_CardStatusId",
                        column: x => x.CardStatusId,
                        principalTable: "CardStatus",
                        principalColumn: "CardStatusId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cards_CardArtTypeId",
                table: "Cards",
                column: "CardArtTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Cards_CardCategoryId",
                table: "Cards",
                column: "CardCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Cards_CardLanguageId",
                table: "Cards",
                column: "CardLanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_Cards_CardRarityId",
                table: "Cards",
                column: "CardRarityId");

            migrationBuilder.CreateIndex(
                name: "IX_Cards_CardStatusId",
                table: "Cards",
                column: "CardStatusId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cards");

            migrationBuilder.DropTable(
                name: "CardArtType");

            migrationBuilder.DropTable(
                name: "CardCategory");

            migrationBuilder.DropTable(
                name: "CardLanguage");

            migrationBuilder.DropTable(
                name: "CardRarity");

            migrationBuilder.DropTable(
                name: "CardStatus");
        }
    }
}
