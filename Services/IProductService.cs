using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoppingListApp.Entities;

namespace ShoppingListApp.Services
{
    public interface IProductService
    {
        Product GetById(int id);
        List<Product> GetAll(int userId);
        void Create(Product product);
        void Update(int id, Product product);
        void Delete(int id);
        void MarkAsBought(int id);
    }
}
