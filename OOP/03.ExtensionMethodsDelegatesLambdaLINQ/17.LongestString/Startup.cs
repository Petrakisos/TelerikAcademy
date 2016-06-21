namespace LongestString
{
    using System.Collections.Generic;
    using System.Linq;

    class Startup
    {
        static void Main()
        {
            List<string> listOfStrings = new List<string>() { "1", "12", "123", "1234" };
            string stringWithLongestLenght = listOfStrings.FirstOrDefault(x => x.Length == listOfStrings.Max(y => y.Length));
            System.Console.WriteLine(stringWithLongestLenght);
        }
    }
}
