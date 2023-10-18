using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FootballIconsCAPI.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "IconInfo",
                columns: table => new
                {
                    IconID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DoB = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CareerLength = table.Column<int>(type: "int", nullable: false),
                    CareerGames = table.Column<int>(type: "int", nullable: false),
                    CareerGoals = table.Column<int>(type: "int", nullable: false),
                    Fantascore = table.Column<int>(type: "int", nullable: false),
                    Position = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IconInfo", x => x.IconID);
                });

            migrationBuilder.CreateTable(
                name: "NationInfo",
                columns: table => new
                {
                    NationID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Confederation = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NationInfo", x => x.NationID);
                });

            migrationBuilder.CreateTable(
                name: "TeamInfo",
                columns: table => new
                {
                    TeamID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Country = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeamInfo", x => x.TeamID);
                });

            migrationBuilder.CreateTable(
                name: "ContinentalCupInfo",
                columns: table => new
                {
                    ContinentalCupID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Winner = table.Column<int>(type: "int", nullable: false),
                    RunnerUp = table.Column<int>(type: "int", nullable: false),
                    ThirdPlace = table.Column<int>(type: "int", nullable: false),
                    Place = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    CupName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NationID = table.Column<int>(type: "int", nullable: true),
                    NationID1 = table.Column<int>(type: "int", nullable: true),
                    NationID2 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContinentalCupInfo", x => x.ContinentalCupID);
                    table.ForeignKey(
                        name: "FK_ContinentalCupInfo_NationInfo_NationID",
                        column: x => x.NationID,
                        principalTable: "NationInfo",
                        principalColumn: "NationID");
                    table.ForeignKey(
                        name: "FK_ContinentalCupInfo_NationInfo_NationID1",
                        column: x => x.NationID1,
                        principalTable: "NationInfo",
                        principalColumn: "NationID");
                    table.ForeignKey(
                        name: "FK_ContinentalCupInfo_NationInfo_NationID2",
                        column: x => x.NationID2,
                        principalTable: "NationInfo",
                        principalColumn: "NationID");
                });

            migrationBuilder.CreateTable(
                name: "NationStatsInfo",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false),
                    NationID = table.Column<int>(type: "int", nullable: false),
                    GamesPlayed = table.Column<int>(type: "int", nullable: false),
                    GoalsScored = table.Column<int>(type: "int", nullable: false),
                    WorldCupGoals = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NationStatsInfo", x => x.ID);
                    table.ForeignKey(
                        name: "FK_NationStatsInfo_IconInfo_ID",
                        column: x => x.ID,
                        principalTable: "IconInfo",
                        principalColumn: "IconID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NationStatsInfo_NationInfo_NationID",
                        column: x => x.NationID,
                        principalTable: "NationInfo",
                        principalColumn: "NationID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WorldCupInfo",
                columns: table => new
                {
                    WorldCupID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Winner = table.Column<int>(type: "int", nullable: false),
                    RunnerUp = table.Column<int>(type: "int", nullable: false),
                    ThirdPlace = table.Column<int>(type: "int", nullable: false),
                    Place = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    NationID = table.Column<int>(type: "int", nullable: true),
                    NationID1 = table.Column<int>(type: "int", nullable: true),
                    NationID2 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorldCupInfo", x => x.WorldCupID);
                    table.ForeignKey(
                        name: "FK_WorldCupInfo_NationInfo_NationID",
                        column: x => x.NationID,
                        principalTable: "NationInfo",
                        principalColumn: "NationID");
                    table.ForeignKey(
                        name: "FK_WorldCupInfo_NationInfo_NationID1",
                        column: x => x.NationID1,
                        principalTable: "NationInfo",
                        principalColumn: "NationID");
                    table.ForeignKey(
                        name: "FK_WorldCupInfo_NationInfo_NationID2",
                        column: x => x.NationID2,
                        principalTable: "NationInfo",
                        principalColumn: "NationID");
                });

            migrationBuilder.CreateTable(
                name: "ChampionsCupInfo",
                columns: table => new
                {
                    ChampionsCupID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Winner = table.Column<int>(type: "int", nullable: false),
                    RunnerUp = table.Column<int>(type: "int", nullable: false),
                    Place = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    TeamID = table.Column<int>(type: "int", nullable: true),
                    TeamID1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChampionsCupInfo", x => x.ChampionsCupID);
                    table.ForeignKey(
                        name: "FK_ChampionsCupInfo_TeamInfo_TeamID",
                        column: x => x.TeamID,
                        principalTable: "TeamInfo",
                        principalColumn: "TeamID");
                    table.ForeignKey(
                        name: "FK_ChampionsCupInfo_TeamInfo_TeamID1",
                        column: x => x.TeamID1,
                        principalTable: "TeamInfo",
                        principalColumn: "TeamID");
                });

            migrationBuilder.CreateTable(
                name: "DomesticCupInfo",
                columns: table => new
                {
                    DomesticCupID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Winner = table.Column<int>(type: "int", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    TeamID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DomesticCupInfo", x => x.DomesticCupID);
                    table.ForeignKey(
                        name: "FK_DomesticCupInfo_TeamInfo_TeamID",
                        column: x => x.TeamID,
                        principalTable: "TeamInfo",
                        principalColumn: "TeamID");
                });

            migrationBuilder.CreateTable(
                name: "DomesticLeagueCupInfo",
                columns: table => new
                {
                    DomesticLeagueID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Winner = table.Column<int>(type: "int", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    TeamID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DomesticLeagueCupInfo", x => x.DomesticLeagueID);
                    table.ForeignKey(
                        name: "FK_DomesticLeagueCupInfo_TeamInfo_TeamID",
                        column: x => x.TeamID,
                        principalTable: "TeamInfo",
                        principalColumn: "TeamID");
                });

            migrationBuilder.CreateTable(
                name: "DomesticSuperCupInfo",
                columns: table => new
                {
                    DomesticSuperCupID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Winner = table.Column<int>(type: "int", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    TeamID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DomesticSuperCupInfo", x => x.DomesticSuperCupID);
                    table.ForeignKey(
                        name: "FK_DomesticSuperCupInfo_TeamInfo_TeamID",
                        column: x => x.TeamID,
                        principalTable: "TeamInfo",
                        principalColumn: "TeamID");
                });

            migrationBuilder.CreateTable(
                name: "TeamStatsInfo",
                columns: table => new
                {
                    TeamStatID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IconID = table.Column<int>(type: "int", nullable: false),
                    TeamID = table.Column<int>(type: "int", nullable: false),
                    GamesPlayed = table.Column<int>(type: "int", nullable: false),
                    GoalsScored = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeamStatsInfo", x => x.TeamStatID);
                    table.ForeignKey(
                        name: "FK_TeamStatsInfo_IconInfo_IconID",
                        column: x => x.IconID,
                        principalTable: "IconInfo",
                        principalColumn: "IconID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TeamStatsInfo_TeamInfo_TeamID",
                        column: x => x.TeamID,
                        principalTable: "TeamInfo",
                        principalColumn: "TeamID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UEFACupInfo",
                columns: table => new
                {
                    UEFACupID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Winner = table.Column<int>(type: "int", nullable: false),
                    RunnerUp = table.Column<int>(type: "int", nullable: false),
                    Place = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    TeamID = table.Column<int>(type: "int", nullable: true),
                    TeamID1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UEFACupInfo", x => x.UEFACupID);
                    table.ForeignKey(
                        name: "FK_UEFACupInfo_TeamInfo_TeamID",
                        column: x => x.TeamID,
                        principalTable: "TeamInfo",
                        principalColumn: "TeamID");
                    table.ForeignKey(
                        name: "FK_UEFACupInfo_TeamInfo_TeamID1",
                        column: x => x.TeamID1,
                        principalTable: "TeamInfo",
                        principalColumn: "TeamID");
                });

            migrationBuilder.CreateTable(
                name: "UEFASuperCupInfo",
                columns: table => new
                {
                    UEFASuperCupID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Winner = table.Column<int>(type: "int", nullable: false),
                    Place = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    TeamID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UEFASuperCupInfo", x => x.UEFASuperCupID);
                    table.ForeignKey(
                        name: "FK_UEFASuperCupInfo_TeamInfo_TeamID",
                        column: x => x.TeamID,
                        principalTable: "TeamInfo",
                        principalColumn: "TeamID");
                });

            migrationBuilder.CreateTable(
                name: "WinnersCupInfo",
                columns: table => new
                {
                    WinnersCupID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Winner = table.Column<int>(type: "int", nullable: false),
                    RunnerUp = table.Column<int>(type: "int", nullable: false),
                    Place = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    TeamID = table.Column<int>(type: "int", nullable: true),
                    TeamID1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WinnersCupInfo", x => x.WinnersCupID);
                    table.ForeignKey(
                        name: "FK_WinnersCupInfo_TeamInfo_TeamID",
                        column: x => x.TeamID,
                        principalTable: "TeamInfo",
                        principalColumn: "TeamID");
                    table.ForeignKey(
                        name: "FK_WinnersCupInfo_TeamInfo_TeamID1",
                        column: x => x.TeamID1,
                        principalTable: "TeamInfo",
                        principalColumn: "TeamID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChampionsCupInfo_TeamID",
                table: "ChampionsCupInfo",
                column: "TeamID");

            migrationBuilder.CreateIndex(
                name: "IX_ChampionsCupInfo_TeamID1",
                table: "ChampionsCupInfo",
                column: "TeamID1");

            migrationBuilder.CreateIndex(
                name: "IX_ContinentalCupInfo_NationID",
                table: "ContinentalCupInfo",
                column: "NationID");

            migrationBuilder.CreateIndex(
                name: "IX_ContinentalCupInfo_NationID1",
                table: "ContinentalCupInfo",
                column: "NationID1");

            migrationBuilder.CreateIndex(
                name: "IX_ContinentalCupInfo_NationID2",
                table: "ContinentalCupInfo",
                column: "NationID2");

            migrationBuilder.CreateIndex(
                name: "IX_DomesticCupInfo_TeamID",
                table: "DomesticCupInfo",
                column: "TeamID");

            migrationBuilder.CreateIndex(
                name: "IX_DomesticLeagueCupInfo_TeamID",
                table: "DomesticLeagueCupInfo",
                column: "TeamID");

            migrationBuilder.CreateIndex(
                name: "IX_DomesticSuperCupInfo_TeamID",
                table: "DomesticSuperCupInfo",
                column: "TeamID");

            migrationBuilder.CreateIndex(
                name: "IX_NationStatsInfo_NationID",
                table: "NationStatsInfo",
                column: "NationID");

            migrationBuilder.CreateIndex(
                name: "IX_TeamStatsInfo_IconID",
                table: "TeamStatsInfo",
                column: "IconID");

            migrationBuilder.CreateIndex(
                name: "IX_TeamStatsInfo_TeamID",
                table: "TeamStatsInfo",
                column: "TeamID");

            migrationBuilder.CreateIndex(
                name: "IX_UEFACupInfo_TeamID",
                table: "UEFACupInfo",
                column: "TeamID");

            migrationBuilder.CreateIndex(
                name: "IX_UEFACupInfo_TeamID1",
                table: "UEFACupInfo",
                column: "TeamID1");

            migrationBuilder.CreateIndex(
                name: "IX_UEFASuperCupInfo_TeamID",
                table: "UEFASuperCupInfo",
                column: "TeamID");

            migrationBuilder.CreateIndex(
                name: "IX_WinnersCupInfo_TeamID",
                table: "WinnersCupInfo",
                column: "TeamID");

            migrationBuilder.CreateIndex(
                name: "IX_WinnersCupInfo_TeamID1",
                table: "WinnersCupInfo",
                column: "TeamID1");

            migrationBuilder.CreateIndex(
                name: "IX_WorldCupInfo_NationID",
                table: "WorldCupInfo",
                column: "NationID");

            migrationBuilder.CreateIndex(
                name: "IX_WorldCupInfo_NationID1",
                table: "WorldCupInfo",
                column: "NationID1");

            migrationBuilder.CreateIndex(
                name: "IX_WorldCupInfo_NationID2",
                table: "WorldCupInfo",
                column: "NationID2");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChampionsCupInfo");

            migrationBuilder.DropTable(
                name: "ContinentalCupInfo");

            migrationBuilder.DropTable(
                name: "DomesticCupInfo");

            migrationBuilder.DropTable(
                name: "DomesticLeagueCupInfo");

            migrationBuilder.DropTable(
                name: "DomesticSuperCupInfo");

            migrationBuilder.DropTable(
                name: "NationStatsInfo");

            migrationBuilder.DropTable(
                name: "TeamStatsInfo");

            migrationBuilder.DropTable(
                name: "UEFACupInfo");

            migrationBuilder.DropTable(
                name: "UEFASuperCupInfo");

            migrationBuilder.DropTable(
                name: "WinnersCupInfo");

            migrationBuilder.DropTable(
                name: "WorldCupInfo");

            migrationBuilder.DropTable(
                name: "IconInfo");

            migrationBuilder.DropTable(
                name: "TeamInfo");

            migrationBuilder.DropTable(
                name: "NationInfo");
        }
    }
}
