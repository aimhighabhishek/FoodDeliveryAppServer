using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;

namespace FoodDeliveryAPI.Models
{
    [Table("tblRestaurant")]
    public class Restaurant : CommonProperty
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Id")]
        public long RestaurantId { get; set; }
        public string? RestaurantName { get; set; }
        public string? Address { get; set; }
    }
}
