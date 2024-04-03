using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaShop
{
    public class Pizza
    {
        public string PizzaType { get; set; }
        public string PizzaSize { get; set; }
        public int PizzaPrice { get; set; }

        public virtual double CalcPizzaPrice()
        {
            if (PizzaSize == "S")
            {
                return PizzaPrice = 15;
            }
            else if (PizzaSize == "M")
            {
                return PizzaPrice = 18;
            }
            else
            {
                return PizzaPrice = 23;
            }
        }
    }

    public class Margaritta:Pizza
    {
        public  override double CalcPizzaPrice()
        {
            if (PizzaSize == "S")
            {
                return PizzaPrice = 16;
            }
            else if (PizzaSize == "M")
            {
                return PizzaPrice = 22;
            }
            else
            {
                return PizzaPrice = 21;
            }
        }
    }

    public class Peperoni:Pizza
    {
        public override double CalcPizzaPrice()
        {
            if (PizzaSize == "S")
            {
                return PizzaPrice = 20;
            }
            else if (PizzaSize == "M")
            {
                return PizzaPrice = 24;
            }
            else
            {
                return PizzaPrice = 27;
            }
        }
    }

    public class Mix:Pizza
    {

    }
}
