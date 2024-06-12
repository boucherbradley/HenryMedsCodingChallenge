

namespace CodingChallengeBusinessLayer.BusinessObjects
{
    public class AppointmentConfirmation
    {
        public int PractitionerId { get; set; }
        public int PatientId { get; set; }
        public DateTime AppointmentDate { get; set; }
    }
}
