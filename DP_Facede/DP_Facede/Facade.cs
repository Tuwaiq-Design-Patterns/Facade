using System.Collections.Generic;

namespace DP_Facede
{
    public class Absher
    {
        protected MinistryAgencyOfCivilAffairs _subsystem1 = new MinistryAgencyOfCivilAffairs();
        protected GeneralDepartmentOfTraffic _subsystem2 = new GeneralDepartmentOfTraffic();
        protected GeneralDirectorateOfPassports _subsystem3 = new GeneralDirectorateOfPassports();
        public Absher()
        {
        }

        public List<string> HomePage(string userId)
        {
            List<string> result = new ();
            result.Add($"Absher: User #{userId} has entered the main page of Absher:");
            result.Add($"Absher: Fetching data from Ministry Agency Of Civil Affairs for'{userId}':");
            result.Add(_subsystem1.QueryExpiryOfNIN(userId));
            result.Add(_subsystem1.HajjEligibility(userId));

            result.Add($"Absher: Fetching data from General Department Of Traffic for '{userId}':");
            result.Add(_subsystem2.QueryTrafficViolation(userId));
            result.Add(_subsystem2.DrivingLicenseInfo(userId));

            result.Add($"Absher: Fetching data from General Directorate Of Passports for '{userId}':");
            result.Add(_subsystem3.QueryFingerprintEnrollment(userId));
            result.Add(_subsystem3.QueryTravelLogInfo(userId));
            return result;
        }
    }
}
