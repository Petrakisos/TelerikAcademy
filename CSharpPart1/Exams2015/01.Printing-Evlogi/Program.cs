using System;

class Program
{
    static void Main()
    {
        // read input
        int numSudent = int.Parse(Console.ReadLine());
        int sheetsPerStudent = int.Parse(Console.ReadLine());
        double price = double.Parse(Console.ReadLine());
        double  realm = 500;

        // logic
        double result = ((numSudent * sheetsPerStudent) / realm) * price;

        // print result
        Console.WriteLine("{0:F2}", result);
    }
}
