using RocketseatAuction.API.Entities;

namespace RocketseatAuction.API.UseCases.Auctions.GetCurrent;

public class GetCurrentAuctionUseCase
{
    public Auction Execute()
    {
        return new()
        {
            Id = 1,
            Name = "Test",
            Starts = DateTime.Now,
            Ends = DateTime.Now,
        };
    }
}
