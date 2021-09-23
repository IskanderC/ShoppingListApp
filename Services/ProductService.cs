using ShoppingListApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoppingListApp.Repositories;

namespace ShoppingListApp.Services
{
    // if there is some processing logic involved, process it
    // if there is no logic, just call the method in repository
    public class ProductService : IProductService
    {
        private IProductRepository _repository;

        public ProductService()
        {
            _repository = new ProductRepository();
        }
        public void Create(Product product)
        {
            _repository.Create(product);
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        public List<Product> GetAll(int userId)
        {
           List<Product> products = _repository.GetAll(userId);

            return products;
        }

        public Product GetById(int id)
        {
            Product product = _repository.GetById(id);

            return product;
        }

        public void MarkAsBought(int id)
        {
            Product product = GetById(id);
            product.Bought = true;

            Update(id, product);
        }

        public void Update(int id, Product product)
        {
            _repository.Update(id, product);
        }
    }
}
