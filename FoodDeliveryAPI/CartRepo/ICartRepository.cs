using FoodDeliveryAPI.Models;
using System.Numerics;

namespace FoodDeliveryAPI.CartRepo
{
    public interface ICartRepository
    {
        public Task<Cart> AddCartItem(Cart cartItem);
        public Task<Cart> UpdateCartItem(Cart cartItem);
        public List<Cart> GetCartItems();
        public Cart GetCartItemById(long cartItemId);
    }
}
