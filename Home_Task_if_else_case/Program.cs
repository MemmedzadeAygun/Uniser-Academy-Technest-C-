
//Task1
//Console.Write("Enter the department:");
//String department = Convert.ToString(Console.ReadLine());
//#region
//if(department=="HR")
//{
//    Console.WriteLine("Human resurces department");
//}
//else if(department=="IT")
//{
//    Console.WriteLine("Information Technology department");
//}
//else if(department=="Finance")
//{
//    Console.WriteLine("Finance department");
//}
//else
//{
//    Console.WriteLine("There is no such department");
//}
//#endregion

//Task2
//Console.Write("Enter the year:");
//int staj = Convert.ToInt32(Console.ReadLine());
//#region
//if(staj>=0 && staj<=2)
//{
//    Console.WriteLine("Your salary is 2000");
//}
//else if(staj>=3 && staj<=5)
//{
//    Console.WriteLine("Your salary is 5000");
//}
//else if(staj>=5 && staj<=10)
//{
//    Console.WriteLine("Your salary is 7000");
//}
//else
//{
//    Console.WriteLine("Your salary is 1000");
//}

//#endregion


//Task3
//Console.Write("Enter the clock:");
//int clock = Convert.ToInt32(Console.ReadLine());
//#region
//if(clock<12)
//{
//    Console.WriteLine("Good morning!");
//}
//else if (clock<17 && clock>12)
//{
//    Console.WriteLine("Good afternoon!");
//}
//else
//{
//    Console.WriteLine("Good night!");
//}
//#endregion

//Task4
//Console.Write("a=");
//int a = Convert.ToInt32(Console.ReadLine());
//Console.Write("b=");
//int b = Convert.ToInt32(Console.ReadLine());
//Console.Write("c=");
//int c = Convert.ToInt32(Console.ReadLine());

//double average = (a + b + c) / 3;
//if(average<20)
//{
//    Console.WriteLine("average="+average+" "+"Aktiv");
//}
//else if(average>20)
//{
//    Console.WriteLine("average="+average+" "+"Deaktiv");
//}

//1
//Console.Write("side1=");
//int side1 = Convert.ToInt32(Console.ReadLine());
//Console.Write("side2=");
//int side2 = Convert.ToInt32(Console.ReadLine());
//Console.Write("side3=");
//int side3 = Convert.ToInt32(Console.ReadLine());
//#region
//if(side1<side2+side3 && side2<side1+side3 && side3<side2+side1)
//{
//    Console.WriteLine("Such a triangle exists");
//}
//else
//{
//    Console.WriteLine("No such triangle exists");
//}

////2
//if(side1==side2 && side1==side3 && side2==side3)
//{
//    Console.WriteLine("Bu ucbucaq beraberterflidir");
//}
//else if(side1==side2 || side1==side3 || side2==side3)
//{
//    Console.WriteLine("Bu ucbucaq beraberyanlidir");
//}
//else if(side1!=side2 && side1!=side3 && side2!=side3)
//{
//    Console.WriteLine("Bu ucbucaq muxteliftereflidir");
//}
//#endregion


//3
//Console.Write("Enter the weather:");
//string weather = Console.ReadLine();
//switch(weather)
//{
//    case "cloudy":
//        Console.WriteLine("It might be cold, you need a jacket!");
//        break;

//    case "rainy":
//        Console.WriteLine("The weather is rainy, you should bring an umbrella!");
//        break;

//    case "sunny":
//        Console.WriteLine("The weather is warm!");
//        break;

//    default:
//        Console.WriteLine("There is no such weather");
//        break;
//}



//4
//Console.Write("Enter the number:");
//int number = Convert.ToInt32(Console.ReadLine());
//if(number>=1 && number<=12)
//{
//    switch(number)
//    {
//        case 1:
//            Console.WriteLine("January");
//            break;

//        case 2:
//            Console.WriteLine("February");
//            break;

//        case 3:
//            Console.WriteLine("March");
//            break;

//        case 4:
//            Console.WriteLine("April");
//            break;

//        case 5:
//            Console.WriteLine("May");
//            break;

//        case 6:
//            Console.WriteLine("June");
//            break;

//        case 7:
//            Console.WriteLine("July");
//            break;

//        case 8:
//            Console.WriteLine("August");
//            break;

//        case 9:
//            Console.WriteLine("September");
//            break;

//        case 10:
//            Console.WriteLine("October");
//            break;

//        case 11:
//            Console.WriteLine("November");
//            break;

//        case 12:
//            Console.WriteLine("December");
//            break;
//    }
//}
//else
//{
//    Console.WriteLine("Not true!");
//}


//5
//Console.Write("Number=");
//int number = Convert.ToInt32(Console.ReadLine());
//String result = (number < 0) ? "Number is negative" : "Number is positive";
//Console.WriteLine(result);