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

namespace Employee_Lookup_App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {
        List<EmployeeClass> employeeList = new List<EmployeeClass>();

        public MainWindow()
        {
            employeeList.Add(new EmployeeClass("Bob", "Accounting", 28, "Accountant"));
            employeeList.Add(new EmployeeClass("Joe", "Research & Development", 25, "Head Researcher"));
            employeeList.Add(new EmployeeClass("Tyrone", "Engineering", 28, "Civil Engineer"));
            employeeList.Add(new EmployeeClass("Joshua", "Engineering", 20, "Intern"));
            employeeList.Add(new EmployeeClass("Tate", "Human Resources", 27, "Recruiter"));
            employeeList.Add(new EmployeeClass("Ashley", "Sales", 28, "Sales Woman"));

            InitializeComponent();
        }

        public void search_user(object sender, RoutedEventArgs e)
        {
            if(button_1.IsChecked == true)
            {
                string value = button_1.Content.ToString();
                List<EmployeeClass> emp = pull_Information(value);

                fill_results_table(emp);
            }

            if (button_2.IsChecked == true)
            {
                string value = button_2.Content.ToString();
                List<EmployeeClass> emp = pull_Information(value);

                fill_results_table(emp);
            }

            if (button_3.IsChecked == true)
            {
                string value = button_3.Content.ToString();
                List<EmployeeClass> emp = pull_Information(value);

                fill_results_table(emp);
            }

            if (button_4.IsChecked == true)
            {
                string value = button_4.Content.ToString();
                List<EmployeeClass> emp = pull_Information(value);

                fill_results_table(emp);
            }

            if (button_5.IsChecked == true)
            {
                string value = button_5.Content.ToString();
                List<EmployeeClass> emp = pull_Information(value);

                fill_results_table(emp);
            }

            if (button_6.IsChecked == true)
            {
                string value = button_6.Content.ToString();
                List<EmployeeClass> emp = pull_Information(value);

                fill_results_table(emp);
            }
        }

        public void sort_users(object sender, RoutedEventArgs e)
          {
            if(Name.IsChecked == true)
            {
                string value = Name.Content.ToString();
                List<EmployeeClass> emp = pull_Information(value);

                fill_results_table(emp);
            }

            else if(Department.IsChecked == true)
            {
                string value = Department.Content.ToString();
                List<EmployeeClass> emp = pull_Information(value);

                fill_results_table(emp);
            }

            else if(Age.IsChecked == true)
            {
                string value = Age.Content.ToString();
                List<EmployeeClass> emp = pull_Information(value);

                fill_results_table(emp);
            }

            else if(Job_Title.IsChecked == true)
            {
                string value = Job_Title.Content.ToString();
                List<EmployeeClass> emp = pull_Information(value);

                fill_results_table(emp);
            }
          }

        public void fill_results_table(List<EmployeeClass> list)
        {
            Results_Box.Children.Clear();

            foreach(EmployeeClass person in list)
            {
                TextBlock textBlock = new TextBlock();
                textBlock.Text = "Name: " + person.name + "\nDepartment: " + person.department + "\nAge: " + person.age + "\nJob Title: " + person.job_title;
                textBlock.Margin = new Thickness(0, 5, 0, 0);

                if (list.Count > 1)
                    textBlock.FontSize = 9;

                else
                    textBlock.FontSize = 15;

                Results_Box.Children.Add(textBlock);
            }
        }

        public List<EmployeeClass> pull_Information(string value)
        {
            List<EmployeeClass> result = new List<EmployeeClass>();
            

            switch (value)
            {
                case "Name":
                    result = employeeList.OrderBy(emp => emp.name).ThenBy(emp => emp.age).ToList();
                    break;

                case "Department":
                    result = employeeList.OrderBy(emp => emp.department).ThenBy(emp => emp.name).ToList();
                    break;

                case "Age":
                    result = employeeList.OrderBy(emp => emp.age).ThenBy(emp => emp.name).ToList();
                    break;

                case "Job Title":
                    result = employeeList.OrderBy(emp => emp.job_title).ThenBy(emp => emp.name).ToList();
                    break;

                default:
                    result = employeeList.Where(emp => emp.name == value).ToList();
                    break;
            }

            return result;
        }
    }
}
