namespace RocketseatAuction.API.Infra;

public interface IUseCaseBase<REQUEST, RESPONSE>
{
    public Task<RESPONSE> Execute(REQUEST request);
}

