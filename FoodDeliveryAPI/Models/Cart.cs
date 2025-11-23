using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FoodDeliveryAPI.Models
{
    [Table("tblCart")]
    public class Cart : CommonProperty
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Id")]
        public long CartID { get; set; }
        public long MenuID { get; set; }
        public int Quantity { get; set; }
        public long RestaurantId { get; set; }
        public long UserId { get; set; }
    }
}
