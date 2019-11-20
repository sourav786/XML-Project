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
/// <summary>
/// foreach New York School: iterate over each school in the New York Schools
/// foreach New York Crime: iterate over each crime in New York Crimes
/// if: checks for a matching dbn for New York School and New York Crime
/// JsonResult: return the Json for the items that had matching dbn in the New York School and New York Crime jsons
/// </summary>
namespace NewYork_CIty_School_Data_With_Crime_Rate_History.Pages
{
    public class IndexModel : PageModel
    {
        public JsonResult OnGet()
        {

            List<NewYorkCrimesBySchool> newYorkCrimesBySchools = new List<NewYorkCrimesBySchool>();

            using (WebClient webClient = new WebClient())
            {
                string schoolJsonString = webClient.DownloadString("https://data.cityofnewyork.us/resource/23z9-6uk9.json");
                NewYorkSchool[] newYorkSchools = NewYorkSchool.FromJson(schoolJsonString);

                string crimeJsonString = webClient.DownloadString("https://data.cityofnewyork.us/resource/kwvk-z7i9.json");
                NewYorkCrime[] newYorkCrimes = NewYorkCrime.FromJson(crimeJsonString);



                foreach (NewYorkSchool newYorkSchool in newYorkSchools)
                {
                    foreach (NewYorkCrime newYorkCrime in newYorkCrimes)
                    {
                        if (newYorkSchool.Dbn == newYorkCrime.Dbn)
                        {
                            var crimesBySchool = new NewYorkCrimesBySchool();
                            crimesBySchool.Dbn = newYorkSchool.Dbn;
                            crimesBySchool.SchoolName = newYorkSchool.SchoolName;
                            crimesBySchool.Address = newYorkCrime.Address;
                            crimesBySchool.LocationName = newYorkCrime.LocationName;

                            newYorkCrimesBySchools.Add(crimesBySchool);
                        }

                    }
                }

            }
            return new JsonResult(newYorkCrimesBySchools);
        }
    }
}