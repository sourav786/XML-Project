using Newtonsoft.Json;
using OpenTK.Graphics.ES11;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewYork_CIty_School_Data_With_Crime_Rate_History.Models
{
    public class GeocodedColumn
    {
        [JsonProperty("type")]
        public TypeEnum Type { get; set; }

        [JsonProperty("coordinates")]
        public double[] Coordinates { get; set; }
    }
}
