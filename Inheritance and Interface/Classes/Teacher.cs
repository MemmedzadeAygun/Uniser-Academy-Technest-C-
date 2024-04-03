using Inheritance_and_Interface.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_and_Interface.Classes
{
    public class Teacher:Person, IPerson,IEmployee
    {
        public Teacher()
        {
            Console.WriteLine("Teacher constructor is work");
        }

        public Teacher(string msg):base(msg)
        {

        }

        public int Experiance { get; set; }

        private int salary;
        public double Salary
        {
            get { return salary; }
            set 
            {
                if(value<250 || value > 20000)
                {
                    throw new ArgumentException("Salary is invalid");
                }
            }
        }
       

        public double NetSalary()
        {
            return Salary - (Salary * 0.04);
        }

        public void GetData()
        {
            Console.WriteLine("Teacher Get Data");
        }

        public void Add()
        {
            Console.WriteLine($"{Id} teacher added");
        }
    }
}
