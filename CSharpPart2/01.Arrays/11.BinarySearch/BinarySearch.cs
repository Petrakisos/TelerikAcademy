using System;

class BinarySearch
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());

        int[] array = new int[N];

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        int element = int.Parse(Console.ReadLine());

        int mid = array.Length / 2 ;
        int index = mid;

        if (array[0] == element)
        {
            index = 0;
        }
        while (mid >= 1)
        {
            mid /= 2;
            if (array[index] == element)
            {
                break;
            }
            else if (array[index] < element)
            {
                index += mid;
            }
            else
            {
                index -= mid;
            }
        }
        if (array[index] == element)
        {
            Console.WriteLine("{0}", index);
        }
        else
        {
            Console.WriteLine("-1");
        }
    }
}
