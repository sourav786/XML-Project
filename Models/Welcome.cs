﻿using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using NewYork_CIty_School_Data_With_Crime_Rate_History.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace NewYork_CIty_School_Data_With_Crime_Rate_History.Models
{
    public partial class Welcome
    {
        [JsonProperty("dbn")]
        public string Dbn { get; set; }

        [JsonProperty("school_name")]
        public string SchoolName { get; set; }

        [JsonProperty("borocode")]
        public Borocode Borocode { get; set; }

        [JsonProperty("overview_paragraph")]
        public string OverviewParagraph { get; set; }

        [JsonProperty("school_10th_seats", NullValueHandling = NullValueHandling.Ignore)]
        public ArakGroundhog? School10ThSeats { get; set; }

        [JsonProperty("academicopportunities1", NullValueHandling = NullValueHandling.Ignore)]
        public string Academicopportunities1 { get; set; }

        [JsonProperty("academicopportunities2", NullValueHandling = NullValueHandling.Ignore)]
        public string Academicopportunities2 { get; set; }

        [JsonProperty("academicopportunities3", NullValueHandling = NullValueHandling.Ignore)]
        public string Academicopportunities3 { get; set; }

        [JsonProperty("academicopportunities4", NullValueHandling = NullValueHandling.Ignore)]
        public string Academicopportunities4 { get; set; }

        [JsonProperty("academicopportunities5", NullValueHandling = NullValueHandling.Ignore)]
        public string Academicopportunities5 { get; set; }

        [JsonProperty("ell_programs")]
        public string EllPrograms { get; set; }

        [JsonProperty("language_classes", NullValueHandling = NullValueHandling.Ignore)]
        public string LanguageClasses { get; set; }

        [JsonProperty("neighborhood")]
        public string Neighborhood { get; set; }

        [JsonProperty("primary_address_line_1")]
        public string PrimaryAddressLine1 { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state_code")]
        public StateCode StateCode { get; set; }

        [JsonProperty("postcode")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Postcode { get; set; }

        [JsonProperty("building_code")]
        public string BuildingCode { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("phone_number")]
        public string PhoneNumber { get; set; }

        [JsonProperty("fax_number", NullValueHandling = NullValueHandling.Ignore)]
        public string FaxNumber { get; set; }

        [JsonProperty("school_email")]
        public string SchoolEmail { get; set; }

        [JsonProperty("website")]
        public string Website { get; set; }

        [JsonProperty("subway")]
        public string Subway { get; set; }

        [JsonProperty("bus")]
        public string Bus { get; set; }

        [JsonProperty("grades2019")]
        public Grades2019 Grades2019 { get; set; }

        [JsonProperty("finalgrades")]
        public string Finalgrades { get; set; }

        [JsonProperty("total_students")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long TotalStudents { get; set; }

        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTime { get; set; }

        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EndTime { get; set; }

        [JsonProperty("addtl_info1", NullValueHandling = NullValueHandling.Ignore)]
        public string AddtlInfo1 { get; set; }

        [JsonProperty("extracurricular_activities", NullValueHandling = NullValueHandling.Ignore)]
        public string ExtracurricularActivities { get; set; }

        [JsonProperty("psal_sports_boys", NullValueHandling = NullValueHandling.Ignore)]
        public string PsalSportsBoys { get; set; }

        [JsonProperty("psal_sports_girls", NullValueHandling = NullValueHandling.Ignore)]
        public string PsalSportsGirls { get; set; }

        [JsonProperty("school_sports", NullValueHandling = NullValueHandling.Ignore)]
        public string SchoolSports { get; set; }

        [JsonProperty("graduation_rate", NullValueHandling = NullValueHandling.Ignore)]
        public string GraduationRate { get; set; }

        [JsonProperty("attendance_rate", NullValueHandling = NullValueHandling.Ignore)]
        public string AttendanceRate { get; set; }

        [JsonProperty("pct_stu_enough_variety", NullValueHandling = NullValueHandling.Ignore)]
        public string PctStuEnoughVariety { get; set; }

        [JsonProperty("college_career_rate", NullValueHandling = NullValueHandling.Ignore)]
        public string CollegeCareerRate { get; set; }

        [JsonProperty("pct_stu_safe", NullValueHandling = NullValueHandling.Ignore)]
        public string PctStuSafe { get; set; }

        [JsonProperty("pbat", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? Pbat { get; set; }

        [JsonProperty("school_accessibility")]
        public SchoolAccessibility SchoolAccessibility { get; set; }

        [JsonProperty("requirement1_1", NullValueHandling = NullValueHandling.Ignore)]
        public string Requirement11 { get; set; }

        [JsonProperty("requirement2_1", NullValueHandling = NullValueHandling.Ignore)]
        public string Requirement21 { get; set; }

        [JsonProperty("offer_rate1_1", NullValueHandling = NullValueHandling.Ignore)]
        public string OfferRate11 { get; set; }

        [JsonProperty("offer_rate2_1", NullValueHandling = NullValueHandling.Ignore)]
        public string OfferRate21 { get; set; }

        [JsonProperty("program1")]
        public string Program1 { get; set; }

        [JsonProperty("code1")]
        public string Code1 { get; set; }

        [JsonProperty("interest1")]
        public Interest1 Interest1 { get; set; }

        [JsonProperty("method1")]
        public Method Method1 { get; set; }

        [JsonProperty("seats9ge1", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? Seats9Ge1 { get; set; }

        [JsonProperty("grade9gefilledflag1", NullValueHandling = NullValueHandling.Ignore)]
        public ArakGroundhog? Grade9Gefilledflag1 { get; set; }

        [JsonProperty("grade9geapplicants1", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? Grade9Geapplicants1 { get; set; }

        [JsonProperty("grade9geapplicantsperseat1", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? Grade9Geapplicantsperseat1 { get; set; }

        [JsonProperty("seats9swd1", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? Seats9Swd1 { get; set; }

        [JsonProperty("grade9swdfilledflag1", NullValueHandling = NullValueHandling.Ignore)]
        public ArakGroundhog? Grade9Swdfilledflag1 { get; set; }

        [JsonProperty("grade9swdapplicants1", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? Grade9Swdapplicants1 { get; set; }

        [JsonProperty("grade9swdapplicantsperseat1", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? Grade9Swdapplicantsperseat1 { get; set; }

        [JsonProperty("seats101")]
        public Seats101 Seats101 { get; set; }

        [JsonProperty("admissionspriority11", NullValueHandling = NullValueHandling.Ignore)]
        public string Admissionspriority11 { get; set; }

        [JsonProperty("admissionspriority21", NullValueHandling = NullValueHandling.Ignore)]
        public string Admissionspriority21 { get; set; }

        [JsonProperty("admissionspriority31", NullValueHandling = NullValueHandling.Ignore)]
        public string Admissionspriority31 { get; set; }

        [JsonProperty("borough")]
        public Borough Borough { get; set; }

        [JsonProperty("latitude")]
        public string Latitude { get; set; }

        [JsonProperty("longitude")]
        public string Longitude { get; set; }

        [JsonProperty("community_board")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long CommunityBoard { get; set; }

        [JsonProperty("council_district")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long CouncilDistrict { get; set; }

        [JsonProperty("census_tract")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long CensusTract { get; set; }

        [JsonProperty("bin")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Bin { get; set; }

        [JsonProperty("bbl")]
        public string Bbl { get; set; }

        [JsonProperty("nta")]
        public string Nta { get; set; }

        [JsonProperty("geocoded_column")]
        public GeocodedColumn GeocodedColumn { get; set; }

        [JsonProperty(":@computed_region_efsh_h5xi", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? ComputedRegionEfshH5Xi { get; set; }

        [JsonProperty(":@computed_region_f5dn_yrer")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long ComputedRegionF5DnYrer { get; set; }

        [JsonProperty(":@computed_region_yeji_bk3q")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long ComputedRegionYejiBk3Q { get; set; }

        [JsonProperty(":@computed_region_92fq_4b7q")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long ComputedRegion92Fq4B7Q { get; set; }

        [JsonProperty(":@computed_region_sbqj_enih")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long ComputedRegionSbqjEnih { get; set; }

        [JsonProperty("shared_space", NullValueHandling = NullValueHandling.Ignore)]
        public Seats101? SharedSpace { get; set; }

        [JsonProperty("campus_name", NullValueHandling = NullValueHandling.Ignore)]
        public string CampusName { get; set; }

        [JsonProperty("psal_sports_coed", NullValueHandling = NullValueHandling.Ignore)]
        public string PsalSportsCoed { get; set; }

        [JsonProperty("earlycollege", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? Earlycollege { get; set; }

        [JsonProperty("prgdesc1", NullValueHandling = NullValueHandling.Ignore)]
        public string Prgdesc1 { get; set; }

        [JsonProperty("requirement3_1", NullValueHandling = NullValueHandling.Ignore)]
        public string Requirement31 { get; set; }

        [JsonProperty("requirement4_1", NullValueHandling = NullValueHandling.Ignore)]
        public string Requirement41 { get; set; }

        [JsonProperty("requirement5_1", NullValueHandling = NullValueHandling.Ignore)]
        public string Requirement51 { get; set; }

        [JsonProperty("advancedplacement_courses", NullValueHandling = NullValueHandling.Ignore)]
        public string AdvancedplacementCourses { get; set; }

        [JsonProperty("boys", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? Boys { get; set; }

        [JsonProperty("eligibility1", NullValueHandling = NullValueHandling.Ignore)]
        public string Eligibility1 { get; set; }

        [JsonProperty("prgdesc2", NullValueHandling = NullValueHandling.Ignore)]
        public string Prgdesc2 { get; set; }

        [JsonProperty("offer_rate1_2", NullValueHandling = NullValueHandling.Ignore)]
        public string OfferRate12 { get; set; }

        [JsonProperty("offer_rate2_2", NullValueHandling = NullValueHandling.Ignore)]
        public string OfferRate22 { get; set; }

        [JsonProperty("program2", NullValueHandling = NullValueHandling.Ignore)]
        public string Program2 { get; set; }

        [JsonProperty("program3", NullValueHandling = NullValueHandling.Ignore)]
        public string Program3 { get; set; }

        [JsonProperty("code2", NullValueHandling = NullValueHandling.Ignore)]
        public string Code2 { get; set; }

        [JsonProperty("code3", NullValueHandling = NullValueHandling.Ignore)]
        public string Code3 { get; set; }

        [JsonProperty("interest2", NullValueHandling = NullValueHandling.Ignore)]
        public Interest1? Interest2 { get; set; }

        [JsonProperty("method2", NullValueHandling = NullValueHandling.Ignore)]
        public Method? Method2 { get; set; }

        [JsonProperty("method3", NullValueHandling = NullValueHandling.Ignore)]
        public Method? Method3 { get; set; }

        [JsonProperty("seats9ge2", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? Seats9Ge2 { get; set; }

        [JsonProperty("grade9gefilledflag2", NullValueHandling = NullValueHandling.Ignore)]
        public ArakGroundhog? Grade9Gefilledflag2 { get; set; }

        [JsonProperty("grade9geapplicants2", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? Grade9Geapplicants2 { get; set; }

        [JsonProperty("grade9geapplicantsperseat2", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? Grade9Geapplicantsperseat2 { get; set; }

        [JsonProperty("seats9swd2", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? Seats9Swd2 { get; set; }

        [JsonProperty("grade9swdfilledflag2", NullValueHandling = NullValueHandling.Ignore)]
        public ArakGroundhog? Grade9Swdfilledflag2 { get; set; }

        [JsonProperty("grade9swdapplicants2", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? Grade9Swdapplicants2 { get; set; }

        [JsonProperty("grade9swdapplicantsperseat2", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? Grade9Swdapplicantsperseat2 { get; set; }

        [JsonProperty("seats102", NullValueHandling = NullValueHandling.Ignore)]
        public Seats101? Seats102 { get; set; }

        [JsonProperty("admissionspriority12", NullValueHandling = NullValueHandling.Ignore)]
        public string Admissionspriority12 { get; set; }

        [JsonProperty("admissionspriority22", NullValueHandling = NullValueHandling.Ignore)]
        public string Admissionspriority22 { get; set; }

        [JsonProperty("admissionspriority32", NullValueHandling = NullValueHandling.Ignore)]
        public string Admissionspriority32 { get; set; }

        [JsonProperty("eligibility3", NullValueHandling = NullValueHandling.Ignore)]
        public string Eligibility3 { get; set; }

        [JsonProperty("international", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? International { get; set; }

        [JsonProperty("offer_rate3_1", NullValueHandling = NullValueHandling.Ignore)]
        public string OfferRate31 { get; set; }

        [JsonProperty("admissionspriority41", NullValueHandling = NullValueHandling.Ignore)]
        public Admissionspriority? Admissionspriority41 { get; set; }

        [JsonProperty("prgdesc3", NullValueHandling = NullValueHandling.Ignore)]
        public string Prgdesc3 { get; set; }

        [JsonProperty("requirement1_2", NullValueHandling = NullValueHandling.Ignore)]
        public string Requirement12 { get; set; }

        [JsonProperty("requirement1_3", NullValueHandling = NullValueHandling.Ignore)]
        public string Requirement13 { get; set; }

        [JsonProperty("requirement2_2", NullValueHandling = NullValueHandling.Ignore)]
        public string Requirement22 { get; set; }

        [JsonProperty("requirement2_3", NullValueHandling = NullValueHandling.Ignore)]
        public string Requirement23 { get; set; }

        [JsonProperty("requirement3_2", NullValueHandling = NullValueHandling.Ignore)]
        public string Requirement32 { get; set; }

        [JsonProperty("requirement3_3", NullValueHandling = NullValueHandling.Ignore)]
        public string Requirement33 { get; set; }

        [JsonProperty("requirement4_2", NullValueHandling = NullValueHandling.Ignore)]
        public string Requirement42 { get; set; }

        [JsonProperty("requirement4_3", NullValueHandling = NullValueHandling.Ignore)]
        public string Requirement43 { get; set; }

        [JsonProperty("offer_rate1_3", NullValueHandling = NullValueHandling.Ignore)]
        public string OfferRate13 { get; set; }

        [JsonProperty("interest3", NullValueHandling = NullValueHandling.Ignore)]
        public Interest1? Interest3 { get; set; }

        [JsonProperty("seats9ge3", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? Seats9Ge3 { get; set; }

        [JsonProperty("grade9gefilledflag3", NullValueHandling = NullValueHandling.Ignore)]
        public ArakGroundhog? Grade9Gefilledflag3 { get; set; }

        [JsonProperty("grade9geapplicants3", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? Grade9Geapplicants3 { get; set; }

        [JsonProperty("grade9geapplicantsperseat3", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? Grade9Geapplicantsperseat3 { get; set; }

        [JsonProperty("seats9swd3", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? Seats9Swd3 { get; set; }

        [JsonProperty("grade9swdfilledflag3", NullValueHandling = NullValueHandling.Ignore)]
        public ArakGroundhog? Grade9Swdfilledflag3 { get; set; }

        [JsonProperty("grade9swdapplicants3", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? Grade9Swdapplicants3 { get; set; }

        [JsonProperty("grade9swdapplicantsperseat3", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? Grade9Swdapplicantsperseat3 { get; set; }

        [JsonProperty("seats103", NullValueHandling = NullValueHandling.Ignore)]
        public Seats101? Seats103 { get; set; }

        [JsonProperty("admissionspriority13", NullValueHandling = NullValueHandling.Ignore)]
        public string Admissionspriority13 { get; set; }

        [JsonProperty("admissionspriority23", NullValueHandling = NullValueHandling.Ignore)]
        public string Admissionspriority23 { get; set; }

        [JsonProperty("diplomaendorsements", NullValueHandling = NullValueHandling.Ignore)]
        public Diplomaendorsements? Diplomaendorsements { get; set; }

        [JsonProperty("requirement6_1", NullValueHandling = NullValueHandling.Ignore)]
        public string Requirement61 { get; set; }

        [JsonProperty("prgdesc4", NullValueHandling = NullValueHandling.Ignore)]
        public string Prgdesc4 { get; set; }

        [JsonProperty("prgdesc5", NullValueHandling = NullValueHandling.Ignore)]
        public string Prgdesc5 { get; set; }

        [JsonProperty("requirement1_4", NullValueHandling = NullValueHandling.Ignore)]
        public string Requirement14 { get; set; }

        [JsonProperty("requirement1_5", NullValueHandling = NullValueHandling.Ignore)]
        public string Requirement15 { get; set; }

        [JsonProperty("requirement2_4", NullValueHandling = NullValueHandling.Ignore)]
        public string Requirement24 { get; set; }

        [JsonProperty("requirement2_5", NullValueHandling = NullValueHandling.Ignore)]
        public string Requirement25 { get; set; }

        [JsonProperty("requirement3_4", NullValueHandling = NullValueHandling.Ignore)]
        public string Requirement34 { get; set; }

        [JsonProperty("requirement3_5", NullValueHandling = NullValueHandling.Ignore)]
        public string Requirement35 { get; set; }

        [JsonProperty("requirement4_5", NullValueHandling = NullValueHandling.Ignore)]
        public string Requirement45 { get; set; }

        [JsonProperty("requirement5_2", NullValueHandling = NullValueHandling.Ignore)]
        public string Requirement52 { get; set; }

        [JsonProperty("requirement5_3", NullValueHandling = NullValueHandling.Ignore)]
        public string Requirement53 { get; set; }

        [JsonProperty("requirement5_4", NullValueHandling = NullValueHandling.Ignore)]
        public string Requirement54 { get; set; }

        [JsonProperty("requirement5_5", NullValueHandling = NullValueHandling.Ignore)]
        public string Requirement55 { get; set; }

        [JsonProperty("requirement6_2", NullValueHandling = NullValueHandling.Ignore)]
        public string Requirement62 { get; set; }

        [JsonProperty("requirement6_3", NullValueHandling = NullValueHandling.Ignore)]
        public string Requirement63 { get; set; }

        [JsonProperty("requirement6_4", NullValueHandling = NullValueHandling.Ignore)]
        public string Requirement64 { get; set; }

        [JsonProperty("requirement6_5", NullValueHandling = NullValueHandling.Ignore)]
        public string Requirement65 { get; set; }

        [JsonProperty("requirement7_1", NullValueHandling = NullValueHandling.Ignore)]
        public string Requirement71 { get; set; }

        [JsonProperty("requirement7_2", NullValueHandling = NullValueHandling.Ignore)]
        public string Requirement72 { get; set; }

        [JsonProperty("requirement7_3", NullValueHandling = NullValueHandling.Ignore)]
        public string Requirement73 { get; set; }

        [JsonProperty("requirement7_4", NullValueHandling = NullValueHandling.Ignore)]
        public string Requirement74 { get; set; }

        [JsonProperty("requirement7_5", NullValueHandling = NullValueHandling.Ignore)]
        public string Requirement75 { get; set; }

        [JsonProperty("offer_rate1_4", NullValueHandling = NullValueHandling.Ignore)]
        public string OfferRate14 { get; set; }

        [JsonProperty("offer_rate1_5", NullValueHandling = NullValueHandling.Ignore)]
        public string OfferRate15 { get; set; }

        [JsonProperty("offer_rate2_3", NullValueHandling = NullValueHandling.Ignore)]
        public string OfferRate23 { get; set; }

        [JsonProperty("offer_rate2_4", NullValueHandling = NullValueHandling.Ignore)]
        public string OfferRate24 { get; set; }

        [JsonProperty("offer_rate2_5", NullValueHandling = NullValueHandling.Ignore)]
        public string OfferRate25 { get; set; }

        [JsonProperty("program4", NullValueHandling = NullValueHandling.Ignore)]
        public string Program4 { get; set; }

        [JsonProperty("program5", NullValueHandling = NullValueHandling.Ignore)]
        public string Program5 { get; set; }

        [JsonProperty("program6", NullValueHandling = NullValueHandling.Ignore)]
        public string Program6 { get; set; }

        [JsonProperty("code4", NullValueHandling = NullValueHandling.Ignore)]
        public string Code4 { get; set; }

        [JsonProperty("code5", NullValueHandling = NullValueHandling.Ignore)]
        public string Code5 { get; set; }

        [JsonProperty("code6", NullValueHandling = NullValueHandling.Ignore)]
        public string Code6 { get; set; }

        [JsonProperty("interest4", NullValueHandling = NullValueHandling.Ignore)]
        public Interest1? Interest4 { get; set; }

        [JsonProperty("interest5", NullValueHandling = NullValueHandling.Ignore)]
        public Interest1? Interest5 { get; set; }

        [JsonProperty("method4", NullValueHandling = NullValueHandling.Ignore)]
        public Method? Method4 { get; set; }

        [JsonProperty("method5", NullValueHandling = NullValueHandling.Ignore)]
        public Method? Method5 { get; set; }

        [JsonProperty("method6", NullValueHandling = NullValueHandling.Ignore)]
        public Method? Method6 { get; set; }

        [JsonProperty("seats9ge4", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? Seats9Ge4 { get; set; }

        private TrapaniSnowLeopard seats9Ge5;

        public TrapaniSnowLeopard GetSeats9Ge5()
        {
            return seats9Ge5;
        }

        public void SetSeats9Ge5(TrapaniSnowLeopard value)
        {
            seats9Ge5 = value;
        }

        [JsonProperty("grade9gefilledflag4", NullValueHandling = NullValueHandling.Ignore)]
        public ArakGroundhog? Grade9Gefilledflag4 { get; set; }

        [JsonProperty("grade9gefilledflag5", NullValueHandling = NullValueHandling.Ignore)]
        public ArakGroundhog? Grade9Gefilledflag5 { get; set; }

        [JsonProperty("grade9geapplicants4", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? Grade9Geapplicants4 { get; set; }

        [JsonProperty("grade9geapplicantsperseat4", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? Grade9Geapplicantsperseat4 { get; set; }

        private TrapaniSnowLeopard grade9Geapplicants5;

        public TrapaniSnowLeopard GetGrade9Geapplicants5()
        {
            return grade9Geapplicants5;
        }

        public void SetGrade9Geapplicants5(TrapaniSnowLeopard value)
        {
            grade9Geapplicants5 = value;
        }

        private TrapaniSnowLeopard grade9Geapplicantsperseat5;

        public TrapaniSnowLeopard GetGrade9Geapplicantsperseat5()
        {
            return grade9Geapplicantsperseat5;
        }

        public void SetGrade9Geapplicantsperseat5(TrapaniSnowLeopard value)
        {
            grade9Geapplicantsperseat5 = value;
        }

        [JsonProperty("seats9swd4", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? Seats9Swd4 { get; set; }

        private TrapaniSnowLeopard seats9Swd5;

        public TrapaniSnowLeopard GetSeats9Swd5()
        {
            return seats9Swd5;
        }

        public void SetSeats9Swd5(TrapaniSnowLeopard value)
        {
            seats9Swd5 = value;
        }

        [JsonProperty("grade9swdfilledflag4", NullValueHandling = NullValueHandling.Ignore)]
        public ArakGroundhog? Grade9Swdfilledflag4 { get; set; }

        [JsonProperty("grade9swdfilledflag5", NullValueHandling = NullValueHandling.Ignore)]
        public ArakGroundhog? Grade9Swdfilledflag5 { get; set; }

        [JsonProperty("grade9swdapplicants4", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? Grade9Swdapplicants4 { get; set; }

        [JsonProperty("grade9swdapplicantsperseat4", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? Grade9Swdapplicantsperseat4 { get; set; }

        private TrapaniSnowLeopard grade9Swdapplicants5;

        public TrapaniSnowLeopard GetGrade9Swdapplicants5()
        {
            return grade9Swdapplicants5;
        }

        public void SetGrade9Swdapplicants5(TrapaniSnowLeopard value)
        {
            grade9Swdapplicants5 = value;
        }

        private TrapaniSnowLeopard grade9Swdapplicantsperseat5;

        public TrapaniSnowLeopard GetGrade9Swdapplicantsperseat5()
        {
            return grade9Swdapplicantsperseat5;
        }

        public void SetGrade9Swdapplicantsperseat5(TrapaniSnowLeopard value)
        {
            grade9Swdapplicantsperseat5 = value;
        }

        [JsonProperty("seats104", NullValueHandling = NullValueHandling.Ignore)]
        public Seats101? Seats104 { get; set; }

        [JsonProperty("seats105", NullValueHandling = NullValueHandling.Ignore)]
        public Seats101? Seats105 { get; set; }

        [JsonProperty("admissionspriority33", NullValueHandling = NullValueHandling.Ignore)]
        public Admissionspriority? Admissionspriority33 { get; set; }

        [JsonProperty("admissionspriority14", NullValueHandling = NullValueHandling.Ignore)]
        public string Admissionspriority14 { get; set; }

        [JsonProperty("admissionspriority24", NullValueHandling = NullValueHandling.Ignore)]
        public string Admissionspriority24 { get; set; }

        [JsonProperty("admissionspriority34", NullValueHandling = NullValueHandling.Ignore)]
        public Admissionspriority? Admissionspriority34 { get; set; }

        [JsonProperty("admissionspriority15", NullValueHandling = NullValueHandling.Ignore)]
        public string Admissionspriority15 { get; set; }

        [JsonProperty("admissionspriority25", NullValueHandling = NullValueHandling.Ignore)]
        public string Admissionspriority25 { get; set; }

        [JsonProperty("admissionspriority35", NullValueHandling = NullValueHandling.Ignore)]
        public Admissionspriority? Admissionspriority35 { get; set; }

        [JsonProperty("eligibility6", NullValueHandling = NullValueHandling.Ignore)]
        public string Eligibility6 { get; set; }

        [JsonProperty("auditioninformation1", NullValueHandling = NullValueHandling.Ignore)]
        public string Auditioninformation1 { get; set; }

        [JsonProperty("auditioninformation2", NullValueHandling = NullValueHandling.Ignore)]
        public string Auditioninformation2 { get; set; }

        [JsonProperty("auditioninformation3", NullValueHandling = NullValueHandling.Ignore)]
        public string Auditioninformation3 { get; set; }

        [JsonProperty("auditioninformation4", NullValueHandling = NullValueHandling.Ignore)]
        public string Auditioninformation4 { get; set; }

        [JsonProperty("auditioninformation5", NullValueHandling = NullValueHandling.Ignore)]
        public string Auditioninformation5 { get; set; }

        [JsonProperty("common_audition1", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? CommonAudition1 { get; set; }

        [JsonProperty("common_audition2", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? CommonAudition2 { get; set; }

        [JsonProperty("common_audition3", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? CommonAudition3 { get; set; }

        [JsonProperty("common_audition4", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? CommonAudition4 { get; set; }

        [JsonProperty("common_audition5", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? CommonAudition5 { get; set; }

        [JsonProperty("ptech", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? Ptech { get; set; }

        [JsonProperty("specialized", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? Specialized { get; set; }

        [JsonProperty("seats1specialized", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? Seats1Specialized { get; set; }

        [JsonProperty("applicants1specialized", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? Applicants1Specialized { get; set; }

        [JsonProperty("appperseat1specialized", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? Appperseat1Specialized { get; set; }

        [JsonProperty("eligibility2", NullValueHandling = NullValueHandling.Ignore)]
        public string Eligibility2 { get; set; }

        [JsonProperty("academicopportunities6", NullValueHandling = NullValueHandling.Ignore)]
        public string Academicopportunities6 { get; set; }

        [JsonProperty("requirement4_4", NullValueHandling = NullValueHandling.Ignore)]
        public Requirement44 Requirement44 { get; set; }

        [JsonProperty("eligibility4", NullValueHandling = NullValueHandling.Ignore)]
        public string Eligibility4 { get; set; }

        [JsonProperty("prgdesc6", NullValueHandling = NullValueHandling.Ignore)]
        public string Prgdesc6 { get; set; }

        [JsonProperty("requirement1_6", NullValueHandling = NullValueHandling.Ignore)]
        public string Requirement16 { get; set; }

        [JsonProperty("requirement2_6", NullValueHandling = NullValueHandling.Ignore)]
        public string Requirement26 { get; set; }

        [JsonProperty("requirement3_6", NullValueHandling = NullValueHandling.Ignore)]
        public string Requirement36 { get; set; }

        [JsonProperty("requirement4_6", NullValueHandling = NullValueHandling.Ignore)]
        public string Requirement46 { get; set; }

        [JsonProperty("requirement5_6", NullValueHandling = NullValueHandling.Ignore)]
        public string Requirement56 { get; set; }

        [JsonProperty("interest6", NullValueHandling = NullValueHandling.Ignore)]
        public Interest1? Interest6 { get; set; }

        private TrapaniSnowLeopard seats9Ge6;

        public TrapaniSnowLeopard GetSeats9Ge6()
        {
            return seats9Ge6;
        }

        public void SetSeats9Ge6(TrapaniSnowLeopard value)
        {
            seats9Ge6 = value;
        }

        [JsonProperty("grade9gefilledflag6", NullValueHandling = NullValueHandling.Ignore)]
        public ArakGroundhog? Grade9Gefilledflag6 { get; set; }

        private TrapaniSnowLeopard grade9Geapplicants6;

        public TrapaniSnowLeopard GetGrade9Geapplicants6()
        {
            return grade9Geapplicants6;
        }

        public void SetGrade9Geapplicants6(TrapaniSnowLeopard value)
        {
            grade9Geapplicants6 = value;
        }

        private TrapaniSnowLeopard grade9Geapplicantsperseat6;

        public TrapaniSnowLeopard GetGrade9Geapplicantsperseat6()
        {
            return grade9Geapplicantsperseat6;
        }

        public void SetGrade9Geapplicantsperseat6(TrapaniSnowLeopard value)
        {
            grade9Geapplicantsperseat6 = value;
        }

        private TrapaniSnowLeopard seats9Swd6;

        public TrapaniSnowLeopard GetSeats9Swd6()
        {
            return seats9Swd6;
        }

        public void SetSeats9Swd6(TrapaniSnowLeopard value)
        {
            seats9Swd6 = value;
        }

        [JsonProperty("grade9swdfilledflag6", NullValueHandling = NullValueHandling.Ignore)]
        public ArakGroundhog? Grade9Swdfilledflag6 { get; set; }

        private TrapaniSnowLeopard grade9Swdapplicants6;

        public TrapaniSnowLeopard GetGrade9Swdapplicants6()
        {
            return grade9Swdapplicants6;
        }

        public void SetGrade9Swdapplicants6(TrapaniSnowLeopard value)
        {
            grade9Swdapplicants6 = value;
        }

        private TrapaniSnowLeopard grade9Swdapplicantsperseat6;

        public TrapaniSnowLeopard GetGrade9Swdapplicantsperseat6()
        {
            return grade9Swdapplicantsperseat6;
        }

        public void SetGrade9Swdapplicantsperseat6(TrapaniSnowLeopard value)
        {
            grade9Swdapplicantsperseat6 = value;
        }

        [JsonProperty("seats106", NullValueHandling = NullValueHandling.Ignore)]
        public Seats101? Seats106 { get; set; }

        [JsonProperty("admissionspriority16", NullValueHandling = NullValueHandling.Ignore)]
        public string Admissionspriority16 { get; set; }

        [JsonProperty("auditioninformation6", NullValueHandling = NullValueHandling.Ignore)]
        public string Auditioninformation6 { get; set; }

        [JsonProperty("common_audition6", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? CommonAudition6 { get; set; }

        [JsonProperty("prgdesc7", NullValueHandling = NullValueHandling.Ignore)]
        public string Prgdesc7 { get; set; }

        [JsonProperty("prgdesc8", NullValueHandling = NullValueHandling.Ignore)]
        public string Prgdesc8 { get; set; }

        [JsonProperty("prgdesc9", NullValueHandling = NullValueHandling.Ignore)]
        public string Prgdesc9 { get; set; }

        [JsonProperty("requirement1_7", NullValueHandling = NullValueHandling.Ignore)]
        public string Requirement17 { get; set; }

        [JsonProperty("requirement1_8", NullValueHandling = NullValueHandling.Ignore)]
        public string Requirement18 { get; set; }

        [JsonProperty("requirement2_7", NullValueHandling = NullValueHandling.Ignore)]
        public string Requirement27 { get; set; }

        [JsonProperty("requirement2_8", NullValueHandling = NullValueHandling.Ignore)]
        public string Requirement28 { get; set; }

        [JsonProperty("requirement3_7", NullValueHandling = NullValueHandling.Ignore)]
        public string Requirement37 { get; set; }

        [JsonProperty("requirement3_8", NullValueHandling = NullValueHandling.Ignore)]
        public string Requirement38 { get; set; }

        [JsonProperty("requirement4_8", NullValueHandling = NullValueHandling.Ignore)]
        public string Requirement48 { get; set; }

        [JsonProperty("offer_rate1_6", NullValueHandling = NullValueHandling.Ignore)]
        public string OfferRate16 { get; set; }

        [JsonProperty("offer_rate1_7", NullValueHandling = NullValueHandling.Ignore)]
        public string OfferRate17 { get; set; }

        [JsonProperty("offer_rate1_8", NullValueHandling = NullValueHandling.Ignore)]
        public string OfferRate18 { get; set; }

        [JsonProperty("program7", NullValueHandling = NullValueHandling.Ignore)]
        public string Program7 { get; set; }

        [JsonProperty("program8", NullValueHandling = NullValueHandling.Ignore)]
        public string Program8 { get; set; }

        [JsonProperty("program9", NullValueHandling = NullValueHandling.Ignore)]
        public string Program9 { get; set; }

        [JsonProperty("program10", NullValueHandling = NullValueHandling.Ignore)]
        public string Program10 { get; set; }

        [JsonProperty("code7", NullValueHandling = NullValueHandling.Ignore)]
        public string Code7 { get; set; }

        [JsonProperty("code8", NullValueHandling = NullValueHandling.Ignore)]
        public string Code8 { get; set; }

        [JsonProperty("code9", NullValueHandling = NullValueHandling.Ignore)]
        public string Code9 { get; set; }

        [JsonProperty("code10", NullValueHandling = NullValueHandling.Ignore)]
        public string Code10 { get; set; }

        [JsonProperty("interest7", NullValueHandling = NullValueHandling.Ignore)]
        public Interest1? Interest7 { get; set; }

        [JsonProperty("interest8", NullValueHandling = NullValueHandling.Ignore)]
        public Interest1? Interest8 { get; set; }

        [JsonProperty("interest9", NullValueHandling = NullValueHandling.Ignore)]
        public Interest1? Interest9 { get; set; }

        [JsonProperty("method7", NullValueHandling = NullValueHandling.Ignore)]
        public Method? Method7 { get; set; }

        [JsonProperty("method8", NullValueHandling = NullValueHandling.Ignore)]
        public Method? Method8 { get; set; }

        [JsonProperty("method9", NullValueHandling = NullValueHandling.Ignore)]
        public Method? Method9 { get; set; }

        [JsonProperty("method10", NullValueHandling = NullValueHandling.Ignore)]
        public Method? Method10 { get; set; }

        private TrapaniSnowLeopard seats9Ge7;

        public TrapaniSnowLeopard GetSeats9Ge7()
        {
            return seats9Ge7;
        }

        public void SetSeats9Ge7(TrapaniSnowLeopard value)
        {
            seats9Ge7 = value;
        }

        private TrapaniSnowLeopard seats9Ge8;

        public TrapaniSnowLeopard GetSeats9Ge8()
        {
            return seats9Ge8;
        }

        public void SetSeats9Ge8(TrapaniSnowLeopard value)
        {
            seats9Ge8 = value;
        }

        private TrapaniSnowLeopard seats9Ge9;

        public TrapaniSnowLeopard GetSeats9Ge9()
        {
            return seats9Ge9;
        }

        public void SetSeats9Ge9(TrapaniSnowLeopard value)
        {
            seats9Ge9 = value;
        }

        [JsonProperty("grade9gefilledflag7", NullValueHandling = NullValueHandling.Ignore)]
        public ArakGroundhog? Grade9Gefilledflag7 { get; set; }

        [JsonProperty("grade9gefilledflag8", NullValueHandling = NullValueHandling.Ignore)]
        public ArakGroundhog? Grade9Gefilledflag8 { get; set; }

        [JsonProperty("grade9gefilledflag9", NullValueHandling = NullValueHandling.Ignore)]
        public ArakGroundhog? Grade9Gefilledflag9 { get; set; }

        private TrapaniSnowLeopard grade9Geapplicants7;

        public TrapaniSnowLeopard GetGrade9Geapplicants7()
        {
            return grade9Geapplicants7;
        }

        public void SetGrade9Geapplicants7(TrapaniSnowLeopard value)
        {
            grade9Geapplicants7 = value;
        }

        private TrapaniSnowLeopard grade9Geapplicantsperseat7;

        public TrapaniSnowLeopard GetGrade9Geapplicantsperseat7()
        {
            return grade9Geapplicantsperseat7;
        }

        public void SetGrade9Geapplicantsperseat7(TrapaniSnowLeopard value)
        {
            grade9Geapplicantsperseat7 = value;
        }

        private TrapaniSnowLeopard grade9Geapplicants8;

        public TrapaniSnowLeopard GetGrade9Geapplicants8()
        {
            return grade9Geapplicants8;
        }

        public void SetGrade9Geapplicants8(TrapaniSnowLeopard value)
        {
            grade9Geapplicants8 = value;
        }

        private TrapaniSnowLeopard grade9Geapplicantsperseat8;

        public TrapaniSnowLeopard GetGrade9Geapplicantsperseat8()
        {
            return grade9Geapplicantsperseat8;
        }

        public void SetGrade9Geapplicantsperseat8(TrapaniSnowLeopard value)
        {
            grade9Geapplicantsperseat8 = value;
        }

        private TrapaniSnowLeopard grade9Geapplicants9;

        public TrapaniSnowLeopard GetGrade9Geapplicants9()
        {
            return grade9Geapplicants9;
        }

        public void SetGrade9Geapplicants9(TrapaniSnowLeopard value)
        {
            grade9Geapplicants9 = value;
        }

        private TrapaniSnowLeopard grade9Geapplicantsperseat9;

        public TrapaniSnowLeopard GetGrade9Geapplicantsperseat9()
        {
            return grade9Geapplicantsperseat9;
        }

        public void SetGrade9Geapplicantsperseat9(TrapaniSnowLeopard value)
        {
            grade9Geapplicantsperseat9 = value;
        }

        private TrapaniSnowLeopard seats9Swd7;

        public TrapaniSnowLeopard GetSeats9Swd7()
        {
            return seats9Swd7;
        }

        public void SetSeats9Swd7(TrapaniSnowLeopard value)
        {
            seats9Swd7 = value;
        }

        private TrapaniSnowLeopard seats9Swd8;

        public TrapaniSnowLeopard GetSeats9Swd8()
        {
            return seats9Swd8;
        }

        public void SetSeats9Swd8(TrapaniSnowLeopard value)
        {
            seats9Swd8 = value;
        }

        private TrapaniSnowLeopard seats9Swd9;

        public TrapaniSnowLeopard GetSeats9Swd9()
        {
            return seats9Swd9;
        }

        public void SetSeats9Swd9(TrapaniSnowLeopard value)
        {
            seats9Swd9 = value;
        }

        [JsonProperty("grade9swdfilledflag7", NullValueHandling = NullValueHandling.Ignore)]
        public ArakGroundhog? Grade9Swdfilledflag7 { get; set; }

        [JsonProperty("grade9swdfilledflag8", NullValueHandling = NullValueHandling.Ignore)]
        public ArakGroundhog? Grade9Swdfilledflag8 { get; set; }

        [JsonProperty("grade9swdfilledflag9", NullValueHandling = NullValueHandling.Ignore)]
        public ArakGroundhog? Grade9Swdfilledflag9 { get; set; }

        private TrapaniSnowLeopard grade9Swdapplicants7;

        public TrapaniSnowLeopard GetGrade9Swdapplicants7()
        {
            return grade9Swdapplicants7;
        }

        public void SetGrade9Swdapplicants7(TrapaniSnowLeopard value)
        {
            grade9Swdapplicants7 = value;
        }

        private TrapaniSnowLeopard grade9Swdapplicantsperseat7;

        public TrapaniSnowLeopard GetGrade9Swdapplicantsperseat7()
        {
            return grade9Swdapplicantsperseat7;
        }

        public void SetGrade9Swdapplicantsperseat7(TrapaniSnowLeopard value)
        {
            grade9Swdapplicantsperseat7 = value;
        }

        private TrapaniSnowLeopard grade9Swdapplicants8;

        public TrapaniSnowLeopard GetGrade9Swdapplicants8()
        {
            return grade9Swdapplicants8;
        }

        public void SetGrade9Swdapplicants8(TrapaniSnowLeopard value)
        {
            grade9Swdapplicants8 = value;
        }

        private TrapaniSnowLeopard grade9Swdapplicantsperseat8;

        public TrapaniSnowLeopard GetGrade9Swdapplicantsperseat8()
        {
            return grade9Swdapplicantsperseat8;
        }

        public void SetGrade9Swdapplicantsperseat8(TrapaniSnowLeopard value)
        {
            grade9Swdapplicantsperseat8 = value;
        }

        private TrapaniSnowLeopard grade9Swdapplicants9;

        public TrapaniSnowLeopard GetGrade9Swdapplicants9()
        {
            return grade9Swdapplicants9;
        }

        public void SetGrade9Swdapplicants9(TrapaniSnowLeopard value)
        {
            grade9Swdapplicants9 = value;
        }

        private TrapaniSnowLeopard grade9Swdapplicantsperseat9;

        public TrapaniSnowLeopard GetGrade9Swdapplicantsperseat9()
        {
            return grade9Swdapplicantsperseat9;
        }

        public void SetGrade9Swdapplicantsperseat9(TrapaniSnowLeopard value)
        {
            grade9Swdapplicantsperseat9 = value;
        }

        [JsonProperty("seats107", NullValueHandling = NullValueHandling.Ignore)]
        public Seats101? Seats107 { get; set; }

        [JsonProperty("seats108", NullValueHandling = NullValueHandling.Ignore)]
        public Seats101? Seats108 { get; set; }

        [JsonProperty("seats109", NullValueHandling = NullValueHandling.Ignore)]
        public Seats101? Seats109 { get; set; }

        [JsonProperty("admissionspriority26", NullValueHandling = NullValueHandling.Ignore)]
        public Admissionspriority? Admissionspriority26 { get; set; }

        [JsonProperty("admissionspriority17", NullValueHandling = NullValueHandling.Ignore)]
        public string Admissionspriority17 { get; set; }

        [JsonProperty("admissionspriority27", NullValueHandling = NullValueHandling.Ignore)]
        public Admissionspriority? Admissionspriority27 { get; set; }

        [JsonProperty("admissionspriority18", NullValueHandling = NullValueHandling.Ignore)]
        public string Admissionspriority18 { get; set; }

        [JsonProperty("admissionspriority28", NullValueHandling = NullValueHandling.Ignore)]
        public string Admissionspriority28 { get; set; }

        [JsonProperty("admissionspriority19", NullValueHandling = NullValueHandling.Ignore)]
        public string Admissionspriority19 { get; set; }

        [JsonProperty("admissionspriority29", NullValueHandling = NullValueHandling.Ignore)]
        public Admissionspriority? Admissionspriority29 { get; set; }

        [JsonProperty("eligibility10", NullValueHandling = NullValueHandling.Ignore)]
        public string Eligibility10 { get; set; }

        [JsonProperty("auditioninformation7", NullValueHandling = NullValueHandling.Ignore)]
        public string Auditioninformation7 { get; set; }

        [JsonProperty("auditioninformation8", NullValueHandling = NullValueHandling.Ignore)]
        public string Auditioninformation8 { get; set; }

        [JsonProperty("common_audition7", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? CommonAudition7 { get; set; }

        [JsonProperty("common_audition8", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? CommonAudition8 { get; set; }

        [JsonProperty("eligibility8", NullValueHandling = NullValueHandling.Ignore)]
        public string Eligibility8 { get; set; }

        [JsonProperty("diversity_in_admissions", NullValueHandling = NullValueHandling.Ignore)]
        public string DiversityInAdmissions { get; set; }

        [JsonProperty("girls", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? Girls { get; set; }

        [JsonProperty("eligibility9", NullValueHandling = NullValueHandling.Ignore)]
        public string Eligibility9 { get; set; }

        [JsonProperty("prgdesc10", NullValueHandling = NullValueHandling.Ignore)]
        public string Prgdesc10 { get; set; }

        [JsonProperty("requirement1_9", NullValueHandling = NullValueHandling.Ignore)]
        public string Requirement19 { get; set; }

        [JsonProperty("requirement2_9", NullValueHandling = NullValueHandling.Ignore)]
        public string Requirement29 { get; set; }

        [JsonProperty("requirement3_9", NullValueHandling = NullValueHandling.Ignore)]
        public string Requirement39 { get; set; }

        [JsonProperty("requirement4_9", NullValueHandling = NullValueHandling.Ignore)]
        public string Requirement49 { get; set; }

        [JsonProperty("requirement5_9", NullValueHandling = NullValueHandling.Ignore)]
        public string Requirement59 { get; set; }

        [JsonProperty("requirement6_9", NullValueHandling = NullValueHandling.Ignore)]
        public Interest1? Requirement69 { get; set; }

        [JsonProperty("offer_rate1_9", NullValueHandling = NullValueHandling.Ignore)]
        public string OfferRate19 { get; set; }

        [JsonProperty("interest10", NullValueHandling = NullValueHandling.Ignore)]
        public Interest1? Interest10 { get; set; }

        [JsonProperty("seats9ge10", NullValueHandling = NullValueHandling.Ignore)]
        public ArakGroundhog? Seats9Ge10 { get; set; }

        [JsonProperty("grade9gefilledflag10", NullValueHandling = NullValueHandling.Ignore)]
        public ArakGroundhog? Grade9Gefilledflag10 { get; set; }

        [JsonProperty("grade9geapplicants10", NullValueHandling = NullValueHandling.Ignore)]
        public ArakGroundhog? Grade9Geapplicants10 { get; set; }

        [JsonProperty("grade9geapplicantsperseat10", NullValueHandling = NullValueHandling.Ignore)]
        public ArakGroundhog? Grade9Geapplicantsperseat10 { get; set; }

        [JsonProperty("seats9swd10", NullValueHandling = NullValueHandling.Ignore)]
        public ArakGroundhog? Seats9Swd10 { get; set; }

        [JsonProperty("grade9swdfilledflag10", NullValueHandling = NullValueHandling.Ignore)]
        public ArakGroundhog? Grade9Swdfilledflag10 { get; set; }

        [JsonProperty("grade9swdapplicants10", NullValueHandling = NullValueHandling.Ignore)]
        public ArakGroundhog? Grade9Swdapplicants10 { get; set; }

        [JsonProperty("grade9swdapplicantsperseat10", NullValueHandling = NullValueHandling.Ignore)]
        public ArakGroundhog? Grade9Swdapplicantsperseat10 { get; set; }

        [JsonProperty("seats1010", NullValueHandling = NullValueHandling.Ignore)]
        public Seats101? Seats1010 { get; set; }

        [JsonProperty("admissionspriority110", NullValueHandling = NullValueHandling.Ignore)]
        public string Admissionspriority110 { get; set; }

        [JsonProperty("admissionspriority210", NullValueHandling = NullValueHandling.Ignore)]
        public Admissionspriority? Admissionspriority210 { get; set; }

        [JsonProperty("offer_rate3_2", NullValueHandling = NullValueHandling.Ignore)]
        public string OfferRate32 { get; set; }

        [JsonProperty("admissionspriority42", NullValueHandling = NullValueHandling.Ignore)]
        public Admissionspriority? Admissionspriority42 { get; set; }

        [JsonProperty("geoeligibility", NullValueHandling = NullValueHandling.Ignore)]
        public string Geoeligibility { get; set; }

        [JsonProperty("eligibility7", NullValueHandling = NullValueHandling.Ignore)]
        public string Eligibility7 { get; set; }

        [JsonProperty("eligibility5", NullValueHandling = NullValueHandling.Ignore)]
        public string Eligibility5 { get; set; }

        [JsonProperty("transfer", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? Transfer { get; set; }

        [JsonProperty("admissionspriority38", NullValueHandling = NullValueHandling.Ignore)]
        public Admissionspriority? Admissionspriority38 { get; set; }

        [JsonProperty("requirement4_7", NullValueHandling = NullValueHandling.Ignore)]
        public string Requirement47 { get; set; }

        [JsonProperty("requirement5_7", NullValueHandling = NullValueHandling.Ignore)]
        public string Requirement57 { get; set; }

        [JsonProperty("requirement8_5", NullValueHandling = NullValueHandling.Ignore)]
        public string Requirement85 { get; set; }

        [JsonProperty("requirement5_8", NullValueHandling = NullValueHandling.Ignore)]
        public string Requirement58 { get; set; }

        [JsonProperty("requirement6_6", NullValueHandling = NullValueHandling.Ignore)]
        public string Requirement66 { get; set; }

        [JsonProperty("requirement6_8", NullValueHandling = NullValueHandling.Ignore)]
        public Interest1? Requirement68 { get; set; }

        [JsonProperty("seats2specialized", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? Seats2Specialized { get; set; }

        [JsonProperty("seats3specialized", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? Seats3Specialized { get; set; }

        [JsonProperty("seats4specialized", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? Seats4Specialized { get; set; }

        [JsonProperty("seats5specialized", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? Seats5Specialized { get; set; }

        [JsonProperty("seats6specialized", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? Seats6Specialized { get; set; }

        [JsonProperty("applicants2specialized", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? Applicants2Specialized { get; set; }

        [JsonProperty("applicants3specialized", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? Applicants3Specialized { get; set; }

        [JsonProperty("applicants4specialized", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? Applicants4Specialized { get; set; }

        [JsonProperty("applicants5specialized", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? Applicants5Specialized { get; set; }

        [JsonProperty("applicants6specialized", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? Applicants6Specialized { get; set; }

        [JsonProperty("appperseat2specialized", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? Appperseat2Specialized { get; set; }

        [JsonProperty("appperseat3specialized", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? Appperseat3Specialized { get; set; }

        [JsonProperty("appperseat4specialized", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? Appperseat4Specialized { get; set; }

        [JsonProperty("appperseat5specialized", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? Appperseat5Specialized { get; set; }

        [JsonProperty("appperseat6specialized", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? Appperseat6Specialized { get; set; }

        [JsonProperty("requirement6_7", NullValueHandling = NullValueHandling.Ignore)]
        public string Requirement67 { get; set; }

        [JsonProperty("offer_rate3_3", NullValueHandling = NullValueHandling.Ignore)]
        public string OfferRate33 { get; set; }

        [JsonProperty("admissionspriority43", NullValueHandling = NullValueHandling.Ignore)]
        public Admissionspriority? Admissionspriority43 { get; set; }

        [JsonProperty("requirement8_1", NullValueHandling = NullValueHandling.Ignore)]
        public string Requirement81 { get; set; }

        [JsonProperty("requirement8_2", NullValueHandling = NullValueHandling.Ignore)]
        public string Requirement82 { get; set; }
    }
        public partial class Welcome
    {
        public static Welcome[] FromJson(string json) => JsonConvert.DeserializeObject<Welcome[]>(json);
    

}
}
internal static class Converter
{
    public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
    {
        MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
        DateParseHandling = DateParseHandling.None,
        Converters =
            {
                AdmissionspriorityConverter.Singleton,
                BorocodeConverter.Singleton,
                BoroughConverter.Singleton,
                DiplomaendorsementsConverter.Singleton,
                TypeEnumConverter.Singleton,
                ArakGroundhogConverter.Singleton,
                TrapaniSnowLeopardConverter.Singleton,
                Grades2019Converter.Singleton,
                Interest1Converter.Singleton,
                MethodConverter.Singleton,
                SchoolAccessibilityConverter.Singleton,
                Seats101Converter.Singleton,
                StateCodeConverter.Singleton,
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
    };
}

internal class ParseStringConverter : JsonConverter
{
    public override bool CanConvert(Type t) => t == typeof(long) || t == typeof(long?);

    public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
    {
        if (reader.TokenType == JsonToken.Null) return null;
        var value = serializer.Deserialize<string>(reader);
        long l;
        if (Int64.TryParse(value, out l))
        {
            return l;
        }
        throw new Exception("Cannot unmarshal type long");
    }

    public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
    {
        if (untypedValue == null)
        {
            serializer.Serialize(writer, null);
            return;
        }
        var value = (long)untypedValue;
        serializer.Serialize(writer, value.ToString());
        return;
    }

    public static readonly ParseStringConverter Singleton = new ParseStringConverter();
}

internal class AdmissionspriorityConverter : JsonConverter
{
    public override bool CanConvert(Type t) => t == typeof(Admissionspriority) || t == typeof(Admissionspriority?);

    public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
    {
        if (reader.TokenType == JsonToken.Null) return null;
        var value = serializer.Deserialize<string>(reader);
        switch (value)
        {
            case "Then to Brooklyn students or residents":
                return Admissionspriority.ThenToBrooklynStudentsOrResidents;
            case "Then to New York City residents":
                return Admissionspriority.ThenToNewYorkCityResidents;
            case "Then to Queens students or residents":
                return Admissionspriority.ThenToQueensStudentsOrResidents;
        }
        throw new Exception("Cannot unmarshal type Admissionspriority");
    }

    public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
    {
        if (untypedValue == null)
        {
            serializer.Serialize(writer, null);
            return;
        }
        var value = (Admissionspriority)untypedValue;
        switch (value)
        {
            case Admissionspriority.ThenToBrooklynStudentsOrResidents:
                serializer.Serialize(writer, "Then to Brooklyn students or residents");
                return;
            case Admissionspriority.ThenToNewYorkCityResidents:
                serializer.Serialize(writer, "Then to New York City residents");
                return;
            case Admissionspriority.ThenToQueensStudentsOrResidents:
                serializer.Serialize(writer, "Then to Queens students or residents");
                return;
        }
        throw new Exception("Cannot marshal type Admissionspriority");
    }

    public static readonly AdmissionspriorityConverter Singleton = new AdmissionspriorityConverter();
}

internal class BorocodeConverter : JsonConverter
{
    public override bool CanConvert(Type t) => t == typeof(Borocode) || t == typeof(Borocode?);

    public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
    {
        if (reader.TokenType == JsonToken.Null) return null;
        var value = serializer.Deserialize<string>(reader);
        switch (value)
        {
            case "K":
                return Borocode.K;
            case "M":
                return Borocode.M;
            case "Q":
                return Borocode.Q;
            case "R":
                return Borocode.R;
            case "X":
                return Borocode.X;
        }
        throw new Exception("Cannot unmarshal type Borocode");
    }

    public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
    {
        if (untypedValue == null)
        {
            serializer.Serialize(writer, null);
            return;
        }
        var value = (Borocode)untypedValue;
        switch (value)
        {
            case Borocode.K:
                serializer.Serialize(writer, "K");
                return;
            case Borocode.M:
                serializer.Serialize(writer, "M");
                return;
            case Borocode.Q:
                serializer.Serialize(writer, "Q");
                return;
            case Borocode.R:
                serializer.Serialize(writer, "R");
                return;
            case Borocode.X:
                serializer.Serialize(writer, "X");
                return;
        }
        throw new Exception("Cannot marshal type Borocode");
    }

    public static readonly BorocodeConverter Singleton = new BorocodeConverter();
}

internal class BoroughConverter : JsonConverter
{
    public override bool CanConvert(Type t) => t == typeof(Borough) || t == typeof(Borough?);

    public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
    {
        if (reader.TokenType == JsonToken.Null) return null;
        var value = serializer.Deserialize<string>(reader);
        switch (value)
        {
            case "BRONX":
                return Borough.Bronx;
            case "BROOKLYN":
                return Borough.Brooklyn;
            case "MANHATTAN":
                return Borough.Manhattan;
            case "QUEENS":
                return Borough.Queens;
            case "STATEN IS":
                return Borough.StatenIs;
        }
        throw new Exception("Cannot unmarshal type Borough");
    }

    public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
    {
        if (untypedValue == null)
        {
            serializer.Serialize(writer, null);
            return;
        }
        var value = (Borough)untypedValue;
        switch (value)
        {
            case Borough.Bronx:
                serializer.Serialize(writer, "BRONX");
                return;
            case Borough.Brooklyn:
                serializer.Serialize(writer, "BROOKLYN");
                return;
            case Borough.Manhattan:
                serializer.Serialize(writer, "MANHATTAN");
                return;
            case Borough.Queens:
                serializer.Serialize(writer, "QUEENS");
                return;
            case Borough.StatenIs:
                serializer.Serialize(writer, "STATEN IS");
                return;
        }
        throw new Exception("Cannot marshal type Borough");
    }

    public static readonly BoroughConverter Singleton = new BoroughConverter();
}

internal class DiplomaendorsementsConverter : JsonConverter
{
    public override bool CanConvert(Type t) => t == typeof(Diplomaendorsements) || t == typeof(Diplomaendorsements?);

    public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
    {
        if (reader.TokenType == JsonToken.Null) return null;
        var value = serializer.Deserialize<string>(reader);
        switch (value)
        {
            case "Arts, CTE, Math, Science":
                return Diplomaendorsements.ArtsCteMathScience;
            case "Arts, CTE, Science":
                return Diplomaendorsements.ArtsCteScience;
            case "Math":
                return Diplomaendorsements.Math;
            case "Math, Science":
                return Diplomaendorsements.MathScience;
            case "Science":
                return Diplomaendorsements.Science;
        }
        throw new Exception("Cannot unmarshal type Diplomaendorsements");
    }

    public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
    {
        if (untypedValue == null)
        {
            serializer.Serialize(writer, null);
            return;
        }
        var value = (Diplomaendorsements)untypedValue;
        switch (value)
        {
            case Diplomaendorsements.ArtsCteMathScience:
                serializer.Serialize(writer, "Arts, CTE, Math, Science");
                return;
            case Diplomaendorsements.ArtsCteScience:
                serializer.Serialize(writer, "Arts, CTE, Science");
                return;
            case Diplomaendorsements.Math:
                serializer.Serialize(writer, "Math");
                return;
            case Diplomaendorsements.MathScience:
                serializer.Serialize(writer, "Math, Science");
                return;
            case Diplomaendorsements.Science:
                serializer.Serialize(writer, "Science");
                return;
        }
        throw new Exception("Cannot marshal type Diplomaendorsements");
    }

    public static readonly DiplomaendorsementsConverter Singleton = new DiplomaendorsementsConverter();
}

internal class TypeEnumConverter : JsonConverter
{
    public override bool CanConvert(Type t) => t == typeof(TypeEnum) || t == typeof(TypeEnum?);

    public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
    {
        if (reader.TokenType == JsonToken.Null) return null;
        var value = serializer.Deserialize<string>(reader);
        if (value == "Point")
        {
            return TypeEnum.Point;
        }
        throw new Exception("Cannot unmarshal type TypeEnum");
    }

    public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
    {
        if (untypedValue == null)
        {
            serializer.Serialize(writer, null);
            return;
        }
        var value = (TypeEnum)untypedValue;
        if (value == TypeEnum.Point)
        {
            serializer.Serialize(writer, "Point");
            return;
        }
        throw new Exception("Cannot marshal type TypeEnum");
    }

    public static readonly TypeEnumConverter Singleton = new TypeEnumConverter();
}

internal class ArakGroundhogConverter : JsonConverter
{
    public override bool CanConvert(Type t) => t == typeof(ArakGroundhog) || t == typeof(ArakGroundhog?);

    public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
    {
        if (reader.TokenType == JsonToken.Null) return null;
        var value = serializer.Deserialize<string>(reader);
        switch (value)
        {
            case "N":
                return ArakGroundhog.N;
            case "N/A - new program":
                return ArakGroundhog.NANewProgram;
            case "N/A - transfer school":
                return ArakGroundhog.NATransferSchool;
            case "N/A - zoned program":
                return ArakGroundhog.NAZonedProgram;
            case "Y":
                return ArakGroundhog.Y;
        }
        throw new Exception("Cannot unmarshal type ArakGroundhog");
    }

    public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
    {
        if (untypedValue == null)
        {
            serializer.Serialize(writer, null);
            return;
        }
        var value = (ArakGroundhog)untypedValue;
        switch (value)
        {
            case ArakGroundhog.N:
                serializer.Serialize(writer, "N");
                return;
            case ArakGroundhog.NANewProgram:
                serializer.Serialize(writer, "N/A - new program");
                return;
            case ArakGroundhog.NATransferSchool:
                serializer.Serialize(writer, "N/A - transfer school");
                return;
            case ArakGroundhog.NAZonedProgram:
                serializer.Serialize(writer, "N/A - zoned program");
                return;
            case ArakGroundhog.Y:
                serializer.Serialize(writer, "Y");
                return;
        }
        throw new Exception("Cannot marshal type ArakGroundhog");
    }

    public static readonly ArakGroundhogConverter Singleton = new ArakGroundhogConverter();
}

internal class TrapaniSnowLeopardConverter : JsonConverter
{
    public override bool CanConvert(Type t)
    {
        return t == typeof(TrapaniSnowLeopard);
    }

    public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
    {
        switch (reader.TokenType)
        {
            case JsonToken.String:
            case JsonToken.Date:
                var stringValue = serializer.Deserialize<string>(reader);
                switch (stringValue)
                {
                    case "N":
                        return new TrapaniSnowLeopard { Enum = ArakGroundhog.N };
                    case "N/A - new program":
                        return new TrapaniSnowLeopard { Enum = ArakGroundhog.NANewProgram };
                    case "N/A - transfer school":
                        return new TrapaniSnowLeopard { Enum = ArakGroundhog.NATransferSchool };
                    case "N/A - zoned program":
                        return new TrapaniSnowLeopard { Enum = ArakGroundhog.NAZonedProgram };
                    case "Y":
                        return new TrapaniSnowLeopard { Enum = ArakGroundhog.Y };
                }
                long l;
                if (Int64.TryParse(stringValue, out l))
                {
                    return new TrapaniSnowLeopard { Integer = l };
                }
                break;
        }
        throw new Exception("Cannot unmarshal type TrapaniSnowLeopard");
    }

    public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
    {
        var value = (TrapaniSnowLeopard)untypedValue;
        if (value.Enum != null)
        {
            switch (value.Enum)
            {
                case ArakGroundhog.N:
                    serializer.Serialize(writer, "N");
                    return;
                case ArakGroundhog.NANewProgram:
                    serializer.Serialize(writer, "N/A - new program");
                    return;
                case ArakGroundhog.NATransferSchool:
                    serializer.Serialize(writer, "N/A - transfer school");
                    return;
                case ArakGroundhog.NAZonedProgram:
                    serializer.Serialize(writer, "N/A - zoned program");
                    return;
                case ArakGroundhog.Y:
                    serializer.Serialize(writer, "Y");
                    return;
            }
        }
        if (value.Integer != null)
        {
            serializer.Serialize(writer, value.Integer.Value.ToString());
            return;
        }
        throw new Exception("Cannot marshal type TrapaniSnowLeopard");
    }

    public static readonly TrapaniSnowLeopardConverter Singleton = new TrapaniSnowLeopardConverter();
}

internal class Grades2019Converter : JsonConverter
{
    public override bool CanConvert(Type t) => t == typeof(Grades2019) || t == typeof(Grades2019?);

    public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
    {
        if (reader.TokenType == JsonToken.Null) return null;
        var value = serializer.Deserialize<string>(reader);
        switch (value)
        {
            case "6 to 11":
                return Grades2019.The6To11;
            case "6 to 12":
                return Grades2019.The6To12;
            case "7 to 12":
                return Grades2019.The7To12;
            case "9 to 12":
                return Grades2019.The9To12;
            case "K to 12":
                return Grades2019.KTo12;
            case "PK to 12":
                return Grades2019.PkTo12;
        }
        throw new Exception("Cannot unmarshal type Grades2019");
    }

    public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
    {
        if (untypedValue == null)
        {
            serializer.Serialize(writer, null);
            return;
        }
        var value = (Grades2019)untypedValue;
        switch (value)
        {
            case Grades2019.The6To11:
                serializer.Serialize(writer, "6 to 11");
                return;
            case Grades2019.The6To12:
                serializer.Serialize(writer, "6 to 12");
                return;
            case Grades2019.The7To12:
                serializer.Serialize(writer, "7 to 12");
                return;
            case Grades2019.The9To12:
                serializer.Serialize(writer, "9 to 12");
                return;
            case Grades2019.KTo12:
                serializer.Serialize(writer, "K to 12");
                return;
            case Grades2019.PkTo12:
                serializer.Serialize(writer, "PK to 12");
                return;
        }
        throw new Exception("Cannot marshal type Grades2019");
    }

    public static readonly Grades2019Converter Singleton = new Grades2019Converter();
}

internal class Interest1Converter : JsonConverter
{
    public override bool CanConvert(Type t) => t == typeof(Interest1) || t == typeof(Interest1?);

    public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
    {
        if (reader.TokenType == JsonToken.Null) return null;
        var value = serializer.Deserialize<string>(reader);
        switch (value)
        {
            case "Animal Science":
                return Interest1.AnimalScience;
            case "Architecture":
                return Interest1.Architecture;
            case "Business":
                return Interest1.Business;
            case "Communications":
                return Interest1.Communications;
            case "Computer Science & Technology":
                return Interest1.ComputerScienceTechnology;
            case "Cosmetology":
                return Interest1.Cosmetology;
            case "Culinary Arts":
                return Interest1.CulinaryArts;
            case "Engineering":
                return Interest1.Engineering;
            case "Environmental Science":
                return Interest1.EnvironmentalScience;
            case "Film/Video":
                return Interest1.FilmVideo;
            case "Health Professions":
                return Interest1.HealthProfessions;
            case "Hospitality, Travel, & Tourism":
                return Interest1.HospitalityTravelTourism;
            case "Humanities & Interdisciplinary":
                return Interest1.HumanitiesInterdisciplinary;
            case "JROTC":
                return Interest1.Jrotc;
            case "Law & Government":
                return Interest1.LawGovernment;
            case "Performing Arts":
                return Interest1.PerformingArts;
            case "Performing Arts/Visual Art & Design":
                return Interest1.PerformingArtsVisualArtDesign;
            case "Project-Based Learning":
                return Interest1.ProjectBasedLearning;
            case "Science & Math":
                return Interest1.ScienceMath;
            case "Teaching":
                return Interest1.Teaching;
            case "Visual Art & Design":
                return Interest1.VisualArtDesign;
            case "Zoned":
                return Interest1.Zoned;
        }
        throw new Exception("Cannot unmarshal type Interest1");
    }

    public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
    {
        if (untypedValue == null)
        {
            serializer.Serialize(writer, null);
            return;
        }
        var value = (Interest1)untypedValue;
        switch (value)
        {
            case Interest1.AnimalScience:
                serializer.Serialize(writer, "Animal Science");
                return;
            case Interest1.Architecture:
                serializer.Serialize(writer, "Architecture");
                return;
            case Interest1.Business:
                serializer.Serialize(writer, "Business");
                return;
            case Interest1.Communications:
                serializer.Serialize(writer, "Communications");
                return;
            case Interest1.ComputerScienceTechnology:
                serializer.Serialize(writer, "Computer Science & Technology");
                return;
            case Interest1.Cosmetology:
                serializer.Serialize(writer, "Cosmetology");
                return;
            case Interest1.CulinaryArts:
                serializer.Serialize(writer, "Culinary Arts");
                return;
            case Interest1.Engineering:
                serializer.Serialize(writer, "Engineering");
                return;
            case Interest1.EnvironmentalScience:
                serializer.Serialize(writer, "Environmental Science");
                return;
            case Interest1.FilmVideo:
                serializer.Serialize(writer, "Film/Video");
                return;
            case Interest1.HealthProfessions:
                serializer.Serialize(writer, "Health Professions");
                return;
            case Interest1.HospitalityTravelTourism:
                serializer.Serialize(writer, "Hospitality, Travel, & Tourism");
                return;
            case Interest1.HumanitiesInterdisciplinary:
                serializer.Serialize(writer, "Humanities & Interdisciplinary");
                return;
            case Interest1.Jrotc:
                serializer.Serialize(writer, "JROTC");
                return;
            case Interest1.LawGovernment:
                serializer.Serialize(writer, "Law & Government");
                return;
            case Interest1.PerformingArts:
                serializer.Serialize(writer, "Performing Arts");
                return;
            case Interest1.PerformingArtsVisualArtDesign:
                serializer.Serialize(writer, "Performing Arts/Visual Art & Design");
                return;
            case Interest1.ProjectBasedLearning:
                serializer.Serialize(writer, "Project-Based Learning");
                return;
            case Interest1.ScienceMath:
                serializer.Serialize(writer, "Science & Math");
                return;
            case Interest1.Teaching:
                serializer.Serialize(writer, "Teaching");
                return;
            case Interest1.VisualArtDesign:
                serializer.Serialize(writer, "Visual Art & Design");
                return;
            case Interest1.Zoned:
                serializer.Serialize(writer, "Zoned");
                return;
        }
        throw new Exception("Cannot marshal type Interest1");
    }

    public static readonly Interest1Converter Singleton = new Interest1Converter();
}

internal class MethodConverter : JsonConverter
{
    public override bool CanConvert(Type t) => t == typeof(Method) || t == typeof(Method?);

    public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
    {
        if (reader.TokenType == JsonToken.Null) return null;
        var value = serializer.Deserialize<string>(reader);
        switch (value)
        {
            case "ASD/ACES Program":
                return Method.AsdAcesProgram;
            case "Audition":
                return Method.Audition;
            case "D75 Special Education Inclusive Services":
                return Method.D75SpecialEducationInclusiveServices;
            case "Ed. Opt.":
                return Method.EdOpt;
            case "Open":
                return Method.Open;
            case "Screened":
                return Method.Screened;
            case "Screened: Language":
                return Method.ScreenedLanguage;
            case "Screened: Language & Academics":
                return Method.ScreenedLanguageAcademics;
            case "Test":
                return Method.Test;
            case "Transfer":
                return Method.Transfer;
            case "Zoned Guarantee":
                return Method.ZonedGuarantee;
            case "Zoned Priority":
                return Method.ZonedPriority;
        }
        throw new Exception("Cannot unmarshal type Method");
    }

    public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
    {
        if (untypedValue == null)
        {
            serializer.Serialize(writer, null);
            return;
        }
        var value = (Method)untypedValue;
        switch (value)
        {
            case Method.AsdAcesProgram:
                serializer.Serialize(writer, "ASD/ACES Program");
                return;
            case Method.Audition:
                serializer.Serialize(writer, "Audition");
                return;
            case Method.D75SpecialEducationInclusiveServices:
                serializer.Serialize(writer, "D75 Special Education Inclusive Services");
                return;
            case Method.EdOpt:
                serializer.Serialize(writer, "Ed. Opt.");
                return;
            case Method.Open:
                serializer.Serialize(writer, "Open");
                return;
            case Method.Screened:
                serializer.Serialize(writer, "Screened");
                return;
            case Method.ScreenedLanguage:
                serializer.Serialize(writer, "Screened: Language");
                return;
            case Method.ScreenedLanguageAcademics:
                serializer.Serialize(writer, "Screened: Language & Academics");
                return;
            case Method.Test:
                serializer.Serialize(writer, "Test");
                return;
            case Method.Transfer:
                serializer.Serialize(writer, "Transfer");
                return;
            case Method.ZonedGuarantee:
                serializer.Serialize(writer, "Zoned Guarantee");
                return;
            case Method.ZonedPriority:
                serializer.Serialize(writer, "Zoned Priority");
                return;
        }
        throw new Exception("Cannot marshal type Method");
    }

    public static readonly MethodConverter Singleton = new MethodConverter();
}

internal class SchoolAccessibilityConverter : JsonConverter
{
    public override bool CanConvert(Type t) => t == typeof(SchoolAccessibility) || t == typeof(SchoolAccessibility?);

    public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
    {
        if (reader.TokenType == JsonToken.Null) return null;
        var value = serializer.Deserialize<string>(reader);
        switch (value)
        {
            case "Fully Accessible":
                return SchoolAccessibility.FullyAccessible;
            case "Not Accessible":
                return SchoolAccessibility.NotAccessible;
            case "Partially Accessible":
                return SchoolAccessibility.PartiallyAccessible;
        }
        throw new Exception("Cannot unmarshal type SchoolAccessibility");
    }

    public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
    {
        if (untypedValue == null)
        {
            serializer.Serialize(writer, null);
            return;
        }
        var value = (SchoolAccessibility)untypedValue;
        switch (value)
        {
            case SchoolAccessibility.FullyAccessible:
                serializer.Serialize(writer, "Fully Accessible");
                return;
            case SchoolAccessibility.NotAccessible:
                serializer.Serialize(writer, "Not Accessible");
                return;
            case SchoolAccessibility.PartiallyAccessible:
                serializer.Serialize(writer, "Partially Accessible");
                return;
        }
        throw new Exception("Cannot marshal type SchoolAccessibility");
    }

    public static readonly SchoolAccessibilityConverter Singleton = new SchoolAccessibilityConverter();
}

internal class Seats101Converter : JsonConverter
{
    public override bool CanConvert(Type t) => t == typeof(Seats101) || t == typeof(Seats101?);

    public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
    {
        if (reader.TokenType == JsonToken.Null) return null;
        var value = serializer.Deserialize<string>(reader);
        switch (value)
        {
            case "No":
                return Seats101.No;
            case "Yes":
                return Seats101.Yes;
        }
        throw new Exception("Cannot unmarshal type Seats101");
    }

    public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
    {
        if (untypedValue == null)
        {
            serializer.Serialize(writer, null);
            return;
        }
        var value = (Seats101)untypedValue;
        switch (value)
        {
            case Seats101.No:
                serializer.Serialize(writer, "No");
                return;
            case Seats101.Yes:
                serializer.Serialize(writer, "Yes");
                return;
        }
        throw new Exception("Cannot marshal type Seats101");
    }

    public static readonly Seats101Converter Singleton = new Seats101Converter();
}

internal class StateCodeConverter : JsonConverter
{
    public override bool CanConvert(Type t) => t == typeof(StateCode) || t == typeof(StateCode?);

    public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
    {
        if (reader.TokenType == JsonToken.Null) return null;
        var value = serializer.Deserialize<string>(reader);
        if (value == "NY")
        {
            return StateCode.Ny;
        }
        throw new Exception("Cannot unmarshal type StateCode");
    }

    public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
    {
        if (untypedValue == null)
        {
            serializer.Serialize(writer, null);
            return;
        }
        var value = (StateCode)untypedValue;
        if (value == StateCode.Ny)
        {
            serializer.Serialize(writer, "NY");
            return;
        }
        throw new Exception("Cannot marshal type StateCode");
    }

    public static readonly StateCodeConverter Singleton = new StateCodeConverter();
}



public enum Admissionspriority { ThenToBrooklynStudentsOrResidents, ThenToNewYorkCityResidents, ThenToQueensStudentsOrResidents };

public enum Borocode { K, M, Q, R, X };

public enum Borough { Bronx, Brooklyn, Manhattan, Queens, StatenIs };

public enum Diplomaendorsements { ArtsCteMathScience, ArtsCteScience, Math, MathScience, Science };

public enum TypeEnum { Point };

public enum ArakGroundhog { N, NANewProgram, NATransferSchool, NAZonedProgram, Y };

public enum Grades2019 { KTo12, PkTo12, The6To11, The6To12, The7To12, The9To12 };

public enum Interest1 { AnimalScience, Architecture, Business, Communications, ComputerScienceTechnology, Cosmetology, CulinaryArts, Engineering, EnvironmentalScience, FilmVideo, HealthProfessions, HospitalityTravelTourism, HumanitiesInterdisciplinary, Jrotc, LawGovernment, PerformingArts, PerformingArtsVisualArtDesign, ProjectBasedLearning, ScienceMath, Teaching, VisualArtDesign, Zoned };

public enum Method { AsdAcesProgram, Audition, D75SpecialEducationInclusiveServices, EdOpt, Open, Screened, ScreenedLanguage, ScreenedLanguageAcademics, Test, Transfer, ZonedGuarantee, ZonedPriority };

public enum SchoolAccessibility { FullyAccessible, NotAccessible, PartiallyAccessible };

public enum Seats101 { No, Yes };

public enum StateCode { Ny };

