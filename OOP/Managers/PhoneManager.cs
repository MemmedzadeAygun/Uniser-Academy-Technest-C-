using OOP.Classes;
using OOP.İnterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Managers
{
    internal class PhoneManager : IPhone
    {
        public Phone _phone;
        public PhoneManager(Phone phone)
        {
            _phone = phone;
        }
        public double CalcPriceWithTax()
        {
            return _phone.Price * (1 + 0.04);        
        }
        
        public void CheckCamera()
        {
           if(_phone.CameraMegaPixel>4 && _phone.CameraMegaPixel < 32)
            {
                Console.WriteLine("Normal");
            }
           else if(_phone.CameraMegaPixel > 32 && _phone.CameraMegaPixel < 64)
            {
                Console.WriteLine("Yaxsi");
            }
           else if (_phone.CameraMegaPixel >= 64)
            {
                Console.WriteLine("Ela");
            }
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Model={_phone.Model} Marc={_phone.Marc} OperatingSystem={_phone.OperatingSystem} CameraMegaPixel={_phone.CameraMegaPixel}");
        }

    }
}
