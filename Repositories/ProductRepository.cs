using ShoppingListApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ShoppingListApp.Repositories
{
    // create queries
    // send query db wrapper
    // map the response into Product / Lists of Products
    // return the response (if any)
    public class ProductRepository : IProductRepository
    {
        private IDatabaseWrapper _databaseWrapper;

        public ProductRepository()
        {
            _databaseWrapper = new DatabaseWrapper();
        }

        public void Create(Product product)
        {
            int bought = product.Bought ? 1 : 0;

            string query = @$" INSERT INTO dbo.Products (user_id, product_name, product_quantity, product_bought)
                                VALUES ({product.UserId}, '{product.Name}', {product.Quantity}, {bought}) ";
            _databaseWrapper.Command(query);
        }

        public void Delete(int id)
        {
            string query = @$"DELETE FROM dbo.Products
                                WHERE dbo.Products.product_id = {id}";

            _databaseWrapper.Command(query);    
        }

        public List<Product> GetAll(int userId)
        {
            string query = @$"SELECT * FROM dbo.Products 
                                WHERE dbo.Products.user_id = {userId}";

            DataTable dataTable = _databaseWrapper.Query(query);

            if (dataTable.Rows.Count == 0)
                return null;

            List<Product> products = new List<Product>();

            foreach (DataRow row in dataTable.Rows)
            {
                Product product = new Product();

                product.Id = Convert.ToInt32(row["product_id"]);
                product.UserId = Convert.ToInt32(row["user_id"]);
                product.Name = row["product_name"].ToString();
                product.Quantity = Convert.ToInt32(row["product_quantity"]);
                product.Bought = Convert.ToBoolean(row["product_bought"]);

                products.Add(product);
            }

            return products;
        }

        public Product GetById(int id)
        {
            string query = @$"SELECT * FROM dbo.Products 
                                WHERE dbo.Products.product_id = {id}";

            DataTable dataTable = _databaseWrapper.Query(query);

            if (dataTable.Rows.Count == 0)
                return null;

            Product product = new Product();

            product.Id = Convert.ToInt32(dataTable.Rows[0]["product_id"]);
            product.UserId = Convert.ToInt32(dataTable.Rows[0]["user_id"]);
            product.Name = dataTable.Rows[0]["product_name"].ToString();
            product.Quantity = Convert.ToInt32(dataTable.Rows[0]["product_quantity"]);
            product.Bought = Convert.ToBoolean(dataTable.Rows[0]["product_bought"]);

            return product;
        }

        public void MarkAsBought(int id)
        {
            string query = @$"UPDATE dbo.Products SET product_bought = 1  
                              WHERE product_id = {id}";
        }

        public void Update(int id, Product product)
        {
            int bought = product.Bought ? 1 : 0;

            string query = @$" UPDATE dbo.Products 
                                SET user_id = {product.UserId}, product_name = '{product.Name}', product_quantity = {product.Quantity}, product_bought = {bought} 
                                WHERE product_id = {id}";
            _databaseWrapper.Command(query);
        }
    }
}
