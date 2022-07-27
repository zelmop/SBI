using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net.Http;

using Newtonsoft.Json;

namespace SBIChallenge.Services.Implementation
{
    public class ApiHelper : IApiHelper
    {
        private readonly IHttpClientFactory httpClientFactory;

        public ApiHelper(IHttpClientFactory httpClientFactory) {
            this.httpClientFactory = httpClientFactory;
        }

        public async Task<T> Get<T>(string url) 
        {
            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, url);

            var httpClient = httpClientFactory.CreateClient();
            
            var httpResponseMessage = await httpClient.SendAsync(httpRequestMessage);

            if (httpResponseMessage.IsSuccessStatusCode)
            {
                var jsonString = await httpResponseMessage.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<T>(jsonString);
                
                return result;
            }
            else 
            {
                return default(T);
            }
        }

    }
}