namespace UnicodeCharacters
{
    using System;

    class UnicodeCharacters
    {
        static string GetEscapeSequence(char c)
        {
            return "\\u" + ((int)c).ToString("X4");
        }

        static void Main()
        {
            string input = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {
                Console.Write(GetEscapeSequence(input[i]));
            }
        }
    }
}
