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
        DataTable GetQueryResult(string Query);
        void UpdateDB(string InsertQuery);
        object GetValueFromDB(string Query);
    }
}
