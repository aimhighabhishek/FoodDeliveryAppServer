using FoodDeliveryAPI.Models;
using System.Numerics;

namespace FoodDeliveryAPI.MenuItemRepo
{
    public interface IMenuItemRepository
    {
        public Task<MenuItem> AddMenuItem(MenuItem menuItem);
        public Task<MenuItem> UpdateMenuItem(MenuItem menuItem);
        public List<MenuItem> GetMenuItems();
        public MenuItem GetMenuItemById(long menuItemId);
    }
}
