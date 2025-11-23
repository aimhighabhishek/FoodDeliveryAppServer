using FoodDeliveryAPI.Models;
using System.Numerics;

namespace FoodDeliveryAPI.OrderDetailRepo
{
    public interface IOrderDetailRepository
    {
        public Task<OrderDetail> AddOrderDetail(OrderDetail orderDetail);
        public Task<OrderDetail> UpdateOrderDetail(OrderDetail orderDetail);
        public List<OrderDetail> GetOrderDetails();
        public OrderDetail GetOrderDetailById(long orderDetailId);
    }
}
