using static System.Console;
using static System.Convert;

//WriteLine("Bankomata xos gelmisiniz!");
//WriteLine("Emeliyyatlarimiz asagidakilardir");

//WriteLine("1.Pul cekme");
//WriteLine("2.Pul kocurme");
//WriteLine("3.Hesabi goster");
//WriteLine("4.cixish et");

//int Mebleg = 1000;

//Write("Icra olunacaq emeliyyati daxil edin: ");

//int emeliyyatNomresi = ToInt32(ReadLine());

//switch(emeliyyatNomresi)
//{
//    case 1:
//        WriteLine("Pul cekme emeliyyati");
//        WriteLine("siz 1-50,2-100,3-150 manat ceke bilersiniz");
//        Write("Cekilecek meblegi secin: ");
//        int cekilecekMebleg = ToInt32(ReadLine());
//        int sonHesab = 0;
//        switch(cekilecekMebleg)
//        {
//            case 1:
//                WriteLine("50 manat cekilecek");
//                 sonHesab = Mebleg - 50;
//                WriteLine($"Hesabiniz: {sonHesab}");
//                break;
//            case 2:
//                WriteLine("100 manat cekilecek");
//                 sonHesab = Mebleg - 100;
//                WriteLine($"Hesabiniz: {sonHesab}");
//                break;
//            case 3:
//                WriteLine("150 manat cekilecek");
//                 sonHesab = Mebleg - 150;
//                WriteLine($"Hesabiniz: {sonHesab}");
//                break;
//        }
//        break;
//    case 2:
//        WriteLine("Pul kocurme emeliyyati");
//        WriteLine("1-113pinli hesab");
//        WriteLine("2-109pinli hesab");
//        WriteLine("3-101pinli hesab");
//        WriteLine("Pul kocurulecek hesabi secin");

//        int hesabNomresi = ToInt32(ReadLine());
//        switch(hesabNomresi)
//        {
//            case 1:
//                WriteLine("113 nomreli hesaba pul kocuruldu");
//                break;
//            case 2:
//                WriteLine("109 nomreli hesaba pul kocuruldu");
//                break;
//            case 3:
//                WriteLine("101 nomreli hesaba pul kocuruldu");
//                break;
//            default:
//                WriteLine("Bazada bele bir hesab yoxdur");
//                break;
//        }
//        break;

//    case 3:
//        WriteLine($"Hesabiniz: {Mebleg}");
//        break;
//    case 4:
//        WriteLine("Cixis edilir..");
//        break;
//    default:
//        WriteLine("bele bir emeliyyat movcud deyil");
//        break;
//}

//WriteLine("Restoranimiza xos gelmisiniz...");
//Write("Hesabi daxil edin: ");
//double orderTotal = ToDouble(ReadLine());

//if(orderTotal>=100)
//{
//    WriteLine("Musterinin statusunu daxil edin");
//    String customerStatus = ReadLine().ToLower();
//    int discount = 0;
//    switch(customerStatus)
//    {
//        case "gold":
//            discount = 20;
//            WriteLine($"Size: {discount} endirim tetbiq olunur");
//            break;

//        case "silver":

//            discount = 15;
//            WriteLine($"Size: {discount} endirim tetbiq olunur");
//            break;

//        case "bronze":

//            discount = 10;
//            WriteLine($"Size: {discount} endirim tetbiq olunur");
//            break;

//        defoult:
//            discount = 5;
//            WriteLine($"Size: {discount} endirim tetbiq olunur");
//            break;
//    }

//    orderTotal = orderTotal - orderTotal + discount * 100;
//    WriteLine($"Endirim tetbiq olunmus hesabiniz {orderTotal}");

//}
//else 
//{
//    WriteLine("Endirim 100 manat asmis hesablara verilir");
//}


//quvvet
//for(int i=1; i<=7; i++)
//{
//    Console.WriteLine($"2-nin i-ci quvveti {Math.Pow(2, i)}");
//}

int factorialOfNumber = 1;
for(int i=1; i<=5; i++)
{
    factorialOfNumber = factorialOfNumber * i;
    Console.WriteLine($"i-ci edenin faktoriali: {factorialOfNumber}");
}
