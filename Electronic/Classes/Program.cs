

using Electronics;
using Electronics.Classes;
using Electronics.Managers;

public class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the Phone Model: ");
        string model = Console.ReadLine();
        Console.Write("Enter the Phone Marc: ");
        string marc = Console.ReadLine();
        Console.Write("Enter the Phone Price: ");
        int price = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the Phone OperatingSystem: ");
        string operatingSystem = Console.ReadLine();
        Console.Write("Enter the Phone CameraMegaPixel: ");
        int cameraMegaPixel = Convert.ToInt32(Console.ReadLine());

        Phone phone = new Phone();
        phone.Model = model;
        phone.Marc = marc;
        phone.Price = price;
        phone.OperatingSystem = operatingSystem;
        phone.CameraMegaPixels = cameraMegaPixel;


        phone.DisplayInfo();
        phone.CheckCamera();
        Console.WriteLine($"Price With Tax: {phone.CalcPriceWithTax(0.04)}");




        Console.Write("Enter the Computer Model: ");
        string model2 = Console.ReadLine();
        Console.Write("Enter the Computer Marc: ");
        string marc2 = Console.ReadLine();
        Console.Write("Enter the Computer Price: ");
        int price2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the Computer OperatingSystem: ");
        string operatingSystem2 = Console.ReadLine();
        Console.Write("Enter the Computer ProcessorType: ");
        string processorType = Console.ReadLine();
        Console.Write("Enter the Computer Ram: ");
        int ram = int.Parse(Console.ReadLine());

        Computer computer = new Computer();
        computer.Model = model2;
        computer.Marc = marc2;
        computer.Price = price2;
        computer.OperatingSystem = operatingSystem2;
        computer.ProcessorType = processorType;
        computer.Ram = ram;


        computer.DisplayInfo();
        computer.GetUsefullOrNot();
        Console.WriteLine($"Price With Tax: {computer.CalcPriceWithTax(0.04)}");

        //ComputerManager compMananager = new ComputerManager(new Computer{Model="Lenova"});
        //compMananager.DisplayInfo();


        Electronic electronic = new Electronic();
        electronic.Price = 1000;
        electronic.OperatingSystem = "Macos";

       

    }
}