

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodingChallengeBusinessLayer.BusinessObjects
{
    [Table("Client")]
    public class Client
    {
        [Key]
        [Column("ClientId")]
        public int ClientId { get; set; }

        [Column("FirstName")]
        public string FirstName { get; set; }

        [Column("LastName")]
        public string LastName { get; set; }

        [Column("PhoneNumber")]
        public string PhoneNumber { get; set; }

        [Column("Email")]
        public string Email { get; set; }

        [Column("Birth_DT")]
        public DateTime Birth_DT { get; set; }

        [Column("Sex")]
        public Enum.Sex Sex { get; set; }

        [Column("Updated_DT")]
        public DateTime Updated_DT { get; set; }

        [Column("UpdatedBy")]
        public string UpdatedBy { get; set; }

    }
}
