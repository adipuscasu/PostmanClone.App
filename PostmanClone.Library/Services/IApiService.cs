using Flurl.Http;
using PostmanClone.Library.Enums;

namespace PostmanClone.Library.Services;
public interface IApiService
{
    Task<string> CallApiAsync(string url, bool formatOutput = true, HttpAction httpAction = HttpAction.Get);
    Task<IFlurlResponse> MakeRequestAsync(string url, HttpMethod httpMethod);
}