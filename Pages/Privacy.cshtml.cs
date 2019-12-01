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
    public class PrivacyModel : PageModel
    {
        public bool CallComplete { set; get; }
        public void OnGet()
        {
        }
        public void OnPost()
        {
            var city = Request.Form["cityArea"];

            /*using (WebClient webClient = new WebClient())
            {
                string schoolJsonString = webClient.DownloadString("https://data.cityofnewyork.us/resource/23z9-6uk9.json?city=" + city);
                SchoolData[] schoolData = SchoolData.FromJson(schoolJsonString);

                List<MergedData> mergedList = new List<MergedData>();

                foreach (SchoolData school in schoolData)
                {
                    string crimeJsonString = webClient.DownloadString("https://data.cityofnewyork.us/resource/kwvk-z7i9.json?dbn=" + school.Dbn);
                    CrimeData[] crimeData = CrimeData.FromJson(crimeJsonString);

                        var x = new MergedData();
                        x.Dbn = school.Dbn;
                        x.SchoolName = school.SchoolName;

                    x.City = school.City;
                    x.SchoolEmail = school.SchoolEmail;
                    x.Website = school.Website;
                    x.GraduationRate = school.GraduationRate;
                    x.AttendanceRate = school.AttendanceRate;
                    x.Address = crimeDatum.Address;
                    x.CrimeRate = crimeDatum.AvgofmajorN.ToString();
                    x.LocationName = crimeDatum.LocationName;
                    //x.AvgofnocrimN = crimeData.AvgofnocrimN;
                    //x.CrimeRate = crimeData[0].Register;

                    mergedList.Add(x);
                }

                ViewData["MergedList"] = mergedList;
                CallComplete = true;
            }*/

            using (WebClient webClient = new WebClient())
            {
                string schoolJsonString = webClient.DownloadString("https://data.cityofnewyork.us/resource/23z9-6uk9.json?city=" + city);
                SchoolData[] schoolData = SchoolData.FromJson(schoolJsonString);

                List<MergedData> mergedList = new List<MergedData>();

                // iterate over the specimens, to find which ones like water.
                foreach (SchoolData schoolDatum in schoolData)
                {
                    string crimeJsonString = webClient.DownloadString("https://data.cityofnewyork.us/resource/kwvk-z7i9.json?dbn=" + schoolDatum.Dbn);
                    CrimeData[] crimeData = CrimeData.FromJson(crimeJsonString);

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
                           // x.LocationName = crimeDatum.LocationName;
                            //x.AvgofnocrimN = crimeDatum.AvgofnocrimN.ToString();

                            mergedList.Add(x);
                        }
                        ViewData["MergedList"] = mergedList;
                        CallComplete = true;
                    }
                }
            }
        }
    }
}