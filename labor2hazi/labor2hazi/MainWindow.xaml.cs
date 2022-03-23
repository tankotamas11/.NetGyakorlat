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

namespace labor2hazi
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<Products> products = new List<Products>();

            products.Add(new Products() { ProductID = 101, ProductName = "Coffee Powder", PackSize = "1 kg", Quantity = 15684 , Price=10 });
            products.Add(new Products() { ProductID = 102, ProductName = "Ground Coffee", PackSize = "500 g", Quantity = 22785, Price = 20 });
            products.Add(new Products() { ProductID = 103, ProductName = "Tea", PackSize = "500 g", Quantity = 8544, Price = 15 });
            products.Add(new Products() { ProductID = 104, ProductName = "Skimmed Milk", PackSize = "1 litre", Quantity = 28012, Price = 18 });
            products.Add(new Products() { ProductID = 105, ProductName = "Smoothie", PackSize = "400 ml", Quantity = 9346 , Price = 15 });
            products.Add(new Products() { ProductID = 106, ProductName = "Beef Drink", PackSize = "750 g", Quantity = 7612 , Price = 14 });



            ProductsList.ItemsSource = products;
        }
        
    }
}
