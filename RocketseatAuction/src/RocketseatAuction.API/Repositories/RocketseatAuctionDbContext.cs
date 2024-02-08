using Microsoft.EntityFrameworkCore;
using RocketseatAuction.API.Entities;
namespace RocketseatAuction.API.Repositories;

public class RocketseatAuctionDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=D:\\Workspace\\ws-nlw-expert\\db\\leilaoDbNLW.db");
    }
    public DbSet<Auction> Auctions { get; set; }
}
