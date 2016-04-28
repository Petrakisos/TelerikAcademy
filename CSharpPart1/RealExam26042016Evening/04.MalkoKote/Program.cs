using System;

class Program
{
    static void Main()
    {
        int size = int.Parse(Console.ReadLine());
        char symbol = char.Parse(Console.ReadLine());
        char space = ' ';

        for (int col = 0; col < size; col++)
        {
            Console.Write(new string(symbol, col));
            Console.WriteLine();
        }
        
    }
}
