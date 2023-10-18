﻿// <auto-generated />
using System;
using FootballIconsCAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FootballIconsCAPI.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20231018122351_init2")]
    partial class init2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FootballIconsCAPI.Entities.BallonDor", b =>
                {
                    b.Property<int>("BallonDorID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BallonDorID"));

                    b.Property<int>("EigthPlace")
                        .HasColumnType("int");

                    b.Property<int>("Fifthlace")
                        .HasColumnType("int");

                    b.Property<int>("FourthPlace")
                        .HasColumnType("int");

                    b.Property<int>("NinethPlace")
                        .HasColumnType("int");

                    b.Property<int>("RunnerUp")
                        .HasColumnType("int");

                    b.Property<int>("SeventhPlace")
                        .HasColumnType("int");

                    b.Property<int>("SixthPlace")
                        .HasColumnType("int");

                    b.Property<int>("TenthPlace")
                        .HasColumnType("int");

                    b.Property<int>("ThirdPlace")
                        .HasColumnType("int");

                    b.Property<int>("Winner")
                        .HasColumnType("int");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("BallonDorID");

                    b.ToTable("BallonDorInfo");
                });

            modelBuilder.Entity("FootballIconsCAPI.Entities.ChampionsCup", b =>
                {
                    b.Property<int>("ChampionsCupID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ChampionsCupID"));

                    b.Property<string>("Place")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RunnerUp")
                        .HasColumnType("int");

                    b.Property<int?>("TeamID")
                        .HasColumnType("int");

                    b.Property<int?>("TeamID1")
                        .HasColumnType("int");

                    b.Property<int>("Winner")
                        .HasColumnType("int");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("ChampionsCupID");

                    b.HasIndex("TeamID");

                    b.HasIndex("TeamID1");

                    b.ToTable("ChampionsCupInfo");
                });

            modelBuilder.Entity("FootballIconsCAPI.Entities.ContinentalCup", b =>
                {
                    b.Property<int>("ContinentalCupID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ContinentalCupID"));

                    b.Property<string>("CupName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("NationID")
                        .HasColumnType("int");

                    b.Property<int?>("NationID1")
                        .HasColumnType("int");

                    b.Property<int?>("NationID2")
                        .HasColumnType("int");

                    b.Property<string>("Place")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RunnerUp")
                        .HasColumnType("int");

                    b.Property<int>("ThirdPlace")
                        .HasColumnType("int");

                    b.Property<int>("Winner")
                        .HasColumnType("int");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("ContinentalCupID");

                    b.HasIndex("NationID");

                    b.HasIndex("NationID1");

                    b.HasIndex("NationID2");

                    b.ToTable("ContinentalCupInfo");
                });

            modelBuilder.Entity("FootballIconsCAPI.Entities.DomesticCup", b =>
                {
                    b.Property<int>("DomesticCupID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DomesticCupID"));

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TeamID")
                        .HasColumnType("int");

                    b.Property<int>("Winner")
                        .HasColumnType("int");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("DomesticCupID");

                    b.HasIndex("TeamID");

                    b.ToTable("DomesticCupInfo");
                });

            modelBuilder.Entity("FootballIconsCAPI.Entities.DomesticLeague", b =>
                {
                    b.Property<int>("DomesticLeagueID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DomesticLeagueID"));

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TeamID")
                        .HasColumnType("int");

                    b.Property<int>("Winner")
                        .HasColumnType("int");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("DomesticLeagueID");

                    b.HasIndex("TeamID");

                    b.ToTable("DomesticLeagueCupInfo");
                });

            modelBuilder.Entity("FootballIconsCAPI.Entities.DomesticSuperCup", b =>
                {
                    b.Property<int>("DomesticSuperCupID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DomesticSuperCupID"));

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TeamID")
                        .HasColumnType("int");

                    b.Property<int>("Winner")
                        .HasColumnType("int");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("DomesticSuperCupID");

                    b.HasIndex("TeamID");

                    b.ToTable("DomesticSuperCupInfo");
                });

            modelBuilder.Entity("FootballIconsCAPI.Entities.Icon", b =>
                {
                    b.Property<int>("IconID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IconID"));

                    b.Property<int>("CareerGames")
                        .HasColumnType("int");

                    b.Property<int>("CareerGoals")
                        .HasColumnType("int");

                    b.Property<int>("CareerLength")
                        .HasColumnType("int");

                    b.Property<DateTime>("DoB")
                        .HasColumnType("datetime2");

                    b.Property<int>("Fantascore")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IconID");

                    b.ToTable("IconInfo");
                });

            modelBuilder.Entity("FootballIconsCAPI.Entities.Nation", b =>
                {
                    b.Property<int>("NationID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("NationID"));

                    b.Property<string>("Confederation")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("NationName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Name");

                    b.HasKey("NationID");

                    b.ToTable("NationInfo");
                });

            modelBuilder.Entity("FootballIconsCAPI.Entities.NationPlayerStats", b =>
                {
                    b.Property<int>("ID")
                        .HasColumnType("int");

                    b.Property<int>("GamesPlayed")
                        .HasColumnType("int");

                    b.Property<int>("GoalsScored")
                        .HasColumnType("int");

                    b.Property<int>("NationID")
                        .HasColumnType("int");

                    b.Property<int>("WorldCupGoals")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("NationID");

                    b.ToTable("NationStatsInfo");
                });

            modelBuilder.Entity("FootballIconsCAPI.Entities.Nominations", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("BallonDorID")
                        .HasColumnType("int");

                    b.Property<int>("Nomination")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("BallonDorID");

                    b.ToTable("Nominations");
                });

            modelBuilder.Entity("FootballIconsCAPI.Entities.Team", b =>
                {
                    b.Property<int>("TeamID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TeamID"));

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("TeamName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Name");

                    b.HasKey("TeamID");

                    b.ToTable("TeamInfo");
                });

            modelBuilder.Entity("FootballIconsCAPI.Entities.TeamPlayerStats", b =>
                {
                    b.Property<int>("TeamStatID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TeamStatID"));

                    b.Property<int>("GamesPlayed")
                        .HasColumnType("int");

                    b.Property<int>("GoalsScored")
                        .HasColumnType("int");

                    b.Property<int>("IconID")
                        .HasColumnType("int");

                    b.Property<int>("TeamID")
                        .HasColumnType("int");

                    b.HasKey("TeamStatID");

                    b.HasIndex("IconID");

                    b.HasIndex("TeamID");

                    b.ToTable("TeamStatsInfo");
                });

            modelBuilder.Entity("FootballIconsCAPI.Entities.UEFACup", b =>
                {
                    b.Property<int>("UEFACupID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UEFACupID"));

                    b.Property<string>("Place")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RunnerUp")
                        .HasColumnType("int");

                    b.Property<int?>("TeamID")
                        .HasColumnType("int");

                    b.Property<int?>("TeamID1")
                        .HasColumnType("int");

                    b.Property<int>("Winner")
                        .HasColumnType("int");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("UEFACupID");

                    b.HasIndex("TeamID");

                    b.HasIndex("TeamID1");

                    b.ToTable("UEFACupInfo");
                });

            modelBuilder.Entity("FootballIconsCAPI.Entities.UEFASuperCup", b =>
                {
                    b.Property<int>("UEFASuperCupID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UEFASuperCupID"));

                    b.Property<string>("Place")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TeamID")
                        .HasColumnType("int");

                    b.Property<int>("Winner")
                        .HasColumnType("int");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("UEFASuperCupID");

                    b.HasIndex("TeamID");

                    b.ToTable("UEFASuperCupInfo");
                });

            modelBuilder.Entity("FootballIconsCAPI.Entities.WinnersCup", b =>
                {
                    b.Property<int>("WinnersCupID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("WinnersCupID"));

                    b.Property<string>("Place")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RunnerUp")
                        .HasColumnType("int");

                    b.Property<int?>("TeamID")
                        .HasColumnType("int");

                    b.Property<int?>("TeamID1")
                        .HasColumnType("int");

                    b.Property<int>("Winner")
                        .HasColumnType("int");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("WinnersCupID");

                    b.HasIndex("TeamID");

                    b.HasIndex("TeamID1");

                    b.ToTable("WinnersCupInfo");
                });

            modelBuilder.Entity("FootballIconsCAPI.Entities.WorldCup", b =>
                {
                    b.Property<int>("WorldCupID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("WorldCupID"));

                    b.Property<int?>("NationID")
                        .HasColumnType("int");

                    b.Property<int?>("NationID1")
                        .HasColumnType("int");

                    b.Property<int?>("NationID2")
                        .HasColumnType("int");

                    b.Property<string>("Place")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RunnerUp")
                        .HasColumnType("int");

                    b.Property<int>("ThirdPlace")
                        .HasColumnType("int");

                    b.Property<int>("Winner")
                        .HasColumnType("int");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("WorldCupID");

                    b.HasIndex("NationID");

                    b.HasIndex("NationID1");

                    b.HasIndex("NationID2");

                    b.ToTable("WorldCupInfo");
                });

            modelBuilder.Entity("FootballIconsCAPI.Entities.ChampionsCup", b =>
                {
                    b.HasOne("FootballIconsCAPI.Entities.Team", null)
                        .WithMany("ChampionsCupRunnerUp")
                        .HasForeignKey("TeamID");

                    b.HasOne("FootballIconsCAPI.Entities.Team", null)
                        .WithMany("ChampionsCupWinner")
                        .HasForeignKey("TeamID1");
                });

            modelBuilder.Entity("FootballIconsCAPI.Entities.ContinentalCup", b =>
                {
                    b.HasOne("FootballIconsCAPI.Entities.Nation", null)
                        .WithMany("ContinentalCups")
                        .HasForeignKey("NationID");

                    b.HasOne("FootballIconsCAPI.Entities.Nation", null)
                        .WithMany("ContinentalCupsRunnerUps")
                        .HasForeignKey("NationID1");

                    b.HasOne("FootballIconsCAPI.Entities.Nation", null)
                        .WithMany("ContinentalCupsThirdPlace")
                        .HasForeignKey("NationID2");
                });

            modelBuilder.Entity("FootballIconsCAPI.Entities.DomesticCup", b =>
                {
                    b.HasOne("FootballIconsCAPI.Entities.Team", null)
                        .WithMany("DomesticCups")
                        .HasForeignKey("TeamID");
                });

            modelBuilder.Entity("FootballIconsCAPI.Entities.DomesticLeague", b =>
                {
                    b.HasOne("FootballIconsCAPI.Entities.Team", null)
                        .WithMany("DomestiLeagues")
                        .HasForeignKey("TeamID");
                });

            modelBuilder.Entity("FootballIconsCAPI.Entities.DomesticSuperCup", b =>
                {
                    b.HasOne("FootballIconsCAPI.Entities.Team", null)
                        .WithMany("DomesticSuperCups")
                        .HasForeignKey("TeamID");
                });

            modelBuilder.Entity("FootballIconsCAPI.Entities.NationPlayerStats", b =>
                {
                    b.HasOne("FootballIconsCAPI.Entities.Icon", "Icon")
                        .WithOne("NationStats")
                        .HasForeignKey("FootballIconsCAPI.Entities.NationPlayerStats", "ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FootballIconsCAPI.Entities.Nation", "Nation")
                        .WithMany()
                        .HasForeignKey("NationID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Icon");

                    b.Navigation("Nation");
                });

            modelBuilder.Entity("FootballIconsCAPI.Entities.Nominations", b =>
                {
                    b.HasOne("FootballIconsCAPI.Entities.BallonDor", null)
                        .WithMany("Nominations")
                        .HasForeignKey("BallonDorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FootballIconsCAPI.Entities.TeamPlayerStats", b =>
                {
                    b.HasOne("FootballIconsCAPI.Entities.Icon", "Icon")
                        .WithMany("TeamStats")
                        .HasForeignKey("IconID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FootballIconsCAPI.Entities.Team", "Team")
                        .WithMany()
                        .HasForeignKey("TeamID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Icon");

                    b.Navigation("Team");
                });

            modelBuilder.Entity("FootballIconsCAPI.Entities.UEFACup", b =>
                {
                    b.HasOne("FootballIconsCAPI.Entities.Team", null)
                        .WithMany("UEFACups")
                        .HasForeignKey("TeamID");

                    b.HasOne("FootballIconsCAPI.Entities.Team", null)
                        .WithMany("UEFACupsRunnerUps")
                        .HasForeignKey("TeamID1");
                });

            modelBuilder.Entity("FootballIconsCAPI.Entities.UEFASuperCup", b =>
                {
                    b.HasOne("FootballIconsCAPI.Entities.Team", null)
                        .WithMany("UEFASuperCups")
                        .HasForeignKey("TeamID");
                });

            modelBuilder.Entity("FootballIconsCAPI.Entities.WinnersCup", b =>
                {
                    b.HasOne("FootballIconsCAPI.Entities.Team", null)
                        .WithMany("WinnerCupsRunnerUps")
                        .HasForeignKey("TeamID");

                    b.HasOne("FootballIconsCAPI.Entities.Team", null)
                        .WithMany("WinnersCups")
                        .HasForeignKey("TeamID1");
                });

            modelBuilder.Entity("FootballIconsCAPI.Entities.WorldCup", b =>
                {
                    b.HasOne("FootballIconsCAPI.Entities.Nation", null)
                        .WithMany("WorldCupThirdPlace")
                        .HasForeignKey("NationID");

                    b.HasOne("FootballIconsCAPI.Entities.Nation", null)
                        .WithMany("WorldCups")
                        .HasForeignKey("NationID1");

                    b.HasOne("FootballIconsCAPI.Entities.Nation", null)
                        .WithMany("WorldCupsRunnerUps")
                        .HasForeignKey("NationID2");
                });

            modelBuilder.Entity("FootballIconsCAPI.Entities.BallonDor", b =>
                {
                    b.Navigation("Nominations");
                });

            modelBuilder.Entity("FootballIconsCAPI.Entities.Icon", b =>
                {
                    b.Navigation("NationStats")
                        .IsRequired();

                    b.Navigation("TeamStats");
                });

            modelBuilder.Entity("FootballIconsCAPI.Entities.Nation", b =>
                {
                    b.Navigation("ContinentalCups");

                    b.Navigation("ContinentalCupsRunnerUps");

                    b.Navigation("ContinentalCupsThirdPlace");

                    b.Navigation("WorldCupThirdPlace");

                    b.Navigation("WorldCups");

                    b.Navigation("WorldCupsRunnerUps");
                });

            modelBuilder.Entity("FootballIconsCAPI.Entities.Team", b =>
                {
                    b.Navigation("ChampionsCupRunnerUp");

                    b.Navigation("ChampionsCupWinner");

                    b.Navigation("DomestiLeagues");

                    b.Navigation("DomesticCups");

                    b.Navigation("DomesticSuperCups");

                    b.Navigation("UEFACups");

                    b.Navigation("UEFACupsRunnerUps");

                    b.Navigation("UEFASuperCups");

                    b.Navigation("WinnerCupsRunnerUps");

                    b.Navigation("WinnersCups");
                });
#pragma warning restore 612, 618
        }
    }
}
