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
    /// Логика взаимодействия для LeaseWindow.xaml
    /// </summary>
    public partial class LeaseWindow : Window
    {

        public Lease_contract lease_Contract { get; set; }
        public bool successFlag { get; set; } = false;
        public LeaseWindow(List<Office> offices, List<Customer> customers, List<Car> cars)
        {
            InitializeComponent();
            native_office_addressComboBox.ItemsSource = from o in offices select o.office_address;
            native_office_addressComboBox.SelectedIndex = 0;
            return_office_addressComboBox.ItemsSource = from o in offices select o.office_address;
            return_office_addressComboBox.SelectedIndex = 0;
            passport_numberComboBox.ItemsSource = from c in customers select c.passport_number;
            passport_numberComboBox.SelectedIndex = 0;
            carplate_numberComboBox.ItemsSource = from car in cars select car.carplate_number;
            carplate_numberComboBox.SelectedIndex = 0;
        }


        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            System.Windows.Data.CollectionViewSource lease_contractViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("lease_contractViewSource")));

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (start_dateDatePicker.SelectedDate == null || end_dateDatePicker.SelectedDate == null || issue_dateDatePicker.SelectedDate == null)
            {
                MessageBox.Show("Please select start/end/issue date!", "Warning");
            }
            else
            {
                if (!decimal.TryParse(daily_costTextBox.Text, out _))
                {
                    MessageBox.Show("Please enter valid daily cost!", "Warning");
                }
                else
                {
                    lease_Contract = new Lease_contract()
                    {
                        carplate_number = carplate_numberComboBox.SelectedItem as string,
                        native_office_address = native_office_addressComboBox.SelectedItem as string,
                        return_office_address = return_office_addressComboBox.SelectedItem as string,
                        daily_cost = decimal.Parse(daily_costTextBox.Text),
                        start_date = start_dateDatePicker.SelectedDate.Value,
                        end_date = end_dateDatePicker.SelectedDate.Value,
                        issue_date = issue_dateDatePicker.SelectedDate.Value,
                        passport_number = passport_numberComboBox.SelectedItem as string
                    };
                    successFlag = true;
                    Close();

                }


            }
        }
    }
}
