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
    /// Логика взаимодействия для OfficeWindow.xaml
    /// </summary>
    public partial class OfficeWindow : Window
    {
        private List<Office> ofL;

        public bool successFlag { get; set; } = false;

        public Office office { get; set; }
        public OfficeWindow()
        {
            InitializeComponent();
        }

        public OfficeWindow(List<Office> ofL)
        {
            InitializeComponent();
            office_addressTextBox.IsEnabled = false;
            this.ofL = ofL;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            System.Windows.Data.CollectionViewSource officeViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("officeViewSource")));
            // Загрузите данные, установив свойство CollectionViewSource.Source:
            officeViewSource.Source = ofL;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                office = new Office() { office_address = office_addressTextBox.Text, capacity = Convert.ToInt32(capacityTextBox.Text) };
                successFlag = true;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please, enter valid capacity!", "Warning");


            }



        }
    }
}
