using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multithreading.Linq
{
    class LinkExamples
    {
        static IEnumerable<Employee> employees = new List<Employee>() { new Employee()
        {
        Department = Department.Civil, Dob = DateTime.UtcNow, EmpId = 1, EmpName = "Satish", Salary = 25000
        },
             new Employee()
        {
        Department = Department.Hardware, Dob = DateTime.UtcNow.AddYears(-10), EmpId = 1, EmpName = "Veeresh", Salary = 35000
        },
new Employee()
        {
        Department = Department.Mechanical, Dob = DateTime.UtcNow.AddYears(-10), EmpId = 1, EmpName = "vinod", Salary = 45000
        },
new Employee()
        {
        Department = Department.Software, Dob = DateTime.UtcNow.AddYears(-10), EmpId = 1, EmpName = "Niketh", Salary = 15000
        }
        };
        static void Mainq(string[] args)
        {
            var emp = employees.OrderByDescending(s => s.Salary).First();
            Console.WriteLine(emp.Salary);
        }
    }
}
