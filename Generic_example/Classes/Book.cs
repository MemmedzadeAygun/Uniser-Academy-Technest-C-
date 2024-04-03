using Generic_example.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_example.Classes
{
    internal class Book:ITable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
       
    }
}
