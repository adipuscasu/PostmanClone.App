using Flurl.Http;
using Flurl.Http.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostmanClone.Library.Services
{
    public class ApiService
    {

        public async Task<IFlurlResponse> MakeGetRequest(string url)
        {
            try
            {
                var response = await url.GetAsync();
                return response;
            }
            catch (FlurlHttpException ex)
            {
                // log the error
                throw;
            }
        }
    }
}
