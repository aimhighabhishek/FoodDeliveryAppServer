using FoodDeliveryAPI.Models;
using System.Numerics;
namespace FoodDeliveryAPI.UserRegisterRepo
{
    public interface IUserRepository
    {
        public Task<UserRegistration> RegisterUser(UserRegistration userRegistration);

        public Task<UserRegistration> Login(UserRegistration userRegistration);

        public Task<UserRegistration> UpdateUser(UserRegistration userRegistration);

        public List<UserRegistration> GetUsers();
        public UserRegistration GetUserById(long userId);
    }
}
