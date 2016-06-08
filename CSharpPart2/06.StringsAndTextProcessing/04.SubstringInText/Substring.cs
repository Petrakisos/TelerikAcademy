namespace SubstringInText
{
    using System;

    class Substring
    {
        static void Main()
        {
            string pattern = Console.ReadLine().ToLower();
            string text = Console.ReadLine().ToLower();

            int index = text.IndexOf(pattern);
            int counter = 0;

            while (index >= 0)
            {
                counter++;
                index = text.IndexOf(pattern, ++index);
            }

            Console.WriteLine(counter);
        }
    }
}
