using Microsoft.AspNetCore.Mvc;
using RocketseatAuction.Api.Filters;
using RocketseatAuction.Api.UseCases.Offers.Create;

namespace RocketseatAuction.Api.Controllers
{
    public class OfferController : RocketseatAuctionBaseController
    {
        private readonly CreateOfferUseCase _createOfferUseCase;

        public OfferController(CreateOfferUseCase createOfferUseCase)
        {
            _createOfferUseCase = createOfferUseCase;
        }

        [HttpPost("{itemId}")]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ServiceFilter(typeof(AuthenticationUserAttribute))]
        public IActionResult CreateOffer([FromRoute] int itemId)
        {
            return Ok();
        }
    }
}
