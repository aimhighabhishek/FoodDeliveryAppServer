using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;

namespace FoodDeliveryAPI.Models
{
    [Table("tblUserRegistration")]
    public class UserRegistration : CommonProperty
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Id")]
        public long UserId { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }
        public string? Password { get; set; }
        public string? Email { get; set; }
        public string? UserRole { get; set; }
        public string? PhoneNumber { get; set; }
    }
}
