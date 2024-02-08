using Microsoft.AspNetCore.Mvc;
using RocketseatAuction.API.UseCases.Auctions.GetCurrent;

namespace RocketseatAuction.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AuctionController : ControllerBase
{
    [HttpGet("{id}")]
    public IActionResult GetCurrentAuction(int id)
    {
        var useCase = new GetCurrentAuctionUseCase();

        var result = useCase.Execute(id);
        return Ok(result);
    }
}
