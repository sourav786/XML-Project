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

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("school_email")]
        public string SchoolEmail { get; set; }

        [JsonProperty("website")]
        public string Website { get; set; }

        [JsonProperty("graduation_rate", NullValueHandling = NullValueHandling.Ignore)]
        public string GraduationRate { get; set; }

        [JsonProperty("attendance_rate", NullValueHandling = NullValueHandling.Ignore)]
        public string AttendanceRate { get; set; }

       [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("avgofnocrim_n")]
        public string CrimeRate { get; set; }



    }
}
