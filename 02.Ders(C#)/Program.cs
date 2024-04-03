// See https://aka.ms/new-console-template for more information
using System;

#region Tam ededler

//int numberOne = 10;
//short numberTwo = 11;
//long numberThree = 12;

//Console.WriteLine(numberOne);
//Console.WriteLine(numberTwo);
//Console.WriteLine(numberThree);


//Console.WriteLine("Adinizi daxil edin");
//String name = Console.ReadLine();
//Console.WriteLine("Soyadinizi daxil edin");
//String surname = Console.ReadLine();
//Console.WriteLine("Yasinizi daxil edin");
//int age = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine($"menim adim:"+name+"menim soyadim:"+surname+"yasim"+age);

//Console.WriteLine("1ci ededi daxil edin");
//int numberOne = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("2ci ededi daxil edin");
//int numberTwo = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("3cu ededi daxil edin");
//int numberThree = Convert.ToInt32(Console.ReadLine());

//double result = Math.Pow(numberOne, 1.0 / 3) * Math.Pow(numberOne*numberTwo*numberThree,1.0/3);
//Console.WriteLine(result);


//eve
//Input a,b,c

//d=a ustu3*b ustu2+c ustu3/a+b+c

//Console.WriteLine("a-ni daxil edin:");
//int a = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("b-ni daxil edin:");
//int b=Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("c-ni daxil edin:");
//int c = Convert.ToInt32(Console.ReadLine());
//int d = Math.Pow(Math.Pow(Math.Pow(a, 3) * b),2)+c),3))/a+b+c;


//Console.WriteLine("a-ni daxil edin:");
//int a = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("b-ni daxil edin:");
//int b = Convert.ToInt32(Console.ReadLine());
//if (a > b)
//{
//    Console.WriteLine("Max=" + a);
//}
//else if (b > a)
//{
//    Console.WriteLine("Max=" + b);
//}
//else if (a == b)
//{
//    Console.WriteLine("a equals to b");
//}

int season = 4;
switch(season)
{
    case 1:
        Console.WriteLine("Spring");
        break;
    case 2:
        Console.WriteLine("Summer");
        break;
    case 3:
        Console.WriteLine("Autum");
        break;
    case 4:
        Console.WriteLine("Winter");
        break;
    default:
        Console.WriteLine("Bele bir fesil yoxdur");
        break;
}

#endregion