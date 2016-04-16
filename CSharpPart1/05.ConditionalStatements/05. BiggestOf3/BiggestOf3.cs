using System;

class BiggestOf3
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        double biggestNum;
        if (a > b && a > c)
        {
            biggestNum = a;
        }
        else
        {
            if (b > a && b > c)
            {
                biggestNum = b;
            }
            else
            {
                biggestNum = c;
            }
        }
        Console.WriteLine(biggestNum);
        // Anoter version
        //double a = double.Parse(Console.ReadLine());
        //double b = double.Parse(Console.ReadLine());
        //double c = double.Parse(Console.ReadLine());

        //if (a >= b)
        //{
        //    if (a >= c)
        //    {
        //        Console.WriteLine(a);
        //    }
        //    else
        //        Console.WriteLine(c);
        //}
        //else
        //{
        //    if (b >= c)
        //    {
        //        Console.WriteLine(b);
        //    }
        //    else
        //        Console.WriteLine(c);
        //}




        // Another version
        //int counter = 0;
        //double inputNum = 0;
        //double biggestNum = 0;

        //for (counter = 0; counter <= 2; counter++)
        //{
        //    inputNum = double.Parse(Console.ReadLine());

        //    if (inputNum <= 0)
        //    {
        //        biggestNum = inputNum;
        //    }
        //    else
        //    {
        //        if (inputNum > biggestNum)
        //        {
        //            biggestNum = inputNum;
        //        }
        //    }
        //}
        //Console.WriteLine(biggestNum);
    }
}
