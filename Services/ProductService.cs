using ShoppingListApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoppingListApp.Repositories;

namespace ShoppingListApp.Services
{
    public class ProductService : IProductService
    {
        private IProductRepository _respository;

        public ProductService()
        {
            _respository = new ProductRepository();
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
