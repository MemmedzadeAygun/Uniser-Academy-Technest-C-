using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Files
{

    public class Employee
    {
        public string employeed { get; set; } = Guid.NewGuid().ToString();
        public string employeeeName { get; set; }
        public string employeeSurname { get; set; }
        public int salary { get; set; }
    }
}

