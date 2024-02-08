using Microsoft.AspNetCore.Mvc;
using RocketseatAuction.Api.Communication.Requests;
using RocketseatAuction.Api.Entities;
using RocketseatAuction.Api.Filters;
using RocketseatAuction.Api.UseCases.Offers.Create;

namespace RocketseatAuction.Api.Controllers
{
    public class OfferController : RocketseatAuctionBaseController
    {
        [HttpPost("{itemId}")]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ServiceFilter(typeof(AuthenticationUserAttribute))]
        public IActionResult CreateOffer(
            [FromRoute] int itemId,
            [FromBody] RequestCreateOfferJson request,
            
            // Recupera a dependência injetada
            [FromServices] CreateOfferUseCase useCase
        )
        {
            int userId = useCase.Execute(itemId, request);

            return Created(string.Empty, userId);
        }
    }
}
