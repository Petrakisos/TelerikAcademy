using System;

class EncodingSum
{
    static void Main()
    {
        // read input
        int number = int.Parse(Console.ReadLine());
        string text = Console.ReadLine();

        long result = 0;
        text = text.ToLower(); // create a new string 
        // logic
        for (int i = 0; i < text.Length; i++)
        {
            char ch = text[i];

            if (ch == '@')
            {
                break;
            }
            if (ch >= '0' && ch <= '9')
            {
                result *= ch - '0';
            }
            else if (ch >= 'a' && ch <= 'z')
            {
                result += ch - 'a';
            }
            else
            {
                result %= number;
            }
        }
        // print result
        Console.WriteLine(result);
    }
}
