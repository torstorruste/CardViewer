using Newtonsoft.Json;

namespace CardViewer.Model
{
    public class Player
    {
        [JsonProperty("id")]
        public int? Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}