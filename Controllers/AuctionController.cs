﻿using Microsoft.AspNetCore.Mvc;
using RocketseatAuction.Entities;
using RocketseatAuction.UseCases.Auctions.GetCurrent;

namespace RocketseatAuction.Controllers
{
    public class AuctionController : RocketseatAuctionBaseController
    {
        [HttpGet]
        [ProducesResponseType(typeof(Auction), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult GetCurrentAuction()
        {
            var useCase = new GetCurrentAuctionsUseCase();

            var result = useCase.Execute();

            if (result is null)
                return NoContent();

            return Ok(result);
        }
    }
}
