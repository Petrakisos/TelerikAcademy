using System;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int D = int.Parse(Console.ReadLine());
        int width = 2 * N + 1;

        // loop for top
        for (int row = 0; row < N; row++)
        {
            Console.Write(new string('#', row)); // upper left
            Console.Write('\\'); // upper left

            int spaceLeft = width - row - row - 1 - 1 - D - D;
            if (spaceLeft >= 2)
            {
                Console.Write(new string(' ', D));
                Console.Write('\\');
                Console.Write(new string('.', spaceLeft -2));
                Console.Write('/');
                Console.Write(new string(' ', D));
                
            }
            else
            {
                Console.Write(new string(' ', width - row - row - 1 - 1));
            }
            Console.Write('/'); // upper right
            Console.Write(new string('#', row)); // upper right



            Console.WriteLine();
        }

        Console.WriteLine(new string('#', N) + 'X' + new string('#', N)); // middle row

        // loop for bottom
        for (int row = N - 1; row >= 0; row--)
        {
            Console.Write(new string('#', row)); // bottom left
            Console.Write('/'); // bottom left

            int spaceLeft = width - row - row - 1 - 1 - D - D;
            if (spaceLeft >= 2)
            {
                Console.Write(new string(' ', D));
                Console.Write('/');
                Console.Write(new string('.', spaceLeft - 2));
                Console.Write('\\');
                Console.Write(new string(' ', D));

            }
            else
            {
                Console.Write(new string(' ', width - row - row - 1 - 1));
            }

            Console.Write('\\'); // bottom right
            Console.Write(new string('#', row)); // bottom right

            Console.WriteLine();
        }
    }
}
