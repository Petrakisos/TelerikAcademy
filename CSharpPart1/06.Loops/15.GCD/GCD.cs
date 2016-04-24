using System;

class GCD // greatest common divisor
{
    static void Main()
    {
        // read input
        string[] splitNums = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        // logic
        int A = int.Parse(splitNums[0]);
        int B = int.Parse(splitNums[1]);

        // Euclidean algorithm
        while (A != 0 && B != 0)
        {
            if (A > B)
            {
                A %= B;
            }
            else
            {
                B %= A;
            }
        }

        //print result
        if (A == 0)
        {
            Console.WriteLine(B);
        }
        else
        {
            Console.WriteLine(A);
        }
    }
}