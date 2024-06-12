

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodingChallengeBusinessLayer.BusinessObjects
{
    [Table("Facility")]
    public class Facility
    {
        [Key]
        [Column("FacilityId")]
        public int FacilityId { get; set; }

        [Column("NPI")]
        public string NPI { get; set; }

        [Column("PracticeName")]
        public string PracticeName { get; set; }

        [Column("TIN")]
        public string TIN { get; set; }

        [Column("PhoneNumber")]
        public string PhoneNumber { get; set; }

        [Column("Address1")]
        public string Address1 { get; set; }

        [Column("Address2")]
        public string Address2 { get; set; }

        [Column("City")]
        public string City { get; set; }

        [Column("StateAbrev")]
        public string StateAbrev { get; set; }

        [Column("Zipcode")]
        public string Zipcode { get; set; }

        [Column("Term_DT")]
        public DateTime Term_DT { get; set; }

        [Column("Updated_DT")]
        public DateTime? Updated_DT { get; set; }

        [Column("UpdatedBy")]
        public string UpdatedBy { get; set; }
    }
}
