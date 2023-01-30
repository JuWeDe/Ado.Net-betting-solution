using System.ComponentModel.DataAnnotations;

namespace Betting.Data.Models;

public class Positions
{
    [Key] public int PositionId { get; set; }
    [MaxLength(32)] public string Name { get; set; }
    public virtual ICollection<Players> Players { get; set; }
}