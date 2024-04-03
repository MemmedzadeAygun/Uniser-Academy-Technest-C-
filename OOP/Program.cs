

using OOP.Classes;
using OOP.Managers;

Phone phone = new Phone();
phone.Price = 2000;
phone.OperatingSystem = "IOS";
phone.CameraMegaPixel = 12;


Computer computer = new Computer();
computer.Price = 6000;
computer.OperatingSystem = "Windows";
computer.ProcessorType = "Intel";
computer.Ram = 50;

PhoneManager phoneManager = new PhoneManager(new Phone {Model="Samsung",Marc="Galaxy S21",OperatingSystem="Android", Price=2000,CameraMegaPixel=25});
phoneManager.DisplayInfo();
Console.WriteLine(phoneManager.CalcPriceWithTax());
phoneManager.CheckCamera();


ComputerManager computermanager = new ComputerManager(new Computer { Model = "Lenovo", Marc = "ThinkPad X1 Carbon", OperatingSystem = "Windows", ProcessorType = "Intel", Ram = 7, Price = 6000 });
computermanager.DisplayInfo();
Console.WriteLine(computermanager.CalcPriceWithTax());
computermanager.GetUsefullOrNot();