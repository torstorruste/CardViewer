using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using CardViewer.Model;
using Newtonsoft.Json;

namespace CardViewer.Service
{
    public class RoundService : IRoundService
    {
        private HttpClient httpClient;

        public RoundService(HttpClient httpClient) {
            this.httpClient = httpClient;
        }

        public async Task<List<Round>> GetRounds()
        {
            Console.WriteLine("GETing rounds");
            var result = await httpClient.GetAsync("rounds");

            result.EnsureSuccessStatusCode();

            var json = await result.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<List<Round>>(json).OrderBy(x=>x.Date).Reverse().ToList();
        }
    }
}