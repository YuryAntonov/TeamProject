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
using LogicAndDb;

namespace TeamProjectAutoRent
{
    /// <summary>
    /// Логика взаимодействия для BrandWindow.xaml
    /// </summary>
    public partial class BrandWindow : Window
    {
        private List<Brand> tbb;

        public Brand Brand { get; private set; }
        public bool successFlag { get; set; } = false;

        public BrandWindow()
        {
            InitializeComponent();
            price_categoryComboBox.ItemsSource = new List<string> { "Economy", "Comfort", "Premium" };
            price_categoryComboBox.SelectedIndex = 0;
        }

        public BrandWindow(List<Brand> tbb)
        {
            InitializeComponent();
            price_categoryComboBox.ItemsSource = new List<string> { "Economy", "Comfort", "Premium" };
            price_categoryComboBox.SelectedItem = tbb.First().price_category;
            brand_nameTextBox.IsEnabled = false;
            this.tbb = tbb;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {


            System.Windows.Data.CollectionViewSource brandViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("brandViewSource")));
            // Загрузите данные, установив свойство CollectionViewSource.Source:
            brandViewSource.Source = tbb;
        }

        private void OKButton_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(brand_nameTextBox.Text))
            {
                MessageBox.Show("Please, enter valid brand name!", "Warning");
            }
            else
            {
                successFlag = true;
                Brand = new Brand { brand_name = brand_nameTextBox.Text, price_category = price_categoryComboBox.SelectedItem as string };
                Close();
            }
        }
    }
}
