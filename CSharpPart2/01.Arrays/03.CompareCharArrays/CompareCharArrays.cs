using System;

class CompareCharArrays
{
    static void Main()
    {
        string firstString = Console.ReadLine();
        string secondString = Console.ReadLine();

        char[] firstChar = firstString.ToCharArray();
        char[] secondChar = secondString.ToCharArray();

        if (firstChar.Length > secondChar.Length)
        {
            Console.WriteLine('>');
        }
        else if (firstChar.Length < secondChar.Length)
        {
            Console.WriteLine('<');
        }
        else
        {
            Console.WriteLine('=');
        }
    }
}
