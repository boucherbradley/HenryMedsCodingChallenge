using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodingChallengeBusinessLayer.BusinessObjects
{
    [Table("Appointment")]
    public class Appointment
    {
        [Key]
        [Column("AppointmentId")]
        public int AppointmentId { get; set; }

        [Column("AppointmentDate")]
        public DateTime AppointmentDate { get; set; }

        [Column("PractitionerId")]
        public int PractitionerId { get; set; }

        [Column("FacilityId")]
        public int FacilityId { get; set; }

        [Column("PatientId")]
        public int? PatientId { get; set; }

        [Column("Available")]
        public bool Available { get; set; }

        [Column("Confirmed")]
        public bool Confirmed { get; set; }

        [Column("Updated_DT")]
        public DateTime? Updated_DT { get; set; }

        [Column("UpdatedBy")]
        public string UpdatedBy { get; set; }

    }
}
