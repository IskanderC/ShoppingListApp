using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace ShoppingListApp.Repositories
{
    public interface IDatabaseWrapper
    {
        DataTable Query(string sql);
        void Command(string sql);
        object GetScalar(string sql);
    }
}
