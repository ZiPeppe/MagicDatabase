using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagicDatabase.Migrations
{
    /// <inheritdoc />
    public partial class mssql_migration_562 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CardRarities",
                columns: table => new
                {
                    CardRarityId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RarityName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CardRarities", x => x.CardRarityId);
                });

            migrationBuilder.CreateTable(
                name: "CardStatuses",
                columns: table => new
                {
                    CardStatusId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StatusName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CardStatuses", x => x.CardStatusId);
                });

            migrationBuilder.CreateTable(
                name: "Cards",
                columns: table => new
                {
                    CardId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CardName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CardRarityId = table.Column<int>(type: "int", nullable: false),
                    CardStatusId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cards", x => x.CardId);
                    table.ForeignKey(
                        name: "FK_Cards_CardRarities_CardRarityId",
                        column: x => x.CardRarityId,
                        principalTable: "CardRarities",
                        principalColumn: "CardRarityId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cards_CardStatuses_CardStatusId",
                        column: x => x.CardStatusId,
                        principalTable: "CardStatuses",
                        principalColumn: "CardStatusId",
                        onDelete: ReferentialAction.Cascade);
                });

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
                name: "CardRarities");

            migrationBuilder.DropTable(
                name: "CardStatuses");
        }
    }
}
