using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Betting.Data.Models;

public class Games
{
    [Key] public int GameId { get; set; }
    public double AwayTeamBetRate { get; set; }
    public int AwayTeamGoals { get; set; }
    [ForeignKey("AwayTeamId")] public int AwayTeamId { get; set; }
    public virtual Teams AwayTeams { get; set; }
    public double DrawBetRate { get; set; }
    public double HomeTeamBetRate { get; set; }
    public int HomeTeamGoals { get; set; }
    [ForeignKey("HomeTeamId")] public int HomeTeamId { get; set; }
    public virtual Teams HomeTeams { get; set; }
    public string Result { get; set; }
    public DateTime DateTime { get; set; }

    public virtual ICollection<PlayerStatistics> PlayerStatistics { get; set; }
    public virtual ICollection<Bets> Bets { get; set; }
}