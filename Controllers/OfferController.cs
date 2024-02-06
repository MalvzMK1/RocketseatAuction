using Microsoft.AspNetCore.Mvc;
using RocketseatAuction.Entities;
using RocketseatAuction.Filters;
using RocketseatAuction.UseCases.Items.Get;

namespace RocketseatAuction.Controllers
{
    public class OfferController : RocketseatAuctionBaseController
    {
        [HttpPost("{itemId}")]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ServiceFilter(typeof(AuthenticationUserAttribute))]
        public IActionResult CreateOffer([FromRoute] int itemId)
        {
            var useCase = new GetItemUseCase();

            Item? item = useCase.Execute(itemId);

            if (item is null)
                return NotFound();

            return Created();
        }
    }
}
