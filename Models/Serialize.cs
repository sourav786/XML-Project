using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewYork_CIty_School_Data_With_Crime_Rate_History.Models
{
    public static class Serialize
    {
        public static string ToJson(this Welcome[] self) => Newtonsoft.Json.JsonConvert.SerializeObject(self);
    }
}
