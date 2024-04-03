using static System.Console;

WriteLine("Restoranimiza xos gelmisiniz");
WriteLine("Menyuya asagidakilar daxildir");

WriteLine("1.Isti yemekler");
WriteLine("2.Sorbalar ve blyonlar");
WriteLine("3.Ickiler");
WriteLine("4.Desertler");

Write("Kategoriya nomresini daxil edin:");
int kategoriya_nomresi = Convert.ToInt32(Console.ReadLine());

switch(kategoriya_nomresi)
{
    case 1:
        WriteLine("Isti yemekler asagidakilardir");
        WriteLine("1-Dolma");
        WriteLine("2-Ev sayagi kartof");
        WriteLine("3-Saurma");
        WriteLine("4-Plov");
        Write("Isti yemek novunu secin:");
        int isti_yemek = Convert.ToInt32(Console.ReadLine());

        switch(isti_yemek)
        {
            case 1:
                WriteLine("Dolma sifaris edildi");
                break;
            case 2:
                WriteLine("Ev sayagi kartof sifaris edildi");
                break;
            case 3:
                WriteLine("Saurma sifaris edildi");
                break;
            case 4:
                WriteLine("As sifaris edildi");
                break;
        }
        break;

    case 2:
        WriteLine("Sorbalar asagidakilardir");
        WriteLine("1.Dovga");
        WriteLine("2.Eriste");
        WriteLine("3.Piti");
        WriteLine("4.Mercimek sorbasi");
        Write("Soup novu sechin:");
        int soup = Convert.ToInt32(Console.ReadLine());

        switch(soup)
        {
            case 1:
                WriteLine("Dovga sifaris edildi");
                break;
            case 2:
                WriteLine("Eriste sifaris edildi");
                break;
            case 3:
                WriteLine("Piti sifaris edildi");
                break;
            case 4:
                WriteLine("Mercimek sorbasi sifaris edildi");
                break;
        }
        break;

    case 3:
        WriteLine("Icki novleri asagidakilardir");
        WriteLine("1.Qazli su");
        WriteLine("2.Meyve siresi");
        WriteLine("3.Kola");
        WriteLine("4.Sprite");
        Write("Icki novu secin:");
        int icki = Convert.ToInt32(ReadLine());

        switch(icki)
        {
            case 1:
                WriteLine("Qazli su sifaris edildi");
                break;
            case 2:
                WriteLine("Meyve siresi sifaris edildi");
                break;
            case 3:
                WriteLine("Kola sifaris edildi");
                break;
            case 4:
                WriteLine("Sprite sifaris edildi");
                break;
        }
           break;

    case 4:
        WriteLine("Deserler asagidakilardir");
        WriteLine("1.Tiramisu");
        WriteLine("2.Cheesecake");
        WriteLine("3.Dondurma");
        WriteLine("4.Paxlava");
        Write("Desert novunu sechin:");
        int desert = Convert.ToInt32(ReadLine());

         switch(desert)
        {
            case 1:
                WriteLine("Tiramusu sifaris edildi");
                break;
            case 2:
                WriteLine("Cheesecake sifaris edildi");
                break;
            case 3:
                WriteLine("Dondurma sifaris edildi");
                break;
            case 4:
                WriteLine("Paxlava sifaris edildi");
                break;
        }
        break;

}





