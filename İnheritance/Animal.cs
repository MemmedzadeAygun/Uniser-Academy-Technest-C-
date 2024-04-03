using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İnheritance
{
    public class Animal
    {
        public string animal_name;
        public string animal_gender;
        public string animal_color;

        public void showAnimalInfo()
        {
            Console.WriteLine($"Animal Name: {animal_name}");
            Console.WriteLine($"Animal Gender: {animal_gender}");
            Console.WriteLine($"Animal Color: {animal_color}");
        }
    }
}
