using System;

class ReverseNumber
{
    static string ReversesDigits(string digits)
    {
        string reverse = "";

        for (int i = digits.Length - 1; i >= 0; i--)
        {
            reverse += digits[i];
        }

        return reverse;
    }
    static void Main()
    {
        string number = Console.ReadLine();

        Console.WriteLine(ReversesDigits(number));
    }
}