using System.Collections.Generic;
using Newtonsoft.Json;

namespace CardViewer.Model
{
    public class Score
    {
        [JsonProperty("player")]
        public Player Player { get; set; }

        [JsonProperty("scores")]
        public List<int> Scores { get; set; }
    }
}