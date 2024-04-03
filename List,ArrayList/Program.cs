
#region
//ListOperations operations1 = new ListOperations();
////Console.WriteLine(operations1.FindMax(new List<int> { 1, 6, 2, 3, 1, 7, 8 }));

//List<int> numList = new List<int>()
//{
//    1,4,5,67,8,9,2,4
//};

//Console.WriteLine("Original List");
//operations1.PrintList(numList);

//Console.WriteLine("Even List");
//List<int> secondlist = operations1.GenerateEvenList(numList);
//operations1.PrintList(secondlist);

//class ListOperations
//{
//    public int FindMax(List<int> numbers)
//    {

//        if (numbers.Count > 0)
//        {
//            int max = numbers[0];
//            for(int i = 0; i < numbers.Count; i++)
//            {
//                if (numbers[i] > max)
//                {
//                    max = numbers[i];
//                }         
//            }        
//            return max;
//        }
//        else
//        {
//            throw new ArgumentException("Error");
//        }
//    }

//    public List<int> GenerateEvenList(List<int> numbers)
//    {
//        List<int> result = new List<int>();
//        foreach(int i in numbers)
//        {
//            if (i % 2 == 0)
//            {
//                result.Add(i);
//            }
//        }

//        return result;
//    }

//    public void PrintList(List<int> numbers)
//    {
//        foreach(int number in numbers)
//        {
//            Console.WriteLine(number);
//        }
//    }
//}
#endregion   


//using System.Collections;

//ArrayListOperations opr1 = new ArrayListOperations();
//ArrayList list1 = new ArrayList() { 1, 2, 4, "asjw", 'r',7,8,9, 'k',"gsag",1,2,4 };
//ArrayListOperations secondList = opr1.DublicateRemove(listOne);
//class ArrayListOperations
//{
//    public ArrayList DublicateRemove(ArrayList listOne)
//    {
//        ArrayList result = new ArrayList();
//        foreach(var item in listOne)
//        {
//            if (!result.Contains(item))
//            {
//                result.Add(item);
//            }        
//        }
//        return result;
//    }
//}