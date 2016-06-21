namespace StringBuilderSubstring
{
    using System.Text;
    using StringBuilder.Extension;

    class Startup
    {
        static void Main()
        {
            var forSubstring = new StringBuilder();

            forSubstring.Append("Show only name");

            System.Console.WriteLine(forSubstring.Substring(10, 4));
        }
    }
}
