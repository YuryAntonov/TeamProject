using LogicAndDb;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using TeamProjectAutoRent.Views;

namespace TeamProjectAutoRent
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window

    {
        public AutoRentModel autoManager { get; set; }
        private List<string> itemTypes = new List<string> {

            "Brands",
            "Car models",
            "Offices",
            "Customers",
            "Employees",
            "Accidents",
            "Cars",
            "Lease contracts",
            "Purchase contracts"
            };
        public MainWindow()
        {
            InitializeComponent();
            autoManager = new AutoRentModel();
            CategorySelectorComboBox.ItemsSource = itemTypes;
            CategorySelectorComboBox.SelectedIndex = 0;

        }

        private void CategorySelectorComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            EditItemButton.IsEnabled = true;
            switch (CategorySelectorComboBox.SelectedValue)
            {
                case "Brands":
                    var brands = autoManager.Brand.ToList();
                    MainDataGrid.ItemsSource = from b in brands select new { Brand = b.brand_name, PriceCategory = b.price_category };
                    break;
                case "Car models":
                    var models = autoManager.Car_model.ToList();
                    MainDataGrid.ItemsSource = from m in models select new { ModelName = m.model_name, Brand = m.brand_name };
                    EditItemButton.IsEnabled = false;
                    break;
                case "Offices":
                    var offices = autoManager.Office.ToList();
                    MainDataGrid.ItemsSource = from o in offices select new { Address = o.office_address, Capacity = o.capacity };
                    break;
                case "Customers":
                    var customers = autoManager.Customer.ToList();
                    MainDataGrid.ItemsSource = from c in customers
                                               select new
                                               {
                                                   PassportNumber = c.passport_number,
                                                   FullName = c.full_name,
                                                   Gender = c.gender,
                                                   DrivingLevel = c.driving_experience,
                                                   PhoneNumber = c.phone_number,
                                                   Address = c.customer_address
                                               };
                    break;
                case "Employees":
                    var employees = autoManager.Employee.ToList();
                    MainDataGrid.ItemsSource = from emp in employees
                                               select new
                                               {
                                                   PassportNumber = emp.passport_number,
                                                   FullName =
                         emp.full_name,
                                                   Gender = emp.gender,
                                                   BirthDate = emp.birth_date,
                                                   OfficeLocation = emp.office_address
                                               };
                    break;
                case "Accidents":
                    var accidents = autoManager.Accident.ToList();
                    MainDataGrid.ItemsSource = from a in accidents
                                               select new
                                               {
                                                   AccidentDate = a.accident_date,
                                                   DamageLevel =
                           a.damage,
                                                   Description = a.damage_description,
                                                   CarPlateNumber = a.carplate_number
                                               };
                    break;
                case "Cars":
                    var cars = autoManager.Car.ToList();
                    MainDataGrid.ItemsSource = from c in cars
                                               select new
                                               {
                                                   CarPlateNumber = c.carplate_number,
                                                   Mileage = c.mileage,
                                                   Status = c.car_status,
                                                   Color = c.color,
                                                   Model = c.model_name
                                               };
                    break;
                case "Lease contracts":
                    EditItemButton.IsEnabled = false;
                    var lcontracts = autoManager.Lease_contract.ToList();
                    MainDataGrid.ItemsSource = from l in lcontracts
                                               select new
                                               {
                                                   ContractNumber = l.contract_number,
                                                   PassportNumber = l.passport_number,
                                                   CarPlateNumber = l.carplate_number,
                                                   BaseOfficeLocation = l.native_office_address,
                                                   ReturnOfficeAddress = l.return_office_address,
                                                   StartDate = l.start_date,
                                                   EndDate = l.end_date,
                                                   IssueDate = l.issue_date,
                                                   DailyCost = l.daily_cost
                                               };

                    break;
                case "Purchase contracts":
                    EditItemButton.IsEnabled = false;
                    var pcontracts = autoManager.Purchase_contract.ToList();
                    MainDataGrid.ItemsSource = from p in pcontracts
                                               select new
                                               {
                                                   ContractNumber = p.contract_number,
                                                   PassportNumber = p.passport_number,
                                                   CarPlateNumber = p.carplate_number,
                                                   OfficeLocation = p.office_address,
                                                   Price = p.amount,
                                                   Date = p.date
                                               };
                    break;
                default:
                    throw new NotImplementedException();

            }
        }

        private void EditItemButton_Click(object sender, RoutedEventArgs e)
        {
            if (MainDataGrid.SelectedItem != null)
            {
                switch (CategorySelectorComboBox.SelectedValue)
                {
                    case "Brands":
                        var tbb = autoManager.Brand.ToList()[MainDataGrid.SelectedIndex];
                        var tbbl = new List<Brand>() { tbb };
                        BrandWindow brandWindow = new BrandWindow(tbbl);
                        brandWindow.ShowDialog();
                        if (brandWindow.successFlag)
                        {

                            tbb.price_category = brandWindow.Brand.price_category;

                            autoManager.SaveChanges();
                        }
                        break;
                    case "Car models":
                        //var item = autoManager.Car_model.ToList()[MainDataGrid.SelectedIndex];
                        //var itemL = new List<Car_model>() { item };
                        //CarModelWindow carModelWindow = new CarModelWindow(itemL);
                        //carModelWindow.ShowDialog();
                        //if (carModelWindow.successFlag)
                        //{
                        //    item.brand_name = carModelWindow.brand_nameTextBox.Text;
                        //    autoManager.SaveChanges();
                        //}
                        break;
                    case "Offices":
                        var office = autoManager.Office.ToList()[MainDataGrid.SelectedIndex];
                        var ofL = new List<Office>() { office };
                        OfficeWindow officeWindow = new OfficeWindow(ofL);
                        officeWindow.ShowDialog();
                        if (officeWindow.successFlag)
                        {
                            office.capacity = officeWindow.office.capacity;
                            autoManager.SaveChanges();
                        }
                        break;
                    case "Customers":
                        var customer = autoManager.Customer.ToList()[MainDataGrid.SelectedIndex];
                        var cL = new List<Customer>() { customer };
                        CustomerWindow customerWindow = new CustomerWindow(cL);
                        customerWindow.ShowDialog();
                        if (customerWindow.successFlag)
                        {
                            customer.customer_address = customerWindow.customer.customer_address;
                            customer.full_name = customerWindow.customer.full_name;
                            customer.driving_experience = customerWindow.customer.driving_experience;
                            customer.gender = customerWindow.customer.gender;
                            customer.phone_number = customerWindow.customer.phone_number;
                            autoManager.SaveChanges();
                        }
                        break;
                    case "Employees":
                        var emp = autoManager.Employee.ToList()[MainDataGrid.SelectedIndex];
                        var empL = new List<Employee>() { emp };
                        EmployeeWindow employeeWindow = new EmployeeWindow(empL, autoManager.Office.ToList());
                        employeeWindow.ShowDialog();
                        if (employeeWindow.successFlag)
                        {
                            emp.full_name = employeeWindow.employee.full_name;
                            emp.gender = employeeWindow.employee.gender;
                            emp.birth_date = employeeWindow.employee.birth_date;
                            emp.office_address = employeeWindow.employee.office_address;
                            autoManager.SaveChanges();
                        }
                        break;
                    case "Accidents":
                        var ac = autoManager.Accident.ToList()[MainDataGrid.SelectedIndex];
                        var acL = new List<Accident>() { ac };
                        AccidentWindow accidentWindow = new AccidentWindow(acL, autoManager.Car.ToList());
                        accidentWindow.ShowDialog();
                        if (accidentWindow.successFlag)
                        {
                            ac.accident_date = accidentWindow.accident.accident_date;
                            ac.carplate_number = accidentWindow.accident.carplate_number;
                            ac.damage = accidentWindow.accident.damage;
                            ac.damage_description = accidentWindow.accident.damage_description;
                            autoManager.SaveChanges();
                        }
                        break;
                    case "Cars":
                        var car = autoManager.Car.ToList()[MainDataGrid.SelectedIndex];
                        var carL = new List<Car>() { car };
                        CarWindow carWindow = new CarWindow(carL, autoManager.Car_model.ToList());
                        carWindow.ShowDialog();
                        if (carWindow.successFlag)
                        {
                            car.carplate_number = carWindow.car.carplate_number;
                            car.car_status = carWindow.car.car_status;
                            car.color = carWindow.car.color;
                            car.mileage = carWindow.car.mileage;
                            car.model_name = carWindow.car.model_name;
                            autoManager.SaveChanges();
                        }
                        break;
                    case "Lease contracts":
                        //var ll = autoManager.Lease_contract.ToList()[MainDataGrid.SelectedIndex];
                        //var lll = new List<Lease_contract>() { ll };
                        //var lease_Contract = new LeaseWindow(lll);
                        //lease_Contract.ShowDialog();
                        break;
                    case "Purchase contracts":
                        //var pp = autoManager.Purchase_contract.ToList()[MainDataGrid.SelectedIndex];
                        //var ppL = new List<Purchase_contract>() { pp };
                        //PurchaseWindow purchaseWindow = new PurchaseWindow(ppL);
                        //purchaseWindow.ShowDialog();
                        break;
                    default:
                        throw new NotImplementedException();
                }
                UpdateGrid();
            }


            else MessageBox.Show("Please, select one record to edit!", "Warning");
        }

        private void AddItemButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                switch (CategorySelectorComboBox.SelectedValue)
                {
                    case "Brands":
                        BrandWindow brandWindow = new BrandWindow();
                        brandWindow.ShowDialog();
                        if (brandWindow.successFlag)
                        {

                            autoManager.Brand.Add(brandWindow.Brand);
                            autoManager.SaveChanges();
                        }
                        break;
                    case "Car models":
                        CarModelWindow carModelWindow = new CarModelWindow(autoManager.Brand.ToList());
                        carModelWindow.ShowDialog();
                        if (carModelWindow.successFlag)
                        {
                            autoManager.Car_model.Add(carModelWindow.car_model);
                            autoManager.SaveChanges();
                        }
                        break;
                    case "Offices":
                        OfficeWindow officeWindow = new OfficeWindow();
                        officeWindow.ShowDialog();
                        if (officeWindow.successFlag)
                        {
                            autoManager.Office.Add(officeWindow.office);
                            autoManager.SaveChanges();
                        }
                        break;
                    case "Customers":
                        CustomerWindow customerWindow = new CustomerWindow();
                        customerWindow.ShowDialog();
                        if (customerWindow.successFlag)
                        {
                            autoManager.Customer.Add(customerWindow.customer);
                            autoManager.SaveChanges();
                        }
                        break;
                    case "Employees":
                        EmployeeWindow employeeWindow = new EmployeeWindow(autoManager.Office.ToList());
                        employeeWindow.ShowDialog();
                        if (employeeWindow.successFlag)
                        {
                            autoManager.Employee.Add(employeeWindow.employee);
                            autoManager.SaveChanges();
                        }
                        break;
                    case "Accidents":
                        AccidentWindow accidentWindow = new AccidentWindow(autoManager.Car.ToList());
                        accidentWindow.ShowDialog();
                        if (accidentWindow.successFlag)
                        {
                            var id = autoManager.Accident.Select(a => a.accident_id).Max() + 1;
                            accidentWindow.accident.accident_id = id;
                            autoManager.Accident.Add(accidentWindow.accident);
                            autoManager.SaveChanges();
                        }
                        break;
                    case "Cars":
                        CarWindow carWindow = new CarWindow(autoManager.Car_model.ToList());
                        carWindow.ShowDialog();
                        if (carWindow.successFlag)
                        {
                            autoManager.Car.Add(carWindow.car);
                            autoManager.SaveChanges();
                        }
                        break;
                    case "Lease contracts":
                        LeaseWindow leaseWindow = new LeaseWindow(autoManager.Office.ToList(), autoManager.Customer.ToList(), autoManager.Car.ToList());
                        leaseWindow.ShowDialog();
                        if (leaseWindow.successFlag)
                        {
                            autoManager.Lease_contract.Add(leaseWindow.lease_Contract);
                            autoManager.SaveChanges();
                        }
                        break;
                    case "Purchase contracts":
                        PurchaseWindow purchaseWindow = new PurchaseWindow(autoManager.Office.ToList(), autoManager.Customer.ToList(), autoManager.Car.ToList());
                        purchaseWindow.ShowDialog();
                        if (purchaseWindow.successFlag)
                        {
                            autoManager.Purchase_contract.Add(purchaseWindow.purchase_Contract);
                            autoManager.SaveChanges();
                        }
                        break;

                }


            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException)
            {
                MessageBox.Show("Error during adding item! Probably, you are trying to insert duplicate key into db", "Error");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error during adding item! " + ex.Message + " " + ex.InnerException, "Warning");
                
            }
            UpdateGrid();


        }
        public void UpdateGrid()
        {
            CategorySelectorComboBox.SelectedIndex += 1;
            CategorySelectorComboBox.SelectedIndex -= 1;
        }

        private void DeleteItemButton_Click(object sender, RoutedEventArgs e)
        {
            if (MainDataGrid.SelectedIndex >= 0)
            {


                switch (CategorySelectorComboBox.SelectedValue)
                {
                    case "Brands":
                        autoManager.Brand.Remove(autoManager.Brand.ToList()[MainDataGrid.SelectedIndex]);
                        break;
                    case "Car models":
                        autoManager.Car_model.Remove(autoManager.Car_model.ToList()[MainDataGrid.SelectedIndex]);
                        break;
                    case "Offices":
                        autoManager.Office.Remove(autoManager.Office.ToList()[MainDataGrid.SelectedIndex]);
                        break;
                    case "Customers":
                        autoManager.Customer.Remove(autoManager.Customer.ToList()[MainDataGrid.SelectedIndex]);
                        break;
                    case "Employees":
                        autoManager.Employee.Remove(autoManager.Employee.ToList()[MainDataGrid.SelectedIndex]);
                        break;
                    case "Accidents":
                        autoManager.Accident.Remove(autoManager.Accident.ToList()[MainDataGrid.SelectedIndex]);
                        break;
                    case "Cars":
                        autoManager.Car.Remove(autoManager.Car.ToList()[MainDataGrid.SelectedIndex]);
                        break;
                    case "Lease contracts":
                        autoManager.Lease_contract.Remove(autoManager.Lease_contract.ToList()[MainDataGrid.SelectedIndex]);
                        break;
                    case "Purchase contracts":
                        autoManager.Purchase_contract.Remove(autoManager.Purchase_contract.ToList()[MainDataGrid.SelectedIndex]);
                        break;


                }
                var res = MessageBox.Show("Are you sure you want to delete this record?", "Question", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (res == MessageBoxResult.Yes)

                    autoManager.SaveChanges();

                UpdateGrid();
            }
            else
            {
                MessageBox.Show("Please, choose valid record", "Warning");
            }
        }

        private void AnalyticsWindow_Click(object sender, RoutedEventArgs e)
        {
            AnalyticsWindow aw = new AnalyticsWindow(autoManager);
            
            aw.ShowDialog();
            Show();
        }
    }
}
