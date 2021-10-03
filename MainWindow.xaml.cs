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
using System.Windows.Navigation;
using System.Windows.Shapes;
using ShoppingListApp.Services;
using ShoppingListApp.Entities;
using System.Collections.ObjectModel;

namespace ShoppingListApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {   
        private IUserService _userService;
        private IProductService _productService;

        public ObservableCollection<Product> ProductsToBuy { get; set; }
        public ObservableCollection<Product> BoughtProducts { get; set; }


        public MainWindow()
        {
            _userService = new UserService();
            _productService = new ProductService();
            InitializeComponent();
            DataContext = this;

            InitProducts();
            //RahatTabControl.ItemsSource = ProductsToBuy;



            var x = 2;
        }

        private void RemoveButton_Clicked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("mue");
        }

        private void InitProducts()
        {
            //TODO change when implementing login
            List<Product> products = _productService.GetAll(1);

            List<Product> productsToBuy = products
                .Where(product => product.Bought == false)  
                .ToList();

            List<Product> boughtProducts = products
                .Where(product => product.Bought)
                .ToList();

            ProductsToBuy = GetParsedProducts(productsToBuy);
            BoughtProducts = GetParsedProducts(boughtProducts);
        }

        private ObservableCollection<Product> GetParsedProducts(List<Product> products)
        {
            ObservableCollection<Product> productsToReturn = new ObservableCollection<Product>();

            foreach (var product in products)
            {
                productsToReturn.Add(product);
            }

            return productsToReturn;
        }
    }
}
