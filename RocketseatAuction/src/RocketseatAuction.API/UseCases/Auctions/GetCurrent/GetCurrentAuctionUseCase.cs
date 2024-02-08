using Microsoft.EntityFrameworkCore;
using RocketseatAuction.API.Entities;
using RocketseatAuction.API.Infra;
using RocketseatAuction.API.Infra.Exceptions;
using RocketseatAuction.API.Repositories;

namespace RocketseatAuction.API.UseCases.Auctions.GetCurrent;

public class GetCurrentAuctionUseCase : IUseCaseBase<int, Auction>
{
    public async Task<Auction> Execute(int id)
    {
        var repository = new RocketseatAuctionDbContext();

        var result = await repository
            .Auctions
            .Include(auction => auction.Items)
            .FirstOrDefaultAsync(x => x.Id == id);
        if (result == null)
        {
            throw new NotFoundException($"Not found id {id} ");
        }
        return result;
    }
}
