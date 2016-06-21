namespace DivisibleBySevenAndThree
{
    using System.Collections.Generic;
    using System.Linq;

    class Startup
    {
        static void Main()
        {
            System.Console.WriteLine(string.Join(",",
                new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }
                .Where(x => x % 3 == 0 && x % 7 == 0)
                .ToList()));
        }
    }
}
