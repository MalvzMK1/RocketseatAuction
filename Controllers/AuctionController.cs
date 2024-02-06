using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RocketseatAuction.UseCases.Auctions.GetCurrent;

namespace RocketseatAuction.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AuctionController : ControllerBase
    {
        [HttpGet]
        public IActionResult getCurrentAuction()
        {
            var useCase = new GetCurrentAuctionsUseCase();

            var result = useCase.Execute();

            return Ok(result);
        }
    }
}
