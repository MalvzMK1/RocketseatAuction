using RocketseatAuction.Repositories;

namespace RocketseatAuction.UseCases
{
    public class UseCasesBase
    {
        protected RocketseatAuctionDbContext repository = new RocketseatAuctionDbContext();
    }
}
