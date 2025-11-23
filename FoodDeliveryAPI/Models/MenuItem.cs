using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FoodDeliveryAPI.Models
{
    [Table("tblMenuitems")]
    public class MenuItem:CommonProperty
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Id")]
        public long MenuId { get; set; }
        public string? Menu_Name { get; set; }
        public decimal Menu_Price { get; set; }
        public string? Menu_Description { get; set; }
        public long RestaurantId { get; set; }
    }    
}
