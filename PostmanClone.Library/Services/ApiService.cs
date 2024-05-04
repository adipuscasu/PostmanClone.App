using Flurl.Http;
using PostmanClone.Library.Enums;
using System.Text.Json;

namespace PostmanClone.Library.Services;

public class ApiService : IApiService
{
    public async Task<string> CallApiAsync(
        string url, 
        bool formatOutput = true, 
        HttpAction httpAction = HttpAction.Get
        )
    {
        var response = await MakeRequestAsync(url, new HttpMethod("Get"));
        var stringResult = response.GetStringAsync().Result;
        if (response is null)
        {
            return string.Empty;
        }

        if (formatOutput)
        {
            var jsonElement = JsonSerializer.Deserialize<JsonElement>(stringResult);
            var prettyJson = JsonSerializer.Serialize(jsonElement,
                            new JsonSerializerOptions { WriteIndented = true });
            return prettyJson.ToString();
        }
        else { return stringResult; }
    }

    public async Task<IFlurlResponse> MakeRequestAsync(string url, HttpMethod httpMethod)
    {
        try
        {
            IFlurlResponse response;

            switch (httpMethod.Method)
            {
                case "Get":
                    response = await url.GetAsync();
                    break;
                default:
                    throw new Exception("Method not configured");

            }
            return response;
        }
        catch (FlurlHttpException ex)
        {
            // log the error
            // TODO add Serilog
            await Console.Out.WriteLineAsync(ex.Message);
            throw;
        }
    }
}
