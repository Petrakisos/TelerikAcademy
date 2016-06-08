using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncreasingAbsoluteDifferencesKoce
{
    class IncreasingAbsoluteDifferences
    {
        // 1. read input
        // 2. for every sequence do the following
            // 2.1 calculate sequence of absolute differences
            // 2.2 check of the absolute differences is increasing
            // 2.3 output the result for the current sequence

        static void Main()
        {
            int sequenceCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < sequenceCount; i++)
            {
                long[] sequence = Console.ReadLine()
                    .Split(' ')
                    .Select(long.Parse)
                    .ToArray();

                bool isIncreasign = true;

                for (int j = 2; j < sequence.Length; j++)
                {
                    long lastAbsDiff = Math.Abs(sequence[j - 2] - sequence[j - 1]);
                    long currnetAbsDiff = Math.Abs(sequence[j - 1] - sequence[j]);

                    if (lastAbsDiff > currnetAbsDiff || currnetAbsDiff- lastAbsDiff > 1)
                    {
                        isIncreasign = false;
                        break;
                    }
                }

                Console.WriteLine(isIncreasign);
            }
        }
    }
}
