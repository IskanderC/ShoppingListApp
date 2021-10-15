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

        public List<Product> ProductsToBuy { get; set; }
        public List<Product> BoughtProducts { get; set; }


        public MainWindow()
        {
            _userService = new UserService();
            _productService = new ProductService();
            InitializeComponent();

            InitProducts();



            var x = 2;
        }

        private void RemoveButton_Clicked(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            var tag = button.Tag.ToString();

            Product product;

            if (tag == "fromToBuy")
            {
                product = (Product)DatagridProductsToBuy.SelectedItem;
            }
            else 
            {
                product = (Product)DatagridBoughtProducts.SelectedItem;
            }

            _productService.Delete(product.Id);
            InitProducts();
        }

        private void InitProducts()
        {
            //TODO change when implementing login
            List<Product> products = _productService.GetAll(1);

            ProductsToBuy = products
                .Where(product => product.Bought == false)  
                .ToList();

            BoughtProducts = products
                .Where(product => product.Bought)
                .ToList();

            DatagridProductsToBuy.ItemsSource = ProductsToBuy;
            DatagridBoughtProducts.ItemsSource = BoughtProducts;
        }


        protected void OnWindowSizeChanged(object sender, RoutedEventArgs e)
        {
            DataGrid dataGrid = sender as DataGrid;
            ResizeGrids(dataGrid);
        }

        private void ResizeGrids(DataGrid dataGrid)
        {
            //dataGrid.Width = e.NewSize.Width - (e.NewSize.Width * .1);

            foreach (var column in dataGrid.Columns)
            {
                column.Width = dataGrid.ActualWidth / dataGrid.Columns.Count;
            }
        }

    }
}
