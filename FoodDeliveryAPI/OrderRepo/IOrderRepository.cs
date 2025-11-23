using FoodDeliveryAPI.Models;
using System.Numerics;

namespace FoodDeliveryAPI.OrderRepo
{
    public interface IOrderRepository
    {
        public Task<Order> AddOrder(Order order);
        public Task<Order> UpdateOrder(Order order);
        public List<Order> GetOrders();
        public Order GetOrderById(long orderId);
    }
}
