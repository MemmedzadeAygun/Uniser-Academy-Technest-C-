using Electronics.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electronics
{
    public class Phone:Electronic
    {
        public int Id { get; private set; } 
        public string Model { get; set; }
        public string Marc { get; set; }

        public Phone()
        {
            Id = 1;
        }

        private double price { get; set; }

        public override double Price
        {
            get { return price; }
            set 
            { 
                if(value>6000 && value < 100)
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
                if(value!="Android" && value != "IOS")
                {
                    throw new Exception("Error!");
                }
                else
                {
                    operatingSystem = value;
                }
            }
        }


        private int cameraMegaPixel;

        public int CameraMegaPixels
        {
            get { return cameraMegaPixel; }
            set 
            { 
                if(value<4 && value >128)
                {
                    throw new Exception("Error");
                }
                else
                {
                    cameraMegaPixel = value;
                }
            }
        }

        
        public double CalcPriceWithTax(double taxRate)
        {
            return price * (1+ taxRate);
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Model:{Model} Marc:{Marc} OperatingSystem:{OperatingSystem} CameraMegaPixel:{CameraMegaPixels}");
        }


        public void CheckCamera()
        {
           if(cameraMegaPixel>=4 && cameraMegaPixel <= 32)
            {
                Console.WriteLine("Normal");
            }
           else if(cameraMegaPixel>=32 && cameraMegaPixel <= 64)
            {
                Console.WriteLine("Yaxsi");
            }
           else if (cameraMegaPixel > 64)
            {
                Console.WriteLine("Ela");
            }
        }
    }
}
