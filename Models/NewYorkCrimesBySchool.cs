using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
/// <summary>
/// This is the combined class from the NewYorkCrime and NewYorkSchool class
/// </summary>
namespace CombinedData
{
    public class NewYorkCrimesBySchool
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
