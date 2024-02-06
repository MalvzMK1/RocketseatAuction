using Microsoft.AspNetCore.Mvc;

namespace RocketseatAuction.Controllers
{
    public class OfferController : RocketseatAuctionBaseController
    {
        [HttpPost]
        public IActionResult CreateOffer([FromRoute] int itemId)
        {

            return Created();
        }
    }
}
