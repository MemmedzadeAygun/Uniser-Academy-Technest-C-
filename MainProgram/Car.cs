using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainProgram
{
    public class Car
    {
        public string CarName { get; set; }
        public string CarModel { get; set; }

        public int Price { get; set; }
    }

    public class Mercedes : Car
    {
        public string CompanyName { get; set; }
    }

    public class BMW : Car
    {
        public string CompanyName { get; set; }
    }

    public class Kia : Car
    {
        public string CompanyName
        {
            get; set;
        }
    }
}
