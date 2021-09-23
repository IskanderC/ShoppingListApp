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

namespace ShoppingListApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private IUserService _userService;
        private IProductService _productService;


        public MainWindow()
        {
            _userService = new UserService();
            _productService = new ProductService();
            InitializeComponent();


            //var blabla = _productService.GetById(1);

            //var product = new Product
            //{
            //    Bought = true,
            //    Name = "Bulan",
            //    Quantity = 3,
            //    UserId = 1
            //};

            //_productService.Create(product);

            //var blabla = _productService.GetAll(1);

            //var product = new Product
            //{
            //    Bought = false,
            //    Name = "GIGICU",
            //    Quantity = 666,
            //    UserId = 1
            //};
            //_productService.Update(1, product);

            //_productService.Delete(2);

            ////_productservice.markasbought(1);
            ///
          

            var blabla =_userService.Login("dacu", "nunu");

            
            var x = 2;
        }
    }
}
