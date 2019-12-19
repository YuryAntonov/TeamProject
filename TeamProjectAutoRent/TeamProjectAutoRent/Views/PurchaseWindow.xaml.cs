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

namespace TeamProjectAutoRent.Views
{
    /// <summary>
    /// Логика взаимодействия для PurchaseWindow.xaml
    /// </summary>
    public partial class PurchaseWindow : Window
    {

        public Purchase_contract purchase_Contract { get; set; }
        public bool successFlag { get; set; } = false;
        public PurchaseWindow(List<Office> offices, List<Customer> customers, List<Car> cars)
        {
            InitializeComponent();
            office_addressComboBox.ItemsSource = from o in offices select o.office_address.ToString();
            office_addressComboBox.SelectedIndex = 0;
            passport_numberComboBox.ItemsSource = from c in customers select c.passport_number;
            passport_numberComboBox.SelectedIndex = 0;
            carplate_numberComboBox.ItemsSource = from car in cars select car.carplate_number;
            carplate_numberComboBox.SelectedIndex = 0;
           
        }

     

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

          
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (dateDatePicker.SelectedDate == null)
            {
                MessageBox.Show("Please, select date!", "Warning");
            }
            else
            {
                if (!decimal.TryParse(amountTextBox.Text, out _))
                {
                    MessageBox.Show("Please, enter correct amount!", "Warning");
                }
                else
                {
                    purchase_Contract = new Purchase_contract()
                    {
                        amount = decimal.Parse(amountTextBox.Text, CultureInfo.InvariantCulture),
                        carplate_number = carplate_numberComboBox.SelectedItem as string,
                        passport_number = passport_numberComboBox.SelectedItem as string,
                        office_address = office_addressComboBox.SelectedItem as string,
                        date = dateDatePicker.SelectedDate.Value

                    };
                    successFlag = true;
                    Close();

                }

            }
        }

        private void AmountTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            amountTextBox.Text = new String(amountTextBox.Text.Where(c => char.IsDigit(c) || c == '.' || c == ',').ToArray());
        }
    }
}
