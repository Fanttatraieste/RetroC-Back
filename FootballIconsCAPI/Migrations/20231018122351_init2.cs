using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FootballIconsCAPI.Migrations
{
    /// <inheritdoc />
    public partial class init2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BallonDorInfo",
                columns: table => new
                {
                    BallonDorID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Winner = table.Column<int>(type: "int", nullable: false),
                    RunnerUp = table.Column<int>(type: "int", nullable: false),
                    ThirdPlace = table.Column<int>(type: "int", nullable: false),
                    FourthPlace = table.Column<int>(type: "int", nullable: false),
                    Fifthlace = table.Column<int>(type: "int", nullable: false),
                    SixthPlace = table.Column<int>(type: "int", nullable: false),
                    SeventhPlace = table.Column<int>(type: "int", nullable: false),
                    EigthPlace = table.Column<int>(type: "int", nullable: false),
                    NinethPlace = table.Column<int>(type: "int", nullable: false),
                    TenthPlace = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BallonDorInfo", x => x.BallonDorID);
                });

            migrationBuilder.CreateTable(
                name: "Nominations",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BallonDorID = table.Column<int>(type: "int", nullable: false),
                    Nomination = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nominations", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Nominations_BallonDorInfo_BallonDorID",
                        column: x => x.BallonDorID,
                        principalTable: "BallonDorInfo",
                        principalColumn: "BallonDorID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Nominations_BallonDorID",
                table: "Nominations",
                column: "BallonDorID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Nominations");

            migrationBuilder.DropTable(
                name: "BallonDorInfo");
        }
    }
}
