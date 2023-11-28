using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;

namespace FunctionApp1;

public class Function1
{
    [Function("negotiate")]
    public string Negotiate(
        [HttpTrigger(AuthorizationLevel.Function)] HttpRequestData req, [SignalRConnectionInfoInput(HubName = "TestFunctions", UserId = "{headers.user}",
            IdToken = "{headers.token}",
            ClaimTypeList = new []{"user_id"})] string connectionInfo
    )
    {
        return connectionInfo;
    }
}