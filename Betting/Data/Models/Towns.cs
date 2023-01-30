using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Betting.Data.Models;

public class Towns
{
    [Key] public int TownId { get; set; }
    [MaxLength(64)] public string Name { get; set; }
    [ForeignKey("CountryId")] public int CountryId { get; set; }
    public virtual Countries Countries { get; set; }
    public virtual ICollection<Teams> Teams { get; set; }
}