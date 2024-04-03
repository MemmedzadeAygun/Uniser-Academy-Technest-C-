
////int number = 2345;
////int count=0;
////int sum = 0;
////int remainder;
////while (number != 0)
////{
////    remainder = number % 10;
////    number = number / 10;
////    sum = sum + remainder;
////    count++;
////}
////Console.WriteLine(count);
////Console.WriteLine(sum);


////Tapsiriq1
//int product = 1;
//for (int i = 1; i < 50; i = i + 3)
//{
//    product = product * i;
//}
//Console.WriteLine($"product={product}");
//Console.WriteLine("-----------------");


////Tapsiriq2
//int sum = 0;
//int multiply = 1;
//int count = 0;
//for (int i = -30; i < 28; i++)
//{
//    if ((i % 3 == 0 && i % 6 == 0) && i != 0)
//    {
//        sum = sum + i;
//    }

//    if ((i % 5 == 0 || i % 2 == 0) && i != 0)
//    {
//        multiply = multiply * i;
//    }

//    if (i % 2 != 0)
//    {
//        count++;
//    }
//}
//Console.WriteLine($"sum= {sum}");
//Console.WriteLine($"multiply= {multiply}");
//Console.WriteLine($"count= {count}");
//Console.WriteLine("-----------------");


////Tapsiriq3
//int number = 304001;
//int countOfNumber = 0;
//int remainder;
//int sumOfNumber = 0;
//while (number != 0)
//{
//    remainder = number % 10;
//    number = number / 10;
//    countOfNumber++;
//    sumOfNumber = sumOfNumber + remainder;
//}
//Console.WriteLine($"countOfNumber= {countOfNumber}");
//Console.WriteLine($"sumOfNumber= {sumOfNumber}");
//Console.WriteLine("-----------------");


////Tapsiriq4
////1ci usul
//int numberTwo = 4573;
//int a = numberTwo / 1000;
//int b = (numberTwo / 100) % 10;
//int c = (numberTwo / 10) % 10;
//int d = numberTwo % 10;
//Console.WriteLine("inverseOfNumber1=" + d + "" + c + "" + "" + b + "" + a);

////2ci usul
//int numberThree = 4573;
//int remainder2;
//int inverseOfNumber = 0;
//while (numberThree > 0)
//{
//    remainder2 = numberThree % 10;
//    numberThree = numberThree / 10;
//    inverseOfNumber = inverseOfNumber * 10 + remainder2;
//}
//Console.WriteLine($"inverseOfNumber2= {inverseOfNumber}");


////Tapsiriq5
//int finalValue = 3;
//int initialValue = 0;
//while (initialValue < finalValue)
//{
//    Console.Write("Enter your login:");
//    string login = Console.ReadLine();

//    Console.Write("Enter your password:");
//    string password = Console.ReadLine();

//    if(login=="booleanteach" && password == "booleanms13")
//    {
//        Console.WriteLine("Sisteme daxil oldunuz");
//        break;
//    }
//    else
//    {
//        if (login != "booleanteach")
//        {
//            Console.WriteLine("Login yanlisdir");
//        }
//        else if (password != "booleanms13")
//        {
//            Console.WriteLine("Password yanlisdir");
//        }
//        else 
//        {
//            Console.WriteLine("Her ikisi yanlisdir");
//        }
//    }

//    initialValue++;

//    if (initialValue == finalValue)
//    {
//        Console.WriteLine("Sistem bloklanmisdir");
//        break;
//    }


//}


using Ders_ConsoleApp_;

Book book1 = new Book();
book1.WriterName = "Huseyn Cavid";
book1.BookName = "Iblis";
book1.Price = 30;
book1.GetInfo();





