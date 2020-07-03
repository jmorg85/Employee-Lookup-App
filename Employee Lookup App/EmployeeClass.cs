using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Lookup_App
{
    public class EmployeeClass
    {
        public string name;
        public string department;
        public int age;
        public string job_title;

        public EmployeeClass(string input_name, string input_department, int input_age, string input_job_title){
            name = input_name;
            department = input_department;
            age = input_age;
            job_title = input_job_title;
        }
    }
}
