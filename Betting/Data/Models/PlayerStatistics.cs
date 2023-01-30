using System.ComponentModel.DataAnnotations.Schema;

namespace Betting.Data.Models;

public class PlayerStatistics
{
    [ForeignKey("PlayerId")] public int PlayerId { get; set; }
    public virtual Players Players { get; set; }
    [ForeignKey("GameId")] public int GameId { get; set; }
    public virtual Games Games { get; set; }
    public int Assists { get; set; }
    public int MinutesPlayed { get; set; }
    public int ScoredGoals { get; set; }
}