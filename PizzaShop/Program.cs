
namespace PizzaShop
{
    public class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Balance = 65;


            Pizza pizza = new Pizza();
            Console.WriteLine("Seciminiz hansidir?");
            Console.WriteLine("Margaritta"); 
            Console.WriteLine("Mix"); 
            Console.WriteLine("Peperonni");
            pizza.PizzaType = Console.ReadLine();

            if (pizza.PizzaType == "Margaritta")
            {
                Console.WriteLine("Kart Melumatlarininzi daxil edin");
                Console.WriteLine("Kart Hesabinizi daxil edin");
                person.CardNumber = Console.ReadLine();
                Console.WriteLine("Kart bitme muddetii qeyd edin");
                person.ExpDate= Console.ReadLine();
                Console.WriteLine("Kartin CVV daxil edin");
                person.CVV= Console.ReadLine(); 
                if(person.CardNumber.Length==16 && person.ExpDate.Length==5 && person.CVV.Length == 3)
                {
                    Margaritta margaritta = new Margaritta();
                    Console.WriteLine("Pizzanin olcusunu daxil edin");
                    margaritta.PizzaSize = Console.ReadLine();

                    Console.WriteLine("Pizzaniz hazirlanir");

                    Console.WriteLine($"Balans: {person.Balance-margaritta.CalcPizzaPrice()}");

                }
            }
            else if(pizza.PizzaType=="Peperonni")
            {
                Console.WriteLine("Kart Melumatlarininzi daxil edin");
                Console.WriteLine("Kart Hesabinizi daxil edin");
                person.CardNumber = Console.ReadLine();
                Console.WriteLine("Kart bitme muddetii qeyd edin");
                person.ExpDate = Console.ReadLine();
                Console.WriteLine("Kartin CVV daxil edin");
                person.CVV = Console.ReadLine();
                if (person.CardNumber.Length == 16 && person.ExpDate.Length == 5 && person.CVV.Length == 3)
                {
                    Peperoni peperonni = new Peperoni();
                    Console.WriteLine("Pizzanin olcusunu daxil edin");
                    peperonni.PizzaSize = Console.ReadLine();

                    Console.WriteLine("Pizzaniz hazirlanir");

                    Console.WriteLine($"Balans: {person.Balance - peperonni.CalcPizzaPrice()}");

                }
            }

        }
    }
}
