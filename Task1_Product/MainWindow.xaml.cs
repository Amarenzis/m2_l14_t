using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Task1_Product
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Product> products;
        public MainWindow()
        {
            InitializeComponent();
            products = new ObservableCollection<Product>();
            products.Add(new Product()
            {
                NameProduct = "Яблоки",
                CostProduct = 107,
                TypeProduct = TypesProduct.Food,
            });
            products.Add(new Product()
            {
                NameProduct = "Микроволновка",
                CostProduct = 107,
                TypeProduct = TypesProduct.Tech,
            });
            products.Add(new Product()
            {
                NameProduct = "Арбуз",
                CostProduct = 27,
                TypeProduct = TypesProduct.Food,
            });
            lst.ItemsSource = products;
        }
    }
}
