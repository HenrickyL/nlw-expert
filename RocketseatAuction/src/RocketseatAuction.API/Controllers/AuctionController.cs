using Microsoft.AspNetCore.Mvc;
using RocketseatAuction.API.Entities;
using RocketseatAuction.API.UseCases.Auctions.GetCurrent;

namespace RocketseatAuction.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AuctionController : ControllerBase
{
    [HttpGet("{id}")]
    [ProducesResponseType(typeof(Auction), 200)]
    public async Task<IActionResult> GetCurrentAuction(int id)
    {
        var useCase = new GetCurrentAuctionUseCase();

        var result = await useCase.Execute(id);
        return Ok(result);
    }
}
