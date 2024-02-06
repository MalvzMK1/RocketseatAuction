using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RocketseatAuction.Entities;
using RocketseatAuction.UseCases.Auctions.GetCurrent;

namespace RocketseatAuction.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AuctionController : ControllerBase
    {
        [HttpGet]
        [ProducesResponseType(typeof(Auction), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult getCurrentAuction()
        {
            var useCase = new GetCurrentAuctionsUseCase();

            var result = useCase.Execute();

            if (result is null)
                return NoContent();

            return Ok(result);
        }
    }
}
