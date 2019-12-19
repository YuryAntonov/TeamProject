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
    /// Логика взаимодействия для CustomerWindow.xaml
    /// </summary>
    public partial class CustomerWindow : Window
    {
        private List<Customer> cL;

        public Customer customer { get; set; }
        public bool successFlag { get; set; } = false;
        public CustomerWindow()
        {
            InitializeComponent();
            genderComboBox.ItemsSource = new List<string> { "F", "M" };
            genderComboBox.SelectedIndex = 0;
        }

        public CustomerWindow(List<Customer> cL)
        {
            InitializeComponent();
            this.cL = cL;
            genderComboBox.ItemsSource = new List<string> { "F", "M" };
            genderComboBox.SelectedItem = cL.First().gender;
            passport_numberTextBox.IsEnabled = false;

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            CollectionViewSource customerViewSource = ((CollectionViewSource)(FindResource("customerViewSource")));

            customerViewSource.Source = cL;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            if (!int.TryParse(driving_experienceTextBox.Text, out _))
            {
                MessageBox.Show("Please, enter correct driving experience!", "Warning!");
            }
            else if (string.IsNullOrWhiteSpace(passport_numberTextBox.Text))
            {

                MessageBox.Show("Please, enter correct passport number!", "Warning!");
            }
            else
            {
                customer = new Customer()
                {
                    customer_address = customer_addressTextBox.Text,
                    full_name = full_nameTextBox.Text,
                    driving_experience = int.Parse(driving_experienceTextBox.Text),
                    gender = genderComboBox.SelectedItem as string,
                    phone_number = phone_numberTextBox.Text
                    ,
                    passport_number = passport_numberTextBox.Text


                };
                successFlag = true;
                Close();
            }

        }

        private void Driving_experienceTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            driving_experienceTextBox.Text = new String(driving_experienceTextBox.Text.Where(c => char.IsDigit(c)).ToArray());
        }
    }
}
