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

namespace TeamProjectAutoRent.Views
{
    /// <summary>
    /// Логика взаимодействия для CarModelWindow.xaml
    /// </summary>
    public partial class CarModelWindow : Window
    {
        private List<Car_model> itemL;

        public bool successFlag { get; set; } = false;
        public Car_model car_model { get; set; }
        public CarModelWindow(List<Brand> brands)
        {
            InitializeComponent();
            brand_nameComboBox.ItemsSource = from b in brands select b.brand_name;
            brand_nameComboBox.SelectedIndex = 0;
        }

        public CarModelWindow(List<Car_model> itemL, List<Brand> brands)
        {
            InitializeComponent();
            brand_nameComboBox.ItemsSource = from b in brands select b.brand_name;
            this.itemL = itemL;
            brand_nameComboBox.SelectedItem = itemL.First().brand_name;
        }



        private void Window_Loaded_1(object sender, RoutedEventArgs e)
        {

            System.Windows.Data.CollectionViewSource car_modelViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("car_modelViewSource")));

            car_modelViewSource.Source = itemL;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(model_nameTextBox.Text))
            {
                MessageBox.Show("Please, enter valid model name!", "Warning");
            }
            else { 
            successFlag = true;
            car_model = new Car_model() { brand_name = brand_nameComboBox.SelectedItem as string, model_name = model_nameTextBox.Text };
            Close();
            }
        }
    }
}
