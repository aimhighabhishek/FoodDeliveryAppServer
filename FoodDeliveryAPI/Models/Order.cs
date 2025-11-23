using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;

namespace FoodDeliveryAPI.Models
{
    [Table("tblOrders")]
    public class Order : CommonProperty
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Id")]
        public long OrderID { get; set; }
        public long RestaurantId { get; set; }
        public long UserId { get; set; }
        public decimal TotalPrice { get; set; }
        public int PaymentId { get; set; }
    }
}
