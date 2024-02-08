using System.Net;

namespace RocketseatAuction.API.Infra.Exceptions;

public abstract class ExceptionBase : Exception
{
    public HttpStatusCode StatusCode { get; }
    public ExceptionBase(HttpStatusCode statusCode) : base()
    {
        StatusCode = statusCode;
    }
    public ExceptionBase(HttpStatusCode statusCode, string message) : base(message)
    {
        StatusCode = statusCode;
    }
}