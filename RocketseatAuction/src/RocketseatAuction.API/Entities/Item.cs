﻿using RocketseatAuction.API.Infra;
using System.ComponentModel.DataAnnotations.Schema;

namespace RocketseatAuction.API.Entities;

[Table("Items")]
public class Item : Entity
{
    public string Name { get; set; } = string.Empty;
    public string Brand { get; set; } = string.Empty;
    public int Condition { get; set; }
    public decimal BasePrice { get; set; }
    public int AuctionId { get; set; }
}

