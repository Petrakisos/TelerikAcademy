using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        // read input
        double numOfTrees = double.Parse(Console.ReadLine());
        double numOfBranches = double.Parse(Console.ReadLine());
        double numOfSquirrels = double.Parse(Console.ReadLine());
        double avgNumTails = double.Parse(Console.ReadLine());


        //decimal isOdd = 7;
        // int isEven = 376439;
        double tails = numOfTrees * numOfBranches * numOfSquirrels * avgNumTails;

        //    Console.WriteLine(tails);

        if (tails % 2 == 0)
        {
            tails *= 376439;
            Console.WriteLine("{0:F3}", tails);
        }
        else
        {
            tails /= 7;
            Console.WriteLine("{0:F3}", tails);
        }

    }
}