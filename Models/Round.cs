using System;
using System.Collections.Generic;
using CardViewer.Service;
using Newtonsoft.Json;

namespace CardViewer.Model
{
    public class Round
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("date")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime Date;

        [JsonProperty("scores")]
        public List<Score> Scores;
    }
}