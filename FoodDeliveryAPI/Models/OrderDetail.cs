using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;

namespace FoodDeliveryAPI.Models
{
    [Table("tblOrderDetails")]
    public class OrderDetail:CommonProperty
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Id")]
        public long OrderDetailsID { get; set; }
        public long OrderID { get; set; }
        public long MenuId { get; set; }        
        public int Quantity { get; set; }
    }
}
