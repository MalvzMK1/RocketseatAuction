using Microsoft.EntityFrameworkCore;
using RocketseatAuction.Entities;

namespace RocketseatAuction.Repositories
{
    public class RocketseatAuctionDbContext : DbContext
    {
        public DbSet<Auction> Auctions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=D:\\Development\\nlw\\auction\\db\\leilaoDbNLW.db");
        }
    }
}
