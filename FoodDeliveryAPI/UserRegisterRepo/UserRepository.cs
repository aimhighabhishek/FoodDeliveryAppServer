using FoodDeliveryAPI.Models;
using FoodDeliveryAPI.UserRegisterRepo;
using Microsoft.EntityFrameworkCore;
using System.Numerics;

namespace FoodDeliveryAPI.UserRegisterRepo
{
	public class UserRepository : IUserRepository
	{
		private readonly FoodDeliveryDBContext _foodDeliverycontext;

		public UserRepository(FoodDeliveryDBContext foodDeliverycontext)
		{
			_foodDeliverycontext = foodDeliverycontext;
		}

		public UserRegistration GetUserById(long userId)
		{
			throw new NotImplementedException();
		}

		public List<UserRegistration> GetUsers()
		{
			throw new NotImplementedException();
		}

		public Task<UserRegistration> RegisterUser(UserRegistration userRegistration)
		{
			userRegistration.CreatedDate = DateTime.Now;
			userRegistration.UpdatedDate = DateTime.Now;
			_foodDeliverycontext.UserRegistration.Add(userRegistration);
			_foodDeliverycontext.SaveChanges();
			return Task.FromResult(userRegistration);

		}

		public Task<UserRegistration> Login(UserRegistration users)
		{
			var user = _foodDeliverycontext.UserRegistration.FirstOrDefaultAsync(u => (u.Email == users.Email || u.PhoneNumber == users.PhoneNumber) && u.Password == users.Password);
			return Task.FromResult(user?.Result);

		}

		public Task<UserRegistration> UpdateUser(UserRegistration userRegistration)
		{
			throw new NotImplementedException();
		}
	}
}
