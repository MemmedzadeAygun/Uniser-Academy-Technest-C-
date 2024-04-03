using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İnheritance
{
    public class Cat: Animal
    {
        public int cat_age { get; set; }
        public void CatMethod()
        {
            Console.WriteLine("Pisik miyoldayir...");
            Console.WriteLine($"Cat Age: {cat_age}");
        }

    }
}
