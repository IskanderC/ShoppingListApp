using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using ShoppingListApp.Services;
using ShoppingListApp.Entities;

namespace ShoppingListApp
{
    

    public partial class AddWindow : Window
    {
        
        private IProductService _productService;
        private int _userId;
        private MainWindow _mainWindow;
        public AddWindow(int userId, MainWindow mainWindow)
        {
            _userId = userId;
            _mainWindow = mainWindow;
            _productService = new ProductService();


            InitializeComponent();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            Product product = new Product();

            product.Name = NameTextBox.Text;
            product.Quantity = Convert.ToInt32(QuantityTextBox.Text);
            product.UserId = _userId;
            product.Bought = false;

            _productService.Create(product);
            _mainWindow.InitProducts();

            Close();
        }
    }
}
