using System.Net;

namespace RocketseatAuction.API.Infra.Exceptions;

public class UnauthorizedException : ExceptionBase
{
    public UnauthorizedException(HttpStatusCode statusCode) : base(HttpStatusCode.Unauthorized, "Unauthorized access. ") { }
    public UnauthorizedException(HttpStatusCode statusCode, string message) : base(HttpStatusCode.Unauthorized, message) { }
}
