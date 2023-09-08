using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StorageLibrary.Migrations
{
    /// <inheritdoc />
    public partial class Migration01 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FavoredDie",
                columns: table => new
                {
                    FavoredDieId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FavorFactor = table.Column<byte>(type: "INTEGER", nullable: false),
                    FavoredFace = table.Column<byte>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FavoredDie", x => x.FavoredDieId);
                });

            migrationBuilder.CreateTable(
                name: "FavoredResultPair",
                columns: table => new
                {
                    FavoredResultPairId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstFavoredDieId = table.Column<int>(type: "INTEGER", nullable: false),
                    SecondFavoredDieId = table.Column<int>(type: "INTEGER", nullable: false),
                    FirstFace = table.Column<byte>(type: "INTEGER", nullable: false),
                    SecondFace = table.Column<byte>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FavoredResultPair", x => x.FavoredResultPairId);
                    table.ForeignKey(
                        name: "FK_FavoredResultPair_FavoredDie_FirstFavoredDieId",
                        column: x => x.FirstFavoredDieId,
                        principalTable: "FavoredDie",
                        principalColumn: "FavoredDieId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FavoredResultPair_FavoredDie_SecondFavoredDieId",
                        column: x => x.SecondFavoredDieId,
                        principalTable: "FavoredDie",
                        principalColumn: "FavoredDieId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FavoredResultPair_FirstFavoredDieId",
                table: "FavoredResultPair",
                column: "FirstFavoredDieId");

            migrationBuilder.CreateIndex(
                name: "IX_FavoredResultPair_SecondFavoredDieId",
                table: "FavoredResultPair",
                column: "SecondFavoredDieId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FavoredResultPair");

            migrationBuilder.DropTable(
                name: "FavoredDie");
        }
    }
}
