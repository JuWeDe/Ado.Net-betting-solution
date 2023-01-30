using System.ComponentModel.DataAnnotations;

namespace Betting.Data.Models;

public class Countries
{
    [Key] public int CountryID { get; set; }
    [MaxLength(64)] public string Name { get; set; }
    public virtual ICollection<Towns> Towns { get; set; }
}