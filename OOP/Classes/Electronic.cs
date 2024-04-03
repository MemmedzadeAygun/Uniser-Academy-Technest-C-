using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Classes
{
    internal class Electronic
    {
        public string? Model { get; set; }
        public string? Marc { get; set; }
        public virtual int Price { get; set; }
        public virtual string? OperatingSystem { get; set; }
    }
}
