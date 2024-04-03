//Task1
//int sum = 0;
//int count = 0;
//int number = 1;
//while (number <= 30)
//{
//    if (number % 3 == 0 && number%2==0)
//    {
//        count++;
//        sum += number;
//    }
//    number++;
//}
//Console.WriteLine("sum="+ sum);
//Console.WriteLine("count=" + count);


//Task2
//int number = 1234;
//int count = 0;
//int sum = 0;

//while (number != 0)
//{
//    number /= 10;
//    sum += number;
//    count++;
//}
//Console.WriteLine($"Ededin reqemlerinin sayi: {count}");
//Console.WriteLine($"Ededin reqemleri cemi: {sum}");


int[] hesablarim = { 1200, 1300, 1400, 5000 };
start:
end:
Console.WriteLine("bankomata xos gelmisiniz");
Console.WriteLine("emeliyyatlarimiz asagidakilardir");
Console.WriteLine("1.hesablar haqqinda melumat");
Console.WriteLine("2.Pul kocurme");
Console.WriteLine("3.Cixis etmek");

Console.WriteLine("Etmek istediyiniz emeliyyati daxil edin");
Console.Write("Emeliyyat: ");
int emeliyyatNomresi = Convert.ToInt32(Console.ReadLine());

switch(emeliyyatNomresi)
{
    case 1:
        foreach(var Hesab in hesablarim)
        {
            Console.WriteLine($"{Array.IndexOf(hesablarim,Hesab)+1} hesabda {hesablarim[Array.IndexOf(hesablarim, Hesab)]}- mebleg var.");
        }

        Console.WriteLine("Davam etmek isteyirsiniz?");
        Console.WriteLine("Cavabinizi daxil edin: ");
        string cavab = Console.ReadLine().ToLower();
        if(cavab=="he")
        {
            goto start;
        }
        else if(cavab=="yox")
        {
            goto end;
        }
        else 
        {
            Console.WriteLine("duzgun cavab verin...");
        }

        break;

    case 2:
        Console.WriteLine("Pul kocurme emeliyyati");
        Console.WriteLine("Zehmet olmasa pul kocurulecek hesabin nomresini daxil edin");
        Console.WriteLine("Pul kocurulecek Hesab: ");
        int kocurulecekHEsabNomresi = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Pul cixarilacaq hesabin nomresini daxil edin");
        Console.Write("Pul cixarilacaq hesab");
        int cixarilacaqHesabNomresi = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Meblegi daxil");
        Console.Write("kocurulecek mebleg: ");
        int mebleg = Convert.ToInt32(Console.ReadLine());

        if (hesablarim[cixarilacaqHesabNomresi-1]<mebleg)
        {
            Console.WriteLine("Hesabda yeteri qeder mebleg yoxdur");

        }
        else
        {
            Console.WriteLine($"Siz{cixarilacaqHesabNomresi}.No hesabdan {mebleg} qeder meblegi" + $"{kocurulecekHEsabNomresi}.No hesaba kocurme emeliyyati edersiz...");
            Console.WriteLine($"{cixarilacaqHesabNomresi}.No hesabda olan balans: {(hesablarim[cixarilacaqHesabNomresi - 1])-mebleg}"+ $"{kocurulecekHEsabNomresi}. No hesabda balans:{(hesablarim[kocurulecekHEsabNomresi]-1)+mebleg}");
        }

        break;

    case 3:
        end:

}

