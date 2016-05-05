using System;

class MaximalSum
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());

        int[] array = new int[N];

        int currSum = 0;
        int currMax = 0;

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < array.Length; i++)
        {
            currSum += array[i];

            if (currSum < 0)
            {
                currSum = 0;
            }
            if (currSum > currMax)
            {
                currMax = currSum;
            }
        }
        Console.WriteLine(currMax);
    }
}
