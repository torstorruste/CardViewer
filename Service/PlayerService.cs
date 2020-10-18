using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using CardViewer.Model;
using Newtonsoft.Json;

namespace CardViewer.Service
{
    public class PlayerService : IPlayerService
    {
        private readonly HttpClient httpClient;

        public PlayerService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task<List<Player>> GetPlayers()
        {
            Console.WriteLine("GETing players");
            var result = await httpClient.GetAsync("players");

            result.EnsureSuccessStatusCode();

            var json = await result.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<List<Player>>(json);
        }
    }
}