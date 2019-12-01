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
        public JsonResult OnGet()
        {

            List<MergedData> mergedData = new List<MergedData>();

            using (WebClient webClient = new WebClient())
            {
                string schoolJsonString = webClient.DownloadString("https://data.cityofnewyork.us/resource/23z9-6uk9.json?");
                SchoolData[] schoolData = SchoolData.FromJson(schoolJsonString);

                string crimeJsonString = webClient.DownloadString("https://data.cityofnewyork.us/resource/kwvk-z7i9.json?");
                CrimeData[] crimeData = CrimeData.FromJson(crimeJsonString);


                // iterate over the specimens, to find which ones like water.
                foreach (SchoolData schoolDatum in schoolData)
                {
                    // find the matching plant record for this specimen.
                    foreach (CrimeData crimeDatum in crimeData)
                    {
                        if (schoolDatum.Dbn == crimeDatum.Dbn)
                        {
                            MergedData x = new MergedData();
                            x.Dbn = schoolDatum.Dbn;
                            x.SchoolName = schoolDatum.SchoolName;
                            x.City = schoolDatum.City;
                            x.SchoolEmail = schoolDatum.SchoolEmail;
                            x.Website = schoolDatum.Website;
                            x.GraduationRate = schoolDatum.GraduationRate;
                            x.AttendanceRate = schoolDatum.AttendanceRate;
                            x.Address = crimeDatum.Address;
                            x.CrimeRate = crimeDatum.AvgofmajorN.ToString();
                           
                            //x.AvgofnocrimN = crimeDatum.AvgofnocrimN.ToString();

                            mergedData.Add(x);
                        }

                    }
                }

            }

            return new JsonResult(mergedData);


        }
    }
}
