namespace ParseTags
{
    using System;
    using System.Linq;
    using System.Text;

    class ParseTags
    {
        static void Main()
        {
            string[] input = Console
                        .ReadLine()
                        .Split(new char[] { '<', '>' })
                        .ToArray();

            string firstTag = "upcase";
            string secondTag = "/upcase";

            StringBuilder output = new StringBuilder();
            bool upperCase = false;

            foreach (var letter in input)
            {
                if (letter == firstTag)
                {
                    upperCase = true;
                    continue;
                }
                if (letter == secondTag)
                {
                    upperCase = false;
                    continue;
                }
                if (upperCase)
                {
                    output.Append(letter.ToUpper());
                }
                else
                {
                    output.Append(letter);
                }
            }

            Console.WriteLine(output);
        }
    }
}
