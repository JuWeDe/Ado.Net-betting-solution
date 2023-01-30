using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Betting.Data.Models;

public class Players
{
    [Key] public int PlayerId { get; set; }
    public bool isInjured { get; set; }
    [MaxLength(64)] public string Name { get; set; }
    [ForeignKey("PositionId")] public int PositionId { get; set; }
    public virtual Positions Positions { get; set; }
    public int SquadNumber { get; set; }
    [ForeignKey("TeamId")] public int TeamId { get; set; }
    public virtual Teams Teams { get; set; }
    public virtual ICollection<PlayerStatistics> PlayerStatistics { get; set; }
}