using System;

class LeapYear
{
    private static void CheckIsLeapYear(int year)
    {
        if (DateTime.IsLeapYear(year))
        {
            Console.WriteLine("Leap");
        }
        else
        {
            Console.WriteLine("Common");
        }
    }

    static void Main()
    {
        int year = int.Parse(Console.ReadLine());
        CheckIsLeapYear(year);
    }


}
