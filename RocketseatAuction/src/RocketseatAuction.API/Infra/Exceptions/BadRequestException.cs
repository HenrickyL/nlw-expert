using System.Net;

namespace RocketseatAuction.API.Infra.Exceptions;

public class BadRequestException : ExceptionBase
{
    public BadRequestException(string message) : base(HttpStatusCode.BadRequest, message) { }
}
