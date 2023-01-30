using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Betting.Data.Models.Enums;

namespace Betting.Data.Models;

public class Bets
{
    [Key] public int BetId { get; set; }
    
    public int Amount { get; set; }
    
    [ForeignKey("GameId")] public int GameId { get; set; }
    
    public virtual Games Games { get; set; }
    
    public Predictions Prediction { get; set; }
    
    public DateTime DateTime { get; set; }
    
    [ForeignKey("UserId")] public int UserId { get; set; }
    
    public virtual Users Users { get; set; }
    
    


}