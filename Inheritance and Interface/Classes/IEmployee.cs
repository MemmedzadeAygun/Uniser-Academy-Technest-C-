﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_and_Interface.Classes
{
    internal interface IEmployee
    {
        double Salary { get; set; }
        double NetSalary();     
    }
}
