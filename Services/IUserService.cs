using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoppingListApp.Entities;

namespace ShoppingListApp.Services
{
    public interface IUserService
    {
        User Login(string username, string password);
    }
}
