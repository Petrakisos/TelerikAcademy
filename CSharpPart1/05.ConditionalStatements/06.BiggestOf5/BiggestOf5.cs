using System;

class BiggestOf5
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        double d = double.Parse(Console.ReadLine());
        double e = double.Parse(Console.ReadLine());

        double biggestNum;
        if (a > b && a > c && a > d && a > e)
        {
            biggestNum = a;
        }
        else
        {
            if (b > a && b > c && b > d && b > e)
            {
                biggestNum = b;
            }
            else
            {
                if (c > a && c > b && c > d && c > e)
                {
                    biggestNum = c;
                }
                else
                {
                    if (d > a && d > b && d > c && d > e)
                    {
                        biggestNum = d;
                    }
                    else
                    {
                        biggestNum = e;
                    }
                }
            }
        }
        Console.WriteLine(biggestNum);

        //int counter = 0;
        //double inputNum = 0;
        //double biggestNum = 0;

        //for (counter = 0; counter <= 4; counter++)
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
