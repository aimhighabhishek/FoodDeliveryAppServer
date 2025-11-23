using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;

namespace FoodDeliveryAPI.Models
{
    [Table("tblPaymentType")]
    public class PaymentType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Id")]
        public long PaymentTypeId { get; set; }
        public string? PaymentTypeName { get; set; }
    }
}
