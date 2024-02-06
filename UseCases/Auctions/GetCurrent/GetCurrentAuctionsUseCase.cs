using RocketseatAuction.Entities;
using RocketseatAuction.Repositories;

namespace RocketseatAuction.UseCases.Auctions.GetCurrent
{
    public class GetCurrentAuctionsUseCase
    {
        private RocketseatAuctionDbContext repository = new RocketseatAuctionDbContext();

        public Auction Execute()
        {
            return repository.Auctions.First();
        }
    }
}
