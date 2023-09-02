using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVCViewProject.Storage
{
    /// <inheritdoc />
    public partial class migration01 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PairRoll",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstFavoredFace = table.Column<byte>(type: "INTEGER", nullable: false),
                    FirstFavorFactor = table.Column<byte>(type: "INTEGER", nullable: false),
                    SecondFavoredFace = table.Column<byte>(type: "INTEGER", nullable: false),
                    SecondFavorFactor = table.Column<byte>(type: "INTEGER", nullable: false),
                    FirstUpFace = table.Column<byte>(type: "INTEGER", nullable: false),
                    SecondUpFace = table.Column<byte>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PairRoll", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PairRoll");
        }
    }
}
