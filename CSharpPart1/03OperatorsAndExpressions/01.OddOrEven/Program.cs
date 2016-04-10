using System;

class Program
{
    static void Main()
    {
        int userInput = int.Parse(Console.ReadLine());

        if (userInput % 2 == 0)
        {
            Console.WriteLine("even" + " " + userInput);
        }
        else
        {
            Console.WriteLine("odd" + " " + userInput);
        }
    }
}
