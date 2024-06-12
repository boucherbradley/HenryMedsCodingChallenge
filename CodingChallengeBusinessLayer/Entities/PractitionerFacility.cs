

namespace CodingChallengeBusinessLayer.BusinessObjects
{
    public class PractitionerFacility
    {
        public int PractitionerFacilityId { get; set; }
        public int PractitionerId { get; set; }
        public int FacilityId { get; set; }
        public DateTime Term_DT { get; set; }
        public DateTime Updated_DT { get; set; }
        public string UpdatedBy { get; set; }
    }
}
