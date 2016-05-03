using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.AllocateArray
{
    class AllocateArray
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());

            int multiply = 5;

            int[] array = new int[N]; // create array with N size

            for (int i = 0; i < array.Length; i++) // loop array size
            {
                array[i] = i * multiply; // take each index from 0 to N and multiply it by 5
                Console.WriteLine(array[i]); // write line result for each index
            }
        }
    }
}
