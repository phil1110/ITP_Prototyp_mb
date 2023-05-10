using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITP_Prototyp_mb.Lib.Weather
{
    public class Condition
    {
        [JsonProperty("text")]
        public string Text { get; set; }
    }
}
