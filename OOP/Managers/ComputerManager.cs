using OOP.Classes;
using OOP.İnterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Managers
{
    internal class ComputerManager : IComputer
    {
        public Computer _computer;
        public ComputerManager(Computer computer)
        {
            _computer = computer;
        }
        public double CalcPriceWithTax()
        {
            return _computer.Price * (1 + 0.04);
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Model={_computer.Model} Marc={_computer.Marc} OperatingSystem={_computer.OperatingSystem} Ram={_computer.Ram} ProcessorType={_computer.ProcessorType}");
        }

        public void GetUsefullOrNot()
        {
           if(_computer.Ram>4 && _computer.Ram < 8)
            {
                Console.WriteLine("Ofis isleri uchundur");
            }
           else if(_computer.Ram > 8 && _computer.Ram < 16)
            {
                Console.WriteLine("Proqramlasdirma uchundur");
            }
           else if(_computer.Ram > 16 && _computer.Ram < 32)
            {
                Console.WriteLine("Dizayn uchundur");
            }
           else if(_computer.Ram > 2 && _computer.Ram < 128)
            {
                Console.WriteLine("Oyun uchundur");
            }
        }
    }
}
