using System;

class IndexOfLetters
{
    static void Main()
    {
        int[] alphabet = new int[26];

        for (int i = 0; i < 26; i++)
        {
            alphabet[i] = i + 97;
        }

        string input = Console.ReadLine();

        for (int i = 0; i < input.Length; i++)
        {
            for (int j = 0; j < alphabet.Length; j++)
            {
                if (input[i] == alphabet[j])
                {
                    Console.WriteLine(j);
                }
            }
        }
    }
}
