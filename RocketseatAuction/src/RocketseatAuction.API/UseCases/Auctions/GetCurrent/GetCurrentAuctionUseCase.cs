using Microsoft.EntityFrameworkCore;
using RocketseatAuction.API.Entities;
using RocketseatAuction.API.Infra.Exceptions;
using RocketseatAuction.API.Repositories;

namespace RocketseatAuction.API.UseCases.Auctions.GetCurrent;

public class GetCurrentAuctionUseCase
{
    public Auction Execute(int id)
    {
        var repository = new RocketseatAuctionDbContext();

        var result = repository
            .Auctions
            .Include(auction => auction.Items)
            .FirstOrDefault(x => x.Id == id);
        if(result == null)
        {
            throw new NotFoundException($"Not found id {id} ");
        }
        return result;
    }
}
