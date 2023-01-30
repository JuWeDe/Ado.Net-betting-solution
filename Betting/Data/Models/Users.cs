using System.ComponentModel.DataAnnotations;

namespace Betting.Data.Models;

public class Users
{
    [Key]
    public int UserId { get; set; }
    
    public double Balance { get; set; }
    [MaxLength(64)]
    public string Email { get; set; }
    [MaxLength(128)]
    public string Name { get; set; }
    public string Password { get; set; }
    [MaxLength(128)]
    public string Username { get; set; }

    public virtual ICollection<Bets> Bets { get; set; }

}