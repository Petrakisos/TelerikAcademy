namespace ReplaceTags
{
    using System;
    using System.Text.RegularExpressions;

    class ReplaceTags
    {
        static void Main()
        {
            string pattern = @"<\s*a\s[^>]*?\bhref\s*=\s*('[^']*'|""[^""]*""|\S*)[^>]*>((.|\s)*?)<\s*/a\s*>";

            string replace = "[$2]($1)";

            string result = Regex.Replace(Console.ReadLine(), pattern, replace);

            Console.WriteLine(result.Replace("(\"", "(").Replace("\")", ")"));
        }
    }
}
