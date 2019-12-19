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
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    /// 
    public partial class AccidentWindow : Window
    {
        private List<Accident> acL;

        public Accident accident { get; set; }
        public bool successFlag { get; set; } = false;
        public AccidentWindow(List<Car> cars)
        {
            InitializeComponent();
            carplate_numberComboBox.ItemsSource = from c in cars
                                                  select
                                   c.carplate_number;
            carplate_numberComboBox.SelectedIndex = 0;
        }

        public AccidentWindow(List<Accident> acL, List<Car> cars)
        {
            InitializeComponent();
            this.acL = acL;
            carplate_numberComboBox.ItemsSource = from c in cars
                                                  select
                                  c.carplate_number;
            carplate_numberComboBox.SelectedItem = acL.First().carplate_number;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            System.Windows.Data.CollectionViewSource accidentViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("accidentViewSource")));
            // Загрузите данные, установив свойство CollectionViewSource.Source:
            accidentViewSource.Source = acL;
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (accident_dateDatePicker.SelectedDate == null)
            {
                MessageBox.Show("Please, select the date of accident!", "Warning");
            }
            else
            if (damageTextBox.Text == "")
            {
                MessageBox.Show("Please, select the damage level of accident!", "Warning");
            }
            else
            {
                try
                {

                    accident = new Accident()
                    {
                        accident_date = accident_dateDatePicker.SelectedDate.Value,
                        damage =decimal.Parse(damageTextBox.Text, CultureInfo.InvariantCulture),
                        damage_description = damage_descriptionTextBox.Text,
                        carplate_number = carplate_numberComboBox.SelectedItem as string

                    };
                    successFlag = true;
                    Close();
                }
                catch (Exception)
                {

                    MessageBox.Show("Please, enter valid damage number", "Warning");
                }


            }
        }

        private void DamageTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            damageTextBox.Text = new String(damageTextBox.Text.Where(c => char.IsDigit(c) || c == '.' || c == ',').ToArray());
        }
    }
}
