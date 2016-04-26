using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        int index = 0; // reads the index of the digit
        BigInteger globalProduct = 1;
        while (true)
        {
            string line = Console.ReadLine();
            
            if (line == "END")
            {
                break;
            }

            if (index == 10)
            {
                Console.WriteLine(globalProduct);
                globalProduct = 1;
            }

            long num = long.Parse(line); // read the digit
            if (index % 2 == 1) // if the position is on odd position
            {
                long product = 1;
                while (num > 0)
                {
                    long digit = num % 10; // take the last digit in num
                    if (digit != 0)
                    {
                        product *= digit;
                    }
                    num /= 10;
                }
                globalProduct *= product;
            }
            index++;
        }
        Console.WriteLine(globalProduct);
    }
}
