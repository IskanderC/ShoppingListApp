using ShoppingListApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoppingListApp.Repositories;

namespace ShoppingListApp.Services
{
    public class UserService : IUserService
    {
        private IUserRepository _repository;

        public UserService()
        {
            _repository = new UserRepository();
        }
        public User Login(string username, string password)
        {
           User user = _repository.Login(username, password);

           return user;
        }
    }
}
