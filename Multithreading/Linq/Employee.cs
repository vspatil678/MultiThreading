using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multithreading.Linq
{
    class Employee
    {
        public int EmpId { get; set; }

        public string EmpName { get; set; }

        public int Salary { get; set; }

        public DateTime Dob { get; set; }

        public Department Department { get; set; }
    }
}
