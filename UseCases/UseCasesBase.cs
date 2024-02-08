using RocketseatAuction.Api.Repositories;

namespace RocketseatAuction.Api.UseCases
{
    public class UseCasesBase
    {
        protected RocketseatAuctionDbContext repository = new RocketseatAuctionDbContext();
    }
}
