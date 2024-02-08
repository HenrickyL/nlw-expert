using RocketseatAuction.API.Infra;

namespace RocketseatAuction.API.Entities;

public class Auction : Entity
{
    public string Name { get; set; } = string.Empty;
    public DateTime Starts { get; set; }
    public DateTime Ends { get; set; }
    public List<Item> Items { get; set; } = [];
}
