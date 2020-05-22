using System;
using System.Net.Http;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using POKE.App.Helpers.Interfaces;

namespace POKE.App.Helpers.Implementations
{
    public class ApiRequestHelper : IApiRequestHelper
    {
        private HttpClient httpClient;

        public string Get(System.Uri url, string jsonBody = null)
        {
            httpClient = new HttpClient();

            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, url);

            if (jsonBody != null)
            {
                request.Content = new StringContent(jsonBody, Encoding.UTF8, "application/jsonBody");
            }

            try
            {
                HttpResponseMessage response = httpClient.SendAsync(request).Result;
                return response.Content.ReadAsStringAsync().Result;
            }
            catch (Exception)
            {
                throw;  // NEEDS IMPROVED, JUST TEMP
            }
        }

        public void Dispose()
        {
            throw new System.NotImplementedException();
        }
    }
}
