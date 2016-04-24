using System;

class Program
{
    static void Main()
    {
        // read input
        int numOfStudents = int.Parse(Console.ReadLine());
        int paperPerStudent = int.Parse(Console.ReadLine());
        decimal realmPrice = decimal.Parse(Console.ReadLine());

        decimal realmSize = 500.00M;

        // logic
        decimal savedMoney = ((numOfStudents * paperPerStudent) / realmSize) * realmPrice;

        // print result
        Console.WriteLine("{0:F2}", savedMoney);

    }
}
