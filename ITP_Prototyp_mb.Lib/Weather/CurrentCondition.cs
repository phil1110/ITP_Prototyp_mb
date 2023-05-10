using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITP_Prototyp_mb.Lib.Weather
{
    public class CurrentCondition
    {
        [JsonProperty("temp_c")]
        public double TemperatureCelsius { get; set; }

        [JsonProperty("condition")]
        public Condition Condition { get; set; }

        [JsonProperty("wind_kph")]
        public double WindSpeedKph { get; set; }
    }
}
