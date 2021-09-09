using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoppingListApp.Entities;

namespace ShoppingListApp.Repositories
{
    public interface IUserRepository
    {
        User Login(string username, string password);
    }
}
