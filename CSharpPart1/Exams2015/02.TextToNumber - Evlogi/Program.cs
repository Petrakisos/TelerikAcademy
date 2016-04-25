using System;

class Program
{
    static void Main()
    {
        // read input
        int module = 2001; // int.Parse(Console.ReadLine());
        string text = "Hello .NET 5! My name is Peter 8-)@"; // Console.ReadLine();

        // logic
        text = text.ToLower(); // string are emutable objects - if its only text.ToLower(); - this is new sting which dont do nothing!
        long result = 0;
        for (int i = 0; i < text.Length; i++)
        {
            char ch = text[i];

            if (ch == '@')
            {
                break;
            }
            else if ('0' <= ch && ch <= '9')
            {
                result *= (ch - '0');
            }
            else if ('a' <= ch && ch <= 'z')
            {
                result += (ch - 'a');
            }
            //else if ('A' <= ch && ch <= 'Z') // write this in case text = text.ToLower(); is missing - but .ToLower(); its slower
            //{
            //    result += (ch - 'A');
            //}
            else
            {
                result %= module;
            }
        }

        // print result
        Console.WriteLine(result);
    }
}
