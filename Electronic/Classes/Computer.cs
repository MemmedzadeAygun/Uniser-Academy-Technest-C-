using Electronics.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electronics
{
    public class Computer: Electronic
    {
        public int Id { get; private set; }
        public string Model { get; set; }
        public string Marc { get; set; }

        public Computer()
        {
            Id = 1;
        }

        private double price { get; set; }

        public override double Price
        {
            get { return price; }
            set
            {
                if (value > 12000 || value < 1000)
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

        public override string OperatingSystem
        {
            get { return operatingSystem; }
            set
            {
                if (value != "Windows" && value != "Linux" && value!="Macos")
                {
                    throw new Exception("Error!");
                }
                else
                {
                    operatingSystem = value;
                }
            }
        }

        private string processorType;

        public string ProcessorType
        {
            get { return processorType; }
            set 
            { 
                if(value!="Intel" && value != "Ryzen")
                {
                    throw new Exception("Error");
                }
                else
                {
                    processorType = value;
                }
            }
        }

        private int ram;

        public int Ram
        {
            get { return ram; }
            set
            { 
                if(value<4 || value > 128)
                {
                    throw new Exception("Error");
                }
                else
                {
                    ram = value;
                }
            }
        }




        public double CalcPriceWithTax(double taxRate)
        {
            return price * (1 + taxRate);
        }

        public override void  DisplayInfo()
        {
            Console.WriteLine($"Model:{Model} Marc:{Marc} OperatingSystem:{OperatingSystem} ProcessorType:{ProcessorType} Ram:{Ram}");
        }

        public void GetUsefullOrNot()
        {
            if(ram>=4 && ram <= 8)
            {
                Console.WriteLine("Ofis isleri uchundur");
            }
            else if(ram>=8 && ram <= 16)
            {
                Console.WriteLine("Proqramlasdirma uchundur");
            }
            else if(ram>=16 && ram <= 32)
            {
                Console.WriteLine("Dizayn uchun");
            }
            else if(ram>=2 && ram <= 128)
            {
                Console.WriteLine("Oyun uchundur");
            }
        }
       
        
    }
}
