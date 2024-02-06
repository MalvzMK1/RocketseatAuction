using Microsoft.EntityFrameworkCore;
using RocketseatAuction.Entities;

namespace RocketseatAuction.Repositories
{
    public class RocketseatAuctionDbContext : DbContext
    {
        public DbSet<Auction> Auctions { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Offer> Offers { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=D:\\Development\\nlw\\auction\\db\\leilaoDbNLW.db");
        }
    }
}
