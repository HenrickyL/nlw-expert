using System.Net;

namespace RocketseatAuction.API.Infra.Exceptions;

public class NotFoundException : ExceptionBase
{
    public NotFoundException(string message) : base(HttpStatusCode.NotFound, message) { }
}

