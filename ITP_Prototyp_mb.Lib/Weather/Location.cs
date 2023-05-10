using Newtonsoft.Json;

namespace ITP_Prototyp_mb.Lib.Weather
{
    // All the code in this file is included in all platforms.
    public class Location
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }
    }
}