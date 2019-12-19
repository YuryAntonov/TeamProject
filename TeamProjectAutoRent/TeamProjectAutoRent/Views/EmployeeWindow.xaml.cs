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
    /// Логика взаимодействия для EmployeeWindow.xaml
    /// </summary>
    public partial class EmployeeWindow : Window
    {
        private List<Employee> empL;
        public Employee employee { get; set; }

        public bool successFlag { get; set; } = false;
        public EmployeeWindow(List<Office> offices)
        {
            InitializeComponent();
            genderComboBox.ItemsSource = new List<string> { "F", "M" };
            genderComboBox.SelectedIndex = 0;
            office_addressComboBox.ItemsSource = from o in offices select o.office_address;
            office_addressComboBox.SelectedIndex = 0;
        }

        public EmployeeWindow(List<Employee> empL, List<Office> offices)
        {
            InitializeComponent();
            this.empL = empL;
            genderComboBox.ItemsSource = new List<string> { "F", "M" };
            genderComboBox.SelectedItem = empL.First().gender;
            office_addressComboBox.ItemsSource = from o in offices select o.office_address;
            office_addressComboBox.SelectedItem = empL.First().office_address;
            passport_numberTextBox.IsEnabled = false;

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            System.Windows.Data.CollectionViewSource employeeViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("employeeViewSource")));
            // Загрузите данные, установив свойство CollectionViewSource.Source:
            employeeViewSource.Source = empL;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (birth_dateDatePicker.SelectedDate == null)
            {
                MessageBox.Show("Please, enter valid birth date!", "Warning");
            }
            else if (string.IsNullOrWhiteSpace(passport_numberTextBox.Text))
            {

                MessageBox.Show("Please, enter correct passport number!", "Warning!");
            }
            else
            {
                employee = new Employee()
                {
                    birth_date = birth_dateDatePicker.SelectedDate.Value,
                    full_name = full_nameTextBox.Text,
                    gender = genderComboBox.SelectedItem as string,
                    office_address = office_addressComboBox.SelectedItem as string,
                    passport_number = passport_numberTextBox.Text

                };
                successFlag = true;
                Close();
            }

        }
    }
}
