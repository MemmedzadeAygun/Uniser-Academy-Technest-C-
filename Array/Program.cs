
//Tapsiriq1
//int[] students = new int[5];
//for(int i=0; i < students.Length; i++)
//{
//    Console.Write($"massivin {i+1}-ci elementi:");
//    int student = Convert.ToInt32(Console.ReadLine());
//}


//Tapsiriq2
//int sum = 0;
//int[] numbers = new int[5];
//for (int i = 0; i < numbers.Length; i++)
//{
//    Console.Write($"{i + 1}-ci element:");
//    int number = Convert.ToInt32(Console.ReadLine());
//    numbers[i] = number;
//}
//foreach(var n in numbers)
//{
//    if (n % 2 == 0)
//    {
//        sum = sum + n;
//    }
//}
//Console.WriteLine($"sum= {sum}");


//Tapsiriq3                 //0 //1 //2 //3 //4 //5
int[] numbersA = new int[5] { 4, 6, -3, 44, -5 };
int maxIndexA = numbersA[0];
for(int i=1; i<numbersA.Length; i++)
{
    if (numbersA[i] > maxIndexA)
    {
        maxIndexA = i;
    }
}
int maxElementA = numbersA[maxIndexA];
Console.WriteLine($"maxElementA= {maxElementA}");

int[] numbersB = { 9, 16, 100, 11, -20 };
int minIndexB = numbersB[0];
for(int i=1;i<numbersB.Length; i++)
{
    if (numbersB[i] < minIndexB)
    {
        minIndexB = i;
    }
}
int minElementB = numbersB[minIndexB];
Console.WriteLine($"minElementB= {minElementB}");

numbersA[maxIndexA] = numbersB[minElementB];

numbersB[minIndexB] = numbersA[maxIndexA];

Console.WriteLine($"max= {numbersA[maxElementA]}");
Console.WriteLine($"min= {numbersB[minElementB]}");


