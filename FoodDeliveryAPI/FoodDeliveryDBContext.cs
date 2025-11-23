using FoodDeliveryAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace FoodDeliveryAPI
{
    public class FoodDeliveryDBContext:DbContext
    {
        public FoodDeliveryDBContext(DbContextOptions<FoodDeliveryDBContext> options) : base(options)
        {

        }

        public DbSet<Cart> UmbracoUsers { get; set; }
        public DbSet<MenuItem> MenuItem { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderDetail> OrderDetail { get; set; }

        public DbSet<PaymentType> PaymentType { get; set; }
        public DbSet<Restaurant> Restaurant { get; set; }
        public DbSet<UserRegistration> UserRegistration { get; set; }
    }
}
