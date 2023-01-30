using Betting.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Betting.Data;

public class BettingContext : DbContext
{
    public BettingContext()
    {
    }

    public BettingContext(DbContextOptions options) :
        base(options)
    {
    }

    public virtual DbSet<Bets> Bets { get; set; }
    public virtual DbSet<Colors> Colors { get; set; }
    public virtual DbSet<Countries> Countries { get; set; }
    public virtual DbSet<Games> Games { get; set; }
    public virtual DbSet<Players> Players { get; set; }
    public virtual DbSet<PlayerStatistics> PlayerStatistics { get; set; }
    public virtual DbSet<Positions> Positions { get; set; }
    public virtual DbSet<Teams> Teams { get; set; }
    public virtual DbSet<Towns> Towns { get; set; }
    public virtual DbSet<Users> Users { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer(@"Server=.;Database=Betting;Integrated Security=True;");
        }

        base.OnConfiguring(optionsBuilder);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Bets>(entity =>
        {
            entity.HasKey(b => b.BetId);
            entity.Property(b => b.BetId);
            entity.Property(b => b.Amount);
            entity.Property(b => b.GameId);
            entity.HasOne(d => d.Games)
                .WithMany(p => p.Bets)
                .HasForeignKey(d => d.GameId)
                .HasConstraintName("Bets_Games_Link")
                .OnDelete(DeleteBehavior.ClientSetNull);
            entity.Property(b => b.Prediction);
            entity.Property(b => b.DateTime);
            entity.Property(b => b.UserId);
            entity.HasOne(d => d.Users)
                .WithMany(p => p.Bets)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("Bets_Users_Link")
                .OnDelete(DeleteBehavior.ClientSetNull);
        });
        modelBuilder.Entity<Colors>(entity =>
        {
            entity.HasKey(c => c.ColorId);
            entity.Property(c => c.ColorId);
            entity.Property(c => c.Name)
                .HasMaxLength(64);
            entity.HasMany(d => d.PrimaryKitColorId)
                .WithOne(k => k.PrimaryKitColors);

            entity.HasMany(d => d.SecondaryKitColorId)
                .WithOne(k => k.SecondaryKitColors);
        });
        modelBuilder.Entity<Countries>(entity =>
        {
            entity.HasKey(c => c.CountryID);
            entity.Property(c => c.Name)
                .HasMaxLength(64);
        });
        modelBuilder.Entity<Games>(entity =>
        {
            entity.HasKey(g => g.GameId);
            entity.Property(g => g.GameId);
            entity.Property(g => g.AwayTeamBetRate);
            entity.Property(g => g.AwayTeamGoals);
            entity.Property(g => g.AwayTeamId);
            entity.HasOne(d => d.AwayTeams)
                .WithMany(p => p.AwayGames)
                .HasForeignKey(d => d.AwayTeamId)
                .HasConstraintName("Games_AwayTeams_Link")
                .OnDelete(DeleteBehavior.ClientSetNull);
            entity.Property(g => g.DrawBetRate);
            entity.Property(g => g.HomeTeamBetRate);
            entity.Property(g => g.HomeTeamGoals);
            entity.Property(g => g.HomeTeamId);
            entity.HasOne(d => d.HomeTeams)
                .WithMany(p => p.HomeGames)
                .HasForeignKey(d => d.HomeTeamId)
                .HasConstraintName("Games_HomeTeams_Link")
                .OnDelete(DeleteBehavior.ClientSetNull);
            entity.Property(g => g.Result);
            entity.Property(g => g.DateTime);
        });

