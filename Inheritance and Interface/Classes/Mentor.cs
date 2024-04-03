using Inheritance_and_Interface.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_and_Interface.Classes
{
    internal class Mentor : Person, IEmployee
    {
        private int salary;
        public double Salary
        {
            get { return salary; }
            set
            {
                if (value < 250 || value > 20000)
                {
                    throw new ArgumentException("Salary is invalid");
                }
            }
        }


        public double NetSalary()
        {
            return Salary - (Salary * 0.04);
        }
    }
}
