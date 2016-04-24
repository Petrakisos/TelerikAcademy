using System;

class TextToNumber
{
    static void Main()
    {
        // read input
        int number = int.Parse(Console.ReadLine());
        string text = Console.ReadLine();

        int result = 0;

        //logic
        for (int i = 0; i < text.Length; i++)
        {
            char ch = text[i];

            if (ch == '@')
            {
                break;
            }
            else if (char.IsDigit(ch))
            {
                result *= ch - 48;
            }
            else if (char.IsLetter(ch) && char.IsUpper(ch))
            {
                result += ch - 65;
            }
            else if (char.IsLetter(ch) && char.IsLower(ch))
            {
                result += ch - 97;
            }
            else
            {
                result %= number;
            }
        }

        //print result
        Console.WriteLine(result);
    }
}
