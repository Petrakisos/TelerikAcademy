namespace IEnumerableExtensions
{
    using IEnumerableExtension;

    class Startup
    {
        static void Main()
        {
            var array = new int[] { 1, 2, 5, 8 };

            System.Console.WriteLine(array.Average());
        }
    }
}
