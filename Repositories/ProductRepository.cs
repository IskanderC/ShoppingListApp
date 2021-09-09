using ShoppingListApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingListApp.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private IDatabaseWrapper _databaseWrapper;

        public ProductRepository()
        {
            _databaseWrapper = new DatabaseWrapper();
        }

        public void Create(Product product)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll(int userId)
        {
            throw new NotImplementedException();
        }

        public Product GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void MarkAsBought(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(int id, Product product)
        {
            throw new NotImplementedException();
        }
    }
}
