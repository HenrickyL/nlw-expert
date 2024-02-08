using System.Net;

namespace RocketseatAuction.API.Infra.Exceptions;

public class InternalServerError : ExceptionBase
{
    public InternalServerError() : base(HttpStatusCode.InternalServerError, "InternalServerError") { }
}
