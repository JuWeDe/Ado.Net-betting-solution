using System.ComponentModel.DataAnnotations;

namespace Betting.Data.Models;

public class Colors
{
    [Key] public int ColorId { get; set; }
    [MaxLength(64)] public string Name { get; set; }
    public virtual ICollection<Teams> PrimaryKitColorId { get; set; }
    public virtual ICollection<Teams> SecondaryKitColorId { get; set; }
}