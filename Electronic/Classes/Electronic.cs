using Electronics.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electronics.Classes
{
    public class Electronic:IElectronic
    {
        private double price { get; set; }
        public virtual double Price
        {
            get { return price; }
            set
            {
                if (value > 5000 && value < 50)
                {
                    throw new Exception("Error!");
                }
                else
                {
                    price = value;
                }
            }
        }

        private string operatingSystem { get; set; }
        public virtual string OperatingSystem 
        {
            get { return OperatingSystem; }
            set
            {
                if (value != "Macos")
                {
                    throw new Exception("Error!");
                }
                else
                {
                    operatingSystem = value;
                }
            }
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Price: {Price} OperatingSystem: {OperatingSystem}");
        }
    }
}
