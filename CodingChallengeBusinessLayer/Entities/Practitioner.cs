using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodingChallengeBusinessLayer.BusinessObjects
{
    [Table("Practitioner")]
    public class Practitioner
    {
        [Key]
        [Column("PractitionerId")]
        public int PractitionerId { get; set; }

        [Column("NPI")]
        public string NPI { get; set; }

        [Column("FirstName")]
        public string FirstName { get; set; }

        [Column("LastName")]
        public string LastName { get; set; }

        [Column("SSN")]
        public string SSN { get; set; }

        [Column("PhoneNumber")]
        public string PhoneNumber { get; set; }

        [Column("Email")]
        public string Email { get; set; }

        [Column("Title")]
        public string Title { get; set; }

        [Column("Sex")]
        public Enum.Sex Sex { get; set; }

        [Column("Term_DT")]
        public DateTime Term_DT { get; set; }

        [Column("Updated_DT")]
        public DateTime? Updated_DT { get; set; }

        [Column("UpdatedBy")]
        public string UpdatedBy { get; set; }

    }
}
