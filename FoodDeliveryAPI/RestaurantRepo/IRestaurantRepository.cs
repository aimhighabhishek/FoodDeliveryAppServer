using FoodDeliveryAPI.Models;
using System.Numerics;

namespace FoodDeliveryAPI.RestaurantRepo
{
    public interface IRestaurantRepository
    {
        public Task<Restaurant> AddRestaurant(Restaurant restaurant);
        public Task<Restaurant> UpdateRestaurant(Restaurant restaurant);
        public List<Restaurant> GetRestaurants();
        public Restaurant GetRestaurantById(long restaurantId);
    }
}
