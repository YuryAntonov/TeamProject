using System;
using System.Collections.Generic;
using System.Globalization;
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
    /// Логика взаимодействия для Car_window.xaml
    /// </summary>
    public partial class CarWindow : Window
    {
        private List<Car> carL;
        public Car car { get; set; }
        public bool successFlag { get; set; } = false;
        public CarWindow(List<Car_model> models)
        {
            InitializeComponent();
            car_statusComboBox.ItemsSource = new List<string>() { "For rent", "For sale" };
            car_statusComboBox.SelectedIndex = 0;
            model_nameComboBox.ItemsSource = from m in models select m.model_name;
            model_nameComboBox.SelectedIndex = 0;
        }

        public CarWindow(List<Car> carL, List<Car_model> models)
        {
            this.carL = carL;
            InitializeComponent();
            car_statusComboBox.ItemsSource = new List<string>() { "For rent", "For sale" };
            car_statusComboBox.SelectedItem = carL.First().car_status;
            carplate_numberTextBox.IsEnabled = false;
            model_nameComboBox.ItemsSource = from m in models select m.model_name;
            model_nameComboBox.SelectedItem = carL.First().model_name;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            System.Windows.Data.CollectionViewSource carViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("carViewSource")));
            // Загрузите данные, установив свойство CollectionViewSource.Source:
            carViewSource.Source = carL;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                car = new Car()
                {
                    carplate_number = carplate_numberTextBox.Text,
                    car_status = car_statusComboBox.SelectedItem as string,
                    color = colorTextBox.Text,
                    mileage = decimal.Parse(mileageTextBox.Text, CultureInfo.InvariantCulture),
                    model_name = model_nameComboBox.SelectedItem as string
                };
                successFlag = true;
                Close();

            }
            catch (Exception)
            {
                MessageBox.Show("Please enter valid mileage!", "Warning");
            }



        }

        private void MileageTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            mileageTextBox.Text = new String(mileageTextBox.Text.Where(c => char.IsDigit(c) || c == '.' || c == ',').ToArray());
        }
    }
}
