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
    /// Логика взаимодействия для AnalyticsWindow.xaml
    /// </summary>
    public partial class AnalyticsWindow : Window
    {
        private static readonly List<string> analyticsModes = new List<string>() {
            "Undamaged availible cars",
             "Least mileage cars",
            "Most expensive cars",
            "Most accident cars",
            "All drivers with experience more than average"
           };
        private AutoRentModel autoManager;



        public AnalyticsWindow(AutoRentModel autoManager)
        {
            InitializeComponent();
            this.autoManager = autoManager;
            MainAnalyticsComboBox.ItemsSource = analyticsModes;
            MainAnalyticsComboBox.SelectedIndex = 0;
        }

        private void MainAnalyticsComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (MainAnalyticsComboBox.SelectedItem as string)
            {

                case "Undamaged availible cars":
                    List<Car> cars_undamaged = autoManager.Car.ToList().FindAll(c => c.Accident.Count == 0);
                    List<Car> cars_availible = cars_undamaged.FindAll(c => c.Lease_contract.All(l => l.end_date < DateTime.Now));
                    var res = from c in cars_availible
                              select new { Brand = c.Car_model.brand_name, Model = c.Car_model.model_name, CarPlate = c.carplate_number };
                    AnalyticsDataGrid.ItemsSource = res;
                    break;
                case "All drivers with experience more than average":
                    var drivers = from d in autoManager.Customer.ToList()
                                  where d.driving_experience >= autoManager.Customer.ToList().Average(dr => dr.driving_experience)
                                  select new { Fullname = d.full_name, Phone = d.phone_number, Experience = d.driving_experience, Gender = d.gender };
                    AnalyticsDataGrid.ItemsSource = drivers.OrderByDescending(d => d.Experience);
                    break;
                case "Most expensive cars":
                    var r2 = autoManager.Purchase_contract.ToList().GroupBy(p => new { p.Car.Car_model.brand_name, p.Car.Car_model.model_name })
                        .Select(g => new { Avg_price = (int)g.Average(gr => gr.amount), Brand = g.Key.brand_name, Model = g.Key.model_name }).OrderByDescending(g => g.Avg_price);
                    AnalyticsDataGrid.ItemsSource = r2;
                    break;
                case "Most accident cars":

                    AnalyticsDataGrid.ItemsSource = from c in autoManager.Car.ToList()
                                                    where c.Accident.Count > 0
                                                    orderby -c.Accident.Count
                                                    select new { c.carplate_number, c.Accident.Count };
                    break;

                case "Least mileage cars":
                    AnalyticsDataGrid.ItemsSource = autoManager.Car.ToList()
                        .GroupBy(c => new { c.Car_model.brand_name, c.Car_model.model_name })
                        .Select(g => new { Mileage = (int)g.Average(gr => gr.mileage), Brand = g.Key.brand_name, Model = g.Key.model_name }).OrderBy(g => g.Mileage);

                    break;


            }



        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
