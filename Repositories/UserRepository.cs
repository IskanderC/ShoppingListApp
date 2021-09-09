using ShoppingListApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingListApp.Repositories
{
    public class UserRepository : IUserRepository
    {
        private IDatabaseWrapper _databaseWrapper;

        public UserRepository()
        {
            _databaseWrapper = new DatabaseWrapper();
        }
        public User Login(string username, string password)
        {
            throw new NotImplementedException();
        }
    }
}
