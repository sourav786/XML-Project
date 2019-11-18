using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CombinedData
{
    public class MergedData
    {

        [JsonProperty("dbn")]
        public string Dbn { get; set; }

        [JsonProperty("school_name")]
        public string SchoolName { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("location_name")]
        public string LocationName { get; set; }


    }
}
