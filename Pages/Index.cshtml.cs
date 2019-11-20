using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using CombinedData;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NewYorkCityCrimeData;
using NewYorkCitySchoolData;

namespace NewYork_CIty_School_Data_With_Crime_Rate_History.Pages
{
    public class IndexModel : PageModel
    {
        public string GetData(string endpoint)
        {
            string downloadedData = "";
            using (WebClient webClient = new WebClient())
            {
                downloadedData = webClient.DownloadString(endpoint);
            }
            return downloadedData;
        }
        public JsonResult OnGet()
        {

            List<MergedData> mergedData = new List<MergedData>();

            using (WebClient webClient = new WebClient())
            {
                string schoolJsonString = GetData("https://data.cityofnewyork.us/resource/23z9-6uk9.json");
                //               string schoolJsonString = webClient.DownloadString("https://data.cityofnewyork.us/resource/23z9-6uk9.json");
                SchoolData[] schoolData = SchoolData.FromJson(schoolJsonString);

                string crimeJsonString = GetData("https://data.cityofnewyork.us/resource/kwvk-z7i9.json");
                //                string crimeJsonString = webClient.DownloadString("https://data.cityofnewyork.us/resource/kwvk-z7i9.json");
                CrimeData[] crimeData = CrimeData.FromJson(crimeJsonString);

                var schoolQuery = from SchoolData in schoolData
                                   join CrimeData in crimeData
                                   on SchoolData.Dbn equals CrimeData.Dbn
                                   select new
                                   {
                                       Dbn = SchoolData.Dbn,
                                       Address = CrimeData.Address
                                   };
                foreach (var item in schoolQuery)
                {
                    mergedData.Add(new MergedData
                    {
                        Dbn = item.Dbn,
                        Address = item.Address
                    });
                }


                //// iterate over the specimens, to find which ones like water.
                //foreach (SchoolData schoolDatum in schoolData)
                //{
                //    // find the matching plant record for this specimen.
                //    foreach (CrimeData crimeDatum in crimeData)
                //    {
                //        if (schoolDatum.Dbn == crimeDatum.Dbn)
                //        {
                //            var x = new MergedData();
                //            x.Dbn = schoolDatum.Dbn;
                //            x.Address = crimeDatum.Address;

                //            mergedData.Add(x);
                //        }

                //    }
                //}

            }


            return new JsonResult(mergedData);


        }
    }
}
