using System.Collections.Generic;
using System.Linq;


namespace DP_Facede
{
    public class MinistryAgencyOfCivilAffairs
    {
        private List<(string id, bool hajjEligibility, string NIN_Expiration)> _fakeDb = new() {("0000007701", true,"2021-08-10")};
        public string QueryExpiryOfNIN(string userId)
        {
            var queriedUser = _fakeDb.ToList().Find(u => u.id == userId);
            return $"User # {queriedUser.id}'s NIN will be expired in {queriedUser.NIN_Expiration}";
        }

        public string HajjEligibility(string userId)
        {
            var queriedUser = _fakeDb.ToList().Find(u => u.id == userId);
            return "" switch
            {
                string when queriedUser.hajjEligibility => $"User # {queriedUser.id} is Eligible for the Hajj\n" ,
                _ => $"User # {queriedUser.id} is not Eligible for the Hajj\n"
            };
        }
    }




    public class GeneralDepartmentOfTraffic
    {
        private List<(string id, string DL_Expiration, string type, int violations)> _fakeDb = new() { ("0000007701", "2030-01-15", "Private", 2) };
        public string QueryTrafficViolation(string userId)
        {
            var queriedUser = _fakeDb.ToList().Find(u => u.id == userId);
            return $"User # {queriedUser.id} has {queriedUser.violations} violations";
        }

        public string DrivingLicenseInfo(string userId)
        {
            var queriedUser = _fakeDb.ToList().Find(u => u.id == userId);
            return $"User # {queriedUser.id}'s Driving License Info: - Expiration: {queriedUser.DL_Expiration} , - type: {queriedUser.type}\n";
        }
    }




    public class GeneralDirectorateOfPassports
    {
        private List<(string id, bool FingerprintEnrollment, string current_status, int travels)> _fakeDb = new() { ("0000007701", true, "Inside", 2) };
        public string QueryFingerprintEnrollment(string userId)
        {
            var queriedUser = _fakeDb.ToList().Find(u => u.id == userId);
            return "" switch
            {
                string when queriedUser.FingerprintEnrollment => $"User # {queriedUser.id} has been approved for the Finger-print Enrollment",
                _ => $"User # {queriedUser.id} has no record in the Finger-print Enrollment"
            };
        }

        public string QueryTravelLogInfo(string userId)
        {
            var queriedUser = _fakeDb.ToList().Find(u => u.id == userId);
            return $"User # {queriedUser.id} has been traveled {queriedUser.travels} times." +
                $"\t Travel status: {queriedUser.current_status}\n";
        }
    }
}
