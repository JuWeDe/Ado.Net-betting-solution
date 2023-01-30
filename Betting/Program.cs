using Betting.Data;
using Microsoft.EntityFrameworkCore;

class Program : DbContext
{
    public static void Main(string[] args)
    {
        DbContext context = new BettingContext();
    }
}