using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Betting.Data.Models;

public class Teams
{
    [Key] public int TeamId { get; set; }
    public decimal Budget { get; set; }
    public string Initials { get; set; }
    [MaxLength] public string LogoUrl { get; set; }
    [MaxLength(128)] public string Name { get; set; }
    [ForeignKey("PrimaryKitColorId")] public int PrimaryKitColorId { get; set; }
    public virtual Colors PrimaryKitColors { get; set; }
    [ForeignKey("SecondaryKitColorId")] public int SecondaryKitColorId { get; set; }
    public virtual Colors SecondaryKitColors { get; set; }
    [ForeignKey("TownId")] public int TownId { get; set; }
    public virtual Towns Towns { get; set; }

    public virtual ICollection<Games> AwayGames { get; set; }
    public virtual ICollection<Games> HomeGames { get; set; }
    public virtual ICollection<Players> Players { get; set; }
}