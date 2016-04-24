using System;

static class Program
{
    static void Main()
    {
        // read input
        int studentsNum = int.Parse(Console.ReadLine());
        int paperPerStudent = int.Parse(Console.ReadLine());
        double realmPrice = int.Parse(Console.ReadLine());

        int realmSize = 500;

        //logic
        double savedMoney = (((studentsNum * paperPerStudent) / realmSize) * realmPrice);

        // print result
        Console.WriteLine(savedMoney);

    }
}

