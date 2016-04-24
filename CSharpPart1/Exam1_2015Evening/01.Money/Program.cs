using System;

class Program
{
    static void Main()
    {
        // read input
        int numberOfStudents = int.Parse(Console.ReadLine());
        int sheetsPerStudent = int.Parse(Console.ReadLine());
        double realmPrice = double.Parse(Console.ReadLine());

        double realmSize = 400;

        // logic
        double savedMoney = (numberOfStudents * sheetsPerStudent) / realmSize * realmPrice;
        // print result
        Console.WriteLine("{0:F3}", savedMoney);
    }
}
