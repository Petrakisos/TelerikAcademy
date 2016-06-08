namespace ExtractSentences
{
    using System;
    using System.Text.RegularExpressions;

    class ExtractSentences
    {
        static void Main()
        {
            string pattern = Console.ReadLine();

            string[] text = Console.ReadLine().Split('.');

            for (int i = 0; i < text.Length; i++)
            {
                if (Regex.Matches(text[i], @"\b" + pattern + @"\b").Count > 0)
                {
                    Console.Write(text[i] + ".".Trim());
                }
            }

            Console.WriteLine();
        }
    }
}
