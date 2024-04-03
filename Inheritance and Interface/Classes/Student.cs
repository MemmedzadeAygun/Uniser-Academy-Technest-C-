using Inheritance_and_Interface.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_and_Interface.Classes
{
    public class Student:Person,IPerson
    {
        
        public string GroupName { get; set; }

        public void Add()
        {
            Console.WriteLine($"{Id} student added");
        }

        public void GetData()
        {
            Console.WriteLine("Student Get Data");
        }
    }
}