        modelBuilder.Entity<Players>(entity =>
        {
            entity.HasKey(p => p.PlayerId);
            entity.Property(p => p.PlayerId);
            entity.Property(p => p.isInjured);
            entity.Property(p => p.Name)
                .HasMaxLength(64);
            entity.Property(p => p.PositionId);
            entity.HasOne(d => d.Positions)
                .WithMany(k => k.Players)
                .HasForeignKey(d => d.PositionId)
                .HasConstraintName("Players_Positions_Link")
                .OnDelete(DeleteBehavior.ClientSetNull);
            entity.Property(p => p.SquadNumber);
            entity.Property(p => p.TeamId);
            entity.HasOne(d => d.Teams)
                .WithMany(k => k.Players)
                .HasForeignKey(d => d.TeamId)
                .HasConstraintName("Players_Teams_Link")
                .OnDelete(DeleteBehavior.ClientSetNull);
        });
        modelBuilder.Entity<PlayerStatistics>(entity =>
        {
            entity.HasKey(ps => new { ps.PlayerId, ps.GameId });
            entity.Property(ps => ps.PlayerId);
            entity.HasOne(d => d.Players)
                .WithMany(p => p.PlayerStatistics)
                .HasForeignKey(d => d.PlayerId)
                .HasConstraintName("PlayerStatistics_Players_Link")
                .OnDelete(DeleteBehavior.ClientSetNull);
            entity.Property(ps => ps.GameId);
            entity.HasOne(d => d.Games)
                .WithMany(p => p.PlayerStatistics)
                .HasForeignKey(d => d.GameId)
                .HasConstraintName("PlayerStatistics_Games_Link")
                .OnDelete(DeleteBehavior.ClientSetNull);
            entity.Property(ps => ps.Assists);
            entity.Property(ps => ps.MinutesPlayed);
            entity.Property(ps => ps.ScoredGoals);
        });
        modelBuilder.Entity<Positions>(entity =>
        {
            entity.HasKey(pos => pos.PositionId);
            entity.Property(pos => pos.PositionId);
            entity.Property(pos => pos.Name)
                .HasMaxLength(32);
        });


        modelBuilder.Entity<Teams>(entity =>
        {
            entity.HasKey(t => t.TeamId);
            entity.Property(t => t.TeamId);
            entity.Property(t => t.Budget);
            entity.Property(t => t.Initials);
            entity.Property(t => t.LogoUrl)
                .HasMaxLength(150);
            entity.Property(t => t.Name)
                .HasMaxLength(128);
            entity.Property(t => t.PrimaryKitColorId);
            entity.HasOne(d => d.PrimaryKitColors)
                .WithMany(k => k.PrimaryKitColorId)
                .HasForeignKey(d => d.PrimaryKitColorId)
                .HasConstraintName("Teams_PrimaryKitTeams_Link")
                .OnDelete(DeleteBehavior.ClientSetNull);
            entity.Property(t => t.SecondaryKitColorId);
            entity.HasOne(d => d.SecondaryKitColors)
                .WithMany(k => k.SecondaryKitColorId)
                .HasForeignKey(d => d.SecondaryKitColorId)
                .HasConstraintName("Teams_SecondaryTeams_Link")
                .OnDelete(DeleteBehavior.ClientSetNull);
            entity.Property(t => t.TownId);
            entity.HasOne(d => d.Towns)
                .WithMany(k => k.Teams)
                .HasForeignKey(d => d.TownId)
                .HasConstraintName("Teams_Towns_Link")
                .OnDelete(DeleteBehavior.ClientSetNull);
            entity.HasMany(d => d.Players)
                .WithOne(k => k.Teams);
        });
        modelBuilder.Entity<Towns>(entity =>
        {
            entity.HasKey(t => t.TownId);
            entity.Property(t => t.TownId);
            entity.Property(t => t.CountryId);
            entity.HasOne(d => d.Countries)
                .WithMany(k => k.Towns)
                .HasForeignKey(d => d.CountryId)
                .HasConstraintName("Towns_Countries_Link")
                .OnDelete(DeleteBehavior.ClientSetNull);
            entity.Property(t => t.Name)
                .HasMaxLength(64);
        });
        modelBuilder.Entity<Users>(entity =>
        {
            entity.HasKey(u => u.UserId);
            entity.Property(u => u.UserId);
            entity.Property(u => u.Balance);
            entity.Property(u => u.Email)
                .HasMaxLength(64);
            entity.Property(u => u.Name)
                .HasMaxLength(128);
            entity.Property(u => u.Password);
            entity.Property(u => u.Username)
                .HasMaxLength(128);
        });
    }
}