using Microsoft.EntityFrameworkCore;
using RocketseatAuction.Entities;
using RocketseatAuction.Repositories;

namespace RocketseatAuction.UseCases.Auctions.GetCurrent
{
    public class GetCurrentAuctionsUseCase
    {
        private RocketseatAuctionDbContext repository = new RocketseatAuctionDbContext();

        public Auction Execute()
        {
            return repository
                .Auctions
                .Include((auction) => auction.Items)
                .First();
        }
    }
}
