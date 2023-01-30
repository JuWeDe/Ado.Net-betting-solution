﻿// <auto-generated />
using System;
using Betting.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Betting.Data.Migrations
{
    [DbContext(typeof(BettingContext))]
    partial class BettingContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Betting.Data.Models.Bets", b =>
                {
                    b.Property<int>("BetId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BetId"), 1L, 1);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("GameId")
                        .HasColumnType("int");

                    b.Property<int>("Prediction")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("BetId");

                    b.HasIndex("GameId");

                    b.HasIndex("UserId");

                    b.ToTable("Bets");
                });

            modelBuilder.Entity("Betting.Data.Models.Colors", b =>
                {
                    b.Property<int>("ColorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ColorId"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.HasKey("ColorId");

                    b.ToTable("Colors");
                });

            modelBuilder.Entity("Betting.Data.Models.Countries", b =>
                {
                    b.Property<int>("CountryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CountryID"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.HasKey("CountryID");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("Betting.Data.Models.Games", b =>
                {
                    b.Property<int>("GameId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GameId"), 1L, 1);

                    b.Property<double>("AwayTeamBetRate")
                        .HasColumnType("float");

                    b.Property<int>("AwayTeamGoals")
                        .HasColumnType("int");

                    b.Property<int>("AwayTeamId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<double>("DrawBetRate")
                        .HasColumnType("float");

                    b.Property<double>("HomeTeamBetRate")
                        .HasColumnType("float");

                    b.Property<int>("HomeTeamGoals")
                        .HasColumnType("int");

                    b.Property<int>("HomeTeamId")
                        .HasColumnType("int");

                    b.Property<string>("Result")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GameId");

                    b.HasIndex("AwayTeamId");

                    b.HasIndex("HomeTeamId");

                    b.ToTable("Games");
                });

            modelBuilder.Entity("Betting.Data.Models.Players", b =>
                {
                    b.Property<int>("PlayerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PlayerId"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.Property<int>("PositionId")
                        .HasColumnType("int");

                    b.Property<int>("SquadNumber")
                        .HasColumnType("int");

                    b.Property<int>("TeamId")
                        .HasColumnType("int");

                    b.Property<bool>("isInjured")
                        .HasColumnType("bit");

                    b.HasKey("PlayerId");

                    b.HasIndex("PositionId");

                    b.HasIndex("TeamId");

                    b.ToTable("Players");
                });

            modelBuilder.Entity("Betting.Data.Models.PlayerStatistics", b =>
                {
                    b.Property<int>("PlayerId")
                        .HasColumnType("int");

                    b.Property<int>("GameId")
                        .HasColumnType("int");

                    b.Property<int>("Assists")
                        .HasColumnType("int");

                    b.Property<int>("MinutesPlayed")
                        .HasColumnType("int");

                    b.Property<int>("ScoredGoals")
                        .HasColumnType("int");

                    b.HasKey("PlayerId", "GameId");

                    b.HasIndex("GameId");

                    b.ToTable("PlayerStatistics");
                });

            modelBuilder.Entity("Betting.Data.Models.Positions", b =>
                {
                    b.Property<int>("PositionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PositionId"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("nvarchar(32)");

                    b.HasKey("PositionId");

                    b.ToTable("Positions");
                });

            modelBuilder.Entity("Betting.Data.Models.Teams", b =>
                {
                    b.Property<int>("TeamId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TeamId"), 1L, 1);

                    b.Property<decimal>("Budget")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Initials")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LogoUrl")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<int>("PrimaryKitColorId")
                        .HasColumnType("int");

                    b.Property<int>("SecondaryKitColorId")
                        .HasColumnType("int");

                    b.Property<int>("TownId")
                        .HasColumnType("int");

                    b.HasKey("TeamId");

                    b.HasIndex("PrimaryKitColorId");

                    b.HasIndex("SecondaryKitColorId");

                    b.HasIndex("TownId");

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("Betting.Data.Models.Towns", b =>
                {
                    b.Property<int>("TownId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TownId"), 1L, 1);

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.HasKey("TownId");

                    b.HasIndex("CountryId");

                    b.ToTable("Towns");
                });

            modelBuilder.Entity("Betting.Data.Models.Users", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"), 1L, 1);

                    b.Property<double>("Balance")
                        .HasColumnType("float");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Betting.Data.Models.Bets", b =>
                {
                    b.HasOne("Betting.Data.Models.Games", "Games")
                        .WithMany("Bets")
                        .HasForeignKey("GameId")
                        .IsRequired()
                        .HasConstraintName("FK_Bets_Games");

                    b.HasOne("Betting.Data.Models.Users", "Users")
                        .WithMany("Bets")
                        .HasForeignKey("UserId")
                        .IsRequired()
                        .HasConstraintName("FK_Bets_Users");

                    b.Navigation("Games");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("Betting.Data.Models.Games", b =>
                {
                    b.HasOne("Betting.Data.Models.Teams", "AwayTeams")
                        .WithMany("AwayGames")
                        .HasForeignKey("AwayTeamId")
                        .IsRequired()
                        .HasConstraintName("FK_Games_AwayTeams");

                    b.HasOne("Betting.Data.Models.Teams", "HomeTeams")
                        .WithMany("HomeGames")
                        .HasForeignKey("HomeTeamId")
                        .IsRequired()
                        .HasConstraintName("FK_Games_HomeTeams");

                    b.Navigation("AwayTeams");

                    b.Navigation("HomeTeams");
                });

            modelBuilder.Entity("Betting.Data.Models.Players", b =>
                {
                    b.HasOne("Betting.Data.Models.Positions", "Positions")
                        .WithMany("Players")
                        .HasForeignKey("PositionId")
                        .IsRequired()
                        .HasConstraintName("FK_Players_Positions");

                    b.HasOne("Betting.Data.Models.Teams", "Teams")
                        .WithMany("Players")
                        .HasForeignKey("TeamId")
                        .IsRequired()
                        .HasConstraintName("FK_Players_Teams");

                    b.Navigation("Positions");

                    b.Navigation("Teams");
                });

            modelBuilder.Entity("Betting.Data.Models.PlayerStatistics", b =>
                {
                    b.HasOne("Betting.Data.Models.Games", "Games")
                        .WithMany("PlayerStatistics")
                        .HasForeignKey("GameId")
                        .IsRequired()
                        .HasConstraintName("FK_PlayerStatistics_Games");

                    b.HasOne("Betting.Data.Models.Players", "Players")
                        .WithMany("PlayerStatistics")
                        .HasForeignKey("PlayerId")
                        .IsRequired()
                        .HasConstraintName("FK_PlayerStatistics_Players");

                    b.Navigation("Games");

                    b.Navigation("Players");
                });

            modelBuilder.Entity("Betting.Data.Models.Teams", b =>
                {
                    b.HasOne("Betting.Data.Models.Colors", "PrimaryKitColors")
                        .WithMany("PrimaryKitColorId")
                        .HasForeignKey("PrimaryKitColorId")
                        .IsRequired()
                        .HasConstraintName("FK_Teams_PrimaryKitTeams");

                    b.HasOne("Betting.Data.Models.Colors", "SecondaryKitColors")
                        .WithMany("SecondaryKitColorId")
                        .HasForeignKey("SecondaryKitColorId")
                        .IsRequired()
                        .HasConstraintName("FK_Teams_SecondaryTeams");

                    b.HasOne("Betting.Data.Models.Towns", "Towns")
                        .WithMany("Teams")
                        .HasForeignKey("TownId")
                        .IsRequired()
                        .HasConstraintName("FK_Teams_Towns");

                    b.Navigation("PrimaryKitColors");

                    b.Navigation("SecondaryKitColors");

                    b.Navigation("Towns");
                });

            modelBuilder.Entity("Betting.Data.Models.Towns", b =>
                {
                    b.HasOne("Betting.Data.Models.Countries", "Countries")
                        .WithMany("Towns")
                        .HasForeignKey("CountryId")
                        .IsRequired()
                        .HasConstraintName("FK_Towns_Countries");

                    b.Navigation("Countries");
                });

            modelBuilder.Entity("Betting.Data.Models.Colors", b =>
                {
                    b.Navigation("PrimaryKitColorId");

                    b.Navigation("SecondaryKitColorId");
                });

            modelBuilder.Entity("Betting.Data.Models.Countries", b =>
                {
                    b.Navigation("Towns");
                });

            modelBuilder.Entity("Betting.Data.Models.Games", b =>
                {
                    b.Navigation("Bets");

                    b.Navigation("PlayerStatistics");
                });

            modelBuilder.Entity("Betting.Data.Models.Players", b =>
                {
                    b.Navigation("PlayerStatistics");
                });

            modelBuilder.Entity("Betting.Data.Models.Positions", b =>
                {
                    b.Navigation("Players");
                });

            modelBuilder.Entity("Betting.Data.Models.Teams", b =>
                {
                    b.Navigation("AwayGames");

                    b.Navigation("HomeGames");

                    b.Navigation("Players");
                });

            modelBuilder.Entity("Betting.Data.Models.Towns", b =>
                {
                    b.Navigation("Teams");
                });

            modelBuilder.Entity("Betting.Data.Models.Users", b =>
                {
                    b.Navigation("Bets");
                });
#pragma warning restore 612, 618
        }
    }
}
