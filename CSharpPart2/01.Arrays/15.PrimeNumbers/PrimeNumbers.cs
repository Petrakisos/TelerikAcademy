using System;

class PrimeNumbers
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());

        bool[] array = new bool[N + 1];

        for (int i = 2; i < Math.Sqrt(array.Length); i++)
        {
            if (array[i] == false)
            {
                for (int j = i * i; j < array.Length; j += i)
                {
                    array[j] = true;
                }
            }
        }

        for (int i = array.Length - 1; i >= 0; i--)
        {
            if (!array[i])
            {
                Console.WriteLine(i);
                break;
            }
        }
    }
}
