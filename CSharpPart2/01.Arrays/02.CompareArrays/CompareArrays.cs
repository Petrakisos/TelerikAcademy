using System;
using System.Linq;

class CompareArrays
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());

        int[] firstArray = new int[N];
        int[] secondArray = new int[N];

        for (int i = 0; i < firstArray.Length; i++)
        {
            firstArray[i] = int.Parse(Console.ReadLine());

        }

        for (int i = 0; i < secondArray.Length; i++)
        {
            secondArray[i] = int.Parse(Console.ReadLine());
        }

        // one way - using Linq 100/100
        bool areEqual = firstArray.SequenceEqual(secondArray);

        Console.WriteLine(areEqual ? "Equal" : "Not equal");

        // second way 70/100
        //foreach (var storeFirstArray in firstArray)
        //{
        //    foreach (var storeSecondArray in secondArray)
        //    {
        //        if (storeSecondArray == storeFirstArray)
        //        {
        //            Console.WriteLine("Equal");
        //            break;
        //        }
        //        else
        //        {
        //            Console.WriteLine("Not equal");
        //            break;
        //        }
        //    }
        //    break;
        //}
    }
}
