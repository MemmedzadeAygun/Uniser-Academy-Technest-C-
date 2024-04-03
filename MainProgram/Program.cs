
using MainProgram;

Console.WriteLine("Melumatlarinizi daxil edin");
Console.Write("Adinizi daxil edin: ");
string name = Console.ReadLine();
Console.Write("Soyadinizi daxil edin: ");
string surname= Console.ReadLine();
Console.Write("Balansinizi daxil edin: ");
int balans = int.Parse(Console.ReadLine());
Guid guid = new Guid();

Person person1 = new Person();
person1.Surname = surname;
person1.Name = name;
person1.Balance = balans;
person1.id = guid;

Console.WriteLine($"Surname: {person1.Surname} Name: {person1.Name} Balance: {person1.Balance}");

Car car = new Car();
car.CarName = "BMW";
car.CarModel = "hd";
car.Price = 700;

if (car.Price > person1.Balance)
{
    Console.WriteLine("Balansinizda kifayet qeder vesait yoxdur");
}
else
{
    Console.WriteLine("Emeliyyat ugurla yerine yetirildi");
    Console.WriteLine($"Balansiniz: {person1.Balance - car.Price}");
}


