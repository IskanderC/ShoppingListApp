using ShoppingListApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

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
            string query = @$"SELECT*From dbo.Users
                              WHERE dbo.Users.username = '{username}' AND dbo.Users.password = '{password}'";
            
            DataTable dataTable = _databaseWrapper.Query(query);

            if (dataTable.Rows.Count == 0)
                return null;

            User user = new User();

            user.Id = Convert.ToInt32(dataTable.Rows[0]["user_id"]);
            user.Username = Convert.ToString(dataTable.Rows[0]["username"]);
            user.Password = Convert.ToString(dataTable.Rows[0]["password"]);

            return user;
        }
    }
}
