using Microsoft.EntityFrameworkCore;
using RocketseatAuction.Entities;

namespace RocketseatAuction.UseCases.Auctions.GetCurrent
{
    public class GetCurrentAuctionsUseCase : UseCasesBase
    {
        public Auction? Execute()
        {
            DateTime today = new DateTime(2024, 01, 21);

            return repository
                .Auctions
                .Include((auction) => auction.Items)
                .FirstOrDefault((auction) => today >= auction.Starts && today <= auction.Ends);
        }
    }
}
