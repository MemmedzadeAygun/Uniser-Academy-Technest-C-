using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_and_Interface.Classes
{
    public class Person
    {

        public Person()
        {
            Console.WriteLine("Person constructor is work");
        }

        public Person(string msg)
        {
            Console.WriteLine(msg);
        }
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string FirstName { get; set; }
        public string Lastname { get; set; }
 
    }
}
