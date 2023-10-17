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
                name: "BallonDorInfo",
                columns: table => new
                {
                    BallonDorID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Year = table.Column<int>(type: "int", nullable: false),
                    WinnerIconID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BallonDorInfo", x => x.BallonDorID);
                });

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
                    Position = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BallonDorID = table.Column<int>(type: "int", nullable: true),
                    BallonDorID1 = table.Column<int>(type: "int", nullable: true),
                    BallonDorID2 = table.Column<int>(type: "int", nullable: true),
                    BallonDorID3 = table.Column<int>(type: "int", nullable: true),
                    BallonDorID4 = table.Column<int>(type: "int", nullable: true),
                    BallonDorID5 = table.Column<int>(type: "int", nullable: true),
                    BallonDorID6 = table.Column<int>(type: "int", nullable: true),
                    BallonDorID7 = table.Column<int>(type: "int", nullable: true),
                    BallonDorID8 = table.Column<int>(type: "int", nullable: true),
                    BallonDorID9 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IconInfo", x => x.IconID);
                    table.ForeignKey(
                        name: "FK_IconInfo_BallonDorInfo_BallonDorID",
                        column: x => x.BallonDorID,
                        principalTable: "BallonDorInfo",
                        principalColumn: "BallonDorID");
                    table.ForeignKey(
                        name: "FK_IconInfo_BallonDorInfo_BallonDorID1",
                        column: x => x.BallonDorID1,
                        principalTable: "BallonDorInfo",
                        principalColumn: "BallonDorID");
                    table.ForeignKey(
                        name: "FK_IconInfo_BallonDorInfo_BallonDorID2",
                        column: x => x.BallonDorID2,
                        principalTable: "BallonDorInfo",
                        principalColumn: "BallonDorID");
                    table.ForeignKey(
                        name: "FK_IconInfo_BallonDorInfo_BallonDorID3",
                        column: x => x.BallonDorID3,
                        principalTable: "BallonDorInfo",
                        principalColumn: "BallonDorID");
                    table.ForeignKey(
                        name: "FK_IconInfo_BallonDorInfo_BallonDorID4",
                        column: x => x.BallonDorID4,
                        principalTable: "BallonDorInfo",
                        principalColumn: "BallonDorID");
                    table.ForeignKey(
                        name: "FK_IconInfo_BallonDorInfo_BallonDorID5",
                        column: x => x.BallonDorID5,
                        principalTable: "BallonDorInfo",
                        principalColumn: "BallonDorID");
                    table.ForeignKey(
                        name: "FK_IconInfo_BallonDorInfo_BallonDorID6",
                        column: x => x.BallonDorID6,
                        principalTable: "BallonDorInfo",
                        principalColumn: "BallonDorID");
                    table.ForeignKey(
                        name: "FK_IconInfo_BallonDorInfo_BallonDorID7",
                        column: x => x.BallonDorID7,
                        principalTable: "BallonDorInfo",
                        principalColumn: "BallonDorID");
                    table.ForeignKey(
                        name: "FK_IconInfo_BallonDorInfo_BallonDorID8",
                        column: x => x.BallonDorID8,
                        principalTable: "BallonDorInfo",
                        principalColumn: "BallonDorID");
                    table.ForeignKey(
                        name: "FK_IconInfo_BallonDorInfo_BallonDorID9",
                        column: x => x.BallonDorID9,
                        principalTable: "BallonDorInfo",
                        principalColumn: "BallonDorID");
                });

            migrationBuilder.CreateTable(
                name: "NationStatsInfo",
                columns: table => new
                {
                    NationStatID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IconID = table.Column<int>(type: "int", nullable: false),
                    NationID = table.Column<int>(type: "int", nullable: false),
                    GamesPlayed = table.Column<int>(type: "int", nullable: false),
                    GoalsScored = table.Column<int>(type: "int", nullable: false),
                    WorldCupGoals = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NationStatsInfo", x => x.NationStatID);
                    table.ForeignKey(
                        name: "FK_NationStatsInfo_IconInfo_IconID",
                        column: x => x.IconID,
                        principalTable: "IconInfo",
                        principalColumn: "IconID",
                        onDelete: ReferentialAction.Cascade);
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
                name: "ContinentalCupInfo",
                columns: table => new
                {
                    ContinentalCupID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Winner = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RunnerUp = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ThirdPlace = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Place = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    CupName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NationPlayerStatsNationStatID = table.Column<int>(type: "int", nullable: true),
                    NationPlayerStatsNationStatID1 = table.Column<int>(type: "int", nullable: true),
                    NationPlayerStatsNationStatID2 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContinentalCupInfo", x => x.ContinentalCupID);
                    table.ForeignKey(
                        name: "FK_ContinentalCupInfo_NationStatsInfo_NationPlayerStatsNationStatID",
                        column: x => x.NationPlayerStatsNationStatID,
                        principalTable: "NationStatsInfo",
                        principalColumn: "NationStatID");
                    table.ForeignKey(
                        name: "FK_ContinentalCupInfo_NationStatsInfo_NationPlayerStatsNationStatID1",
                        column: x => x.NationPlayerStatsNationStatID1,
                        principalTable: "NationStatsInfo",
                        principalColumn: "NationStatID");
                    table.ForeignKey(
                        name: "FK_ContinentalCupInfo_NationStatsInfo_NationPlayerStatsNationStatID2",
                        column: x => x.NationPlayerStatsNationStatID2,
                        principalTable: "NationStatsInfo",
                        principalColumn: "NationStatID");
                });

            migrationBuilder.CreateTable(
                name: "WorldCupInfo",
                columns: table => new
                {
                    WorldCupID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Winner = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RunnerUp = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ThirdPlace = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Place = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    NationPlayerStatsNationStatID = table.Column<int>(type: "int", nullable: true),
                    NationPlayerStatsNationStatID1 = table.Column<int>(type: "int", nullable: true),
                    NationPlayerStatsNationStatID2 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorldCupInfo", x => x.WorldCupID);
                    table.ForeignKey(
                        name: "FK_WorldCupInfo_NationStatsInfo_NationPlayerStatsNationStatID",
                        column: x => x.NationPlayerStatsNationStatID,
                        principalTable: "NationStatsInfo",
                        principalColumn: "NationStatID");
                    table.ForeignKey(
                        name: "FK_WorldCupInfo_NationStatsInfo_NationPlayerStatsNationStatID1",
                        column: x => x.NationPlayerStatsNationStatID1,
                        principalTable: "NationStatsInfo",
                        principalColumn: "NationStatID");
                    table.ForeignKey(
                        name: "FK_WorldCupInfo_NationStatsInfo_NationPlayerStatsNationStatID2",
                        column: x => x.NationPlayerStatsNationStatID2,
                        principalTable: "NationStatsInfo",
                        principalColumn: "NationStatID");
                });

            migrationBuilder.CreateTable(
                name: "ChampionsCupInfo",
                columns: table => new
                {
                    ChampionsCupID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Winner = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RunnerUp = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Place = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    TeamPlayerStatsTeamStatID = table.Column<int>(type: "int", nullable: true),
                    TeamPlayerStatsTeamStatID1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChampionsCupInfo", x => x.ChampionsCupID);
                    table.ForeignKey(
                        name: "FK_ChampionsCupInfo_TeamStatsInfo_TeamPlayerStatsTeamStatID",
                        column: x => x.TeamPlayerStatsTeamStatID,
                        principalTable: "TeamStatsInfo",
                        principalColumn: "TeamStatID");
                    table.ForeignKey(
                        name: "FK_ChampionsCupInfo_TeamStatsInfo_TeamPlayerStatsTeamStatID1",
                        column: x => x.TeamPlayerStatsTeamStatID1,
                        principalTable: "TeamStatsInfo",
                        principalColumn: "TeamStatID");
                });

            migrationBuilder.CreateTable(
                name: "DomesticCupInfo",
                columns: table => new
                {
                    DomesticCupID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Winner = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    TeamPlayerStatsTeamStatID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DomesticCupInfo", x => x.DomesticCupID);
                    table.ForeignKey(
                        name: "FK_DomesticCupInfo_TeamStatsInfo_TeamPlayerStatsTeamStatID",
                        column: x => x.TeamPlayerStatsTeamStatID,
                        principalTable: "TeamStatsInfo",
                        principalColumn: "TeamStatID");
                });

            migrationBuilder.CreateTable(
                name: "DomesticLeagueCupInfo",
                columns: table => new
                {
                    DomesticLeagueID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Winner = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    TeamPlayerStatsTeamStatID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DomesticLeagueCupInfo", x => x.DomesticLeagueID);
                    table.ForeignKey(
                        name: "FK_DomesticLeagueCupInfo_TeamStatsInfo_TeamPlayerStatsTeamStatID",
                        column: x => x.TeamPlayerStatsTeamStatID,
                        principalTable: "TeamStatsInfo",
                        principalColumn: "TeamStatID");
                });

            migrationBuilder.CreateTable(
                name: "DomesticSuperCupInfo",
                columns: table => new
                {
                    DomesticSuperCupID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Winner = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    TeamPlayerStatsTeamStatID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DomesticSuperCupInfo", x => x.DomesticSuperCupID);
                    table.ForeignKey(
                        name: "FK_DomesticSuperCupInfo_TeamStatsInfo_TeamPlayerStatsTeamStatID",
                        column: x => x.TeamPlayerStatsTeamStatID,
                        principalTable: "TeamStatsInfo",
                        principalColumn: "TeamStatID");
                });

            migrationBuilder.CreateTable(
                name: "UEFACupInfo",
                columns: table => new
                {
                    UEFACupID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Winner = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RunnerUp = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Place = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    TeamPlayerStatsTeamStatID = table.Column<int>(type: "int", nullable: true),
                    TeamPlayerStatsTeamStatID1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UEFACupInfo", x => x.UEFACupID);
                    table.ForeignKey(
                        name: "FK_UEFACupInfo_TeamStatsInfo_TeamPlayerStatsTeamStatID",
                        column: x => x.TeamPlayerStatsTeamStatID,
                        principalTable: "TeamStatsInfo",
                        principalColumn: "TeamStatID");
                    table.ForeignKey(
                        name: "FK_UEFACupInfo_TeamStatsInfo_TeamPlayerStatsTeamStatID1",
                        column: x => x.TeamPlayerStatsTeamStatID1,
                        principalTable: "TeamStatsInfo",
                        principalColumn: "TeamStatID");
                });

            migrationBuilder.CreateTable(
                name: "UEFASuperCupInfo",
                columns: table => new
                {
                    UEFASuperCupID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Winner = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RunnerUp = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Place = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    TeamPlayerStatsTeamStatID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UEFASuperCupInfo", x => x.UEFASuperCupID);
                    table.ForeignKey(
                        name: "FK_UEFASuperCupInfo_TeamStatsInfo_TeamPlayerStatsTeamStatID",
                        column: x => x.TeamPlayerStatsTeamStatID,
                        principalTable: "TeamStatsInfo",
                        principalColumn: "TeamStatID");
                });

            migrationBuilder.CreateTable(
                name: "WinnersCupInfo",
                columns: table => new
                {
                    WinnersCupID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Winner = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RunnerUp = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Place = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    TeamPlayerStatsTeamStatID = table.Column<int>(type: "int", nullable: true),
                    TeamPlayerStatsTeamStatID1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WinnersCupInfo", x => x.WinnersCupID);
                    table.ForeignKey(
                        name: "FK_WinnersCupInfo_TeamStatsInfo_TeamPlayerStatsTeamStatID",
                        column: x => x.TeamPlayerStatsTeamStatID,
                        principalTable: "TeamStatsInfo",
                        principalColumn: "TeamStatID");
                    table.ForeignKey(
                        name: "FK_WinnersCupInfo_TeamStatsInfo_TeamPlayerStatsTeamStatID1",
                        column: x => x.TeamPlayerStatsTeamStatID1,
                        principalTable: "TeamStatsInfo",
                        principalColumn: "TeamStatID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_BallonDorInfo_WinnerIconID",
                table: "BallonDorInfo",
                column: "WinnerIconID");

            migrationBuilder.CreateIndex(
                name: "IX_ChampionsCupInfo_TeamPlayerStatsTeamStatID",
                table: "ChampionsCupInfo",
                column: "TeamPlayerStatsTeamStatID");

            migrationBuilder.CreateIndex(
                name: "IX_ChampionsCupInfo_TeamPlayerStatsTeamStatID1",
                table: "ChampionsCupInfo",
                column: "TeamPlayerStatsTeamStatID1");

            migrationBuilder.CreateIndex(
                name: "IX_ContinentalCupInfo_NationPlayerStatsNationStatID",
                table: "ContinentalCupInfo",
                column: "NationPlayerStatsNationStatID");

            migrationBuilder.CreateIndex(
                name: "IX_ContinentalCupInfo_NationPlayerStatsNationStatID1",
                table: "ContinentalCupInfo",
                column: "NationPlayerStatsNationStatID1");

            migrationBuilder.CreateIndex(
                name: "IX_ContinentalCupInfo_NationPlayerStatsNationStatID2",
                table: "ContinentalCupInfo",
                column: "NationPlayerStatsNationStatID2");

            migrationBuilder.CreateIndex(
                name: "IX_DomesticCupInfo_TeamPlayerStatsTeamStatID",
                table: "DomesticCupInfo",
                column: "TeamPlayerStatsTeamStatID");

            migrationBuilder.CreateIndex(
                name: "IX_DomesticLeagueCupInfo_TeamPlayerStatsTeamStatID",
                table: "DomesticLeagueCupInfo",
                column: "TeamPlayerStatsTeamStatID");

            migrationBuilder.CreateIndex(
                name: "IX_DomesticSuperCupInfo_TeamPlayerStatsTeamStatID",
                table: "DomesticSuperCupInfo",
                column: "TeamPlayerStatsTeamStatID");

            migrationBuilder.CreateIndex(
                name: "IX_IconInfo_BallonDorID",
                table: "IconInfo",
                column: "BallonDorID");

            migrationBuilder.CreateIndex(
                name: "IX_IconInfo_BallonDorID1",
                table: "IconInfo",
                column: "BallonDorID1");

            migrationBuilder.CreateIndex(
                name: "IX_IconInfo_BallonDorID2",
                table: "IconInfo",
                column: "BallonDorID2");

            migrationBuilder.CreateIndex(
                name: "IX_IconInfo_BallonDorID3",
                table: "IconInfo",
                column: "BallonDorID3");

            migrationBuilder.CreateIndex(
                name: "IX_IconInfo_BallonDorID4",
                table: "IconInfo",
                column: "BallonDorID4");

            migrationBuilder.CreateIndex(
                name: "IX_IconInfo_BallonDorID5",
                table: "IconInfo",
                column: "BallonDorID5");

            migrationBuilder.CreateIndex(
                name: "IX_IconInfo_BallonDorID6",
                table: "IconInfo",
                column: "BallonDorID6");

            migrationBuilder.CreateIndex(
                name: "IX_IconInfo_BallonDorID7",
                table: "IconInfo",
                column: "BallonDorID7");

            migrationBuilder.CreateIndex(
                name: "IX_IconInfo_BallonDorID8",
                table: "IconInfo",
                column: "BallonDorID8");

            migrationBuilder.CreateIndex(
                name: "IX_IconInfo_BallonDorID9",
                table: "IconInfo",
                column: "BallonDorID9");

            migrationBuilder.CreateIndex(
                name: "IX_NationStatsInfo_IconID",
                table: "NationStatsInfo",
                column: "IconID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TeamStatsInfo_IconID",
                table: "TeamStatsInfo",
                column: "IconID");

            migrationBuilder.CreateIndex(
                name: "IX_TeamStatsInfo_TeamID",
                table: "TeamStatsInfo",
                column: "TeamID");

            migrationBuilder.CreateIndex(
                name: "IX_UEFACupInfo_TeamPlayerStatsTeamStatID",
                table: "UEFACupInfo",
                column: "TeamPlayerStatsTeamStatID");

            migrationBuilder.CreateIndex(
                name: "IX_UEFACupInfo_TeamPlayerStatsTeamStatID1",
                table: "UEFACupInfo",
                column: "TeamPlayerStatsTeamStatID1");

            migrationBuilder.CreateIndex(
                name: "IX_UEFASuperCupInfo_TeamPlayerStatsTeamStatID",
                table: "UEFASuperCupInfo",
                column: "TeamPlayerStatsTeamStatID");

            migrationBuilder.CreateIndex(
                name: "IX_WinnersCupInfo_TeamPlayerStatsTeamStatID",
                table: "WinnersCupInfo",
                column: "TeamPlayerStatsTeamStatID");

            migrationBuilder.CreateIndex(
                name: "IX_WinnersCupInfo_TeamPlayerStatsTeamStatID1",
                table: "WinnersCupInfo",
                column: "TeamPlayerStatsTeamStatID1");

            migrationBuilder.CreateIndex(
                name: "IX_WorldCupInfo_NationPlayerStatsNationStatID",
                table: "WorldCupInfo",
                column: "NationPlayerStatsNationStatID");

            migrationBuilder.CreateIndex(
                name: "IX_WorldCupInfo_NationPlayerStatsNationStatID1",
                table: "WorldCupInfo",
                column: "NationPlayerStatsNationStatID1");

            migrationBuilder.CreateIndex(
                name: "IX_WorldCupInfo_NationPlayerStatsNationStatID2",
                table: "WorldCupInfo",
                column: "NationPlayerStatsNationStatID2");

            migrationBuilder.AddForeignKey(
                name: "FK_BallonDorInfo_IconInfo_WinnerIconID",
                table: "BallonDorInfo",
                column: "WinnerIconID",
                principalTable: "IconInfo",
                principalColumn: "IconID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BallonDorInfo_IconInfo_WinnerIconID",
                table: "BallonDorInfo");

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
                name: "NationInfo");

            migrationBuilder.DropTable(
                name: "UEFACupInfo");

            migrationBuilder.DropTable(
                name: "UEFASuperCupInfo");

            migrationBuilder.DropTable(
                name: "WinnersCupInfo");

            migrationBuilder.DropTable(
                name: "WorldCupInfo");

            migrationBuilder.DropTable(
                name: "TeamStatsInfo");

            migrationBuilder.DropTable(
                name: "NationStatsInfo");

            migrationBuilder.DropTable(
                name: "TeamInfo");

            migrationBuilder.DropTable(
                name: "IconInfo");

            migrationBuilder.DropTable(
                name: "BallonDorInfo");
        }
    }
}
