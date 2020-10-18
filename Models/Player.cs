using Newtonsoft.Json;

namespace CardViewer.Model
{
    public class Player
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        // override object.Equals
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            
            return ((Player)obj).Id==Id;
        }
        
        // override object.GetHashCode
        public override int GetHashCode()
        {
            return Id;
        }
    }
}