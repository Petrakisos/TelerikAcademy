using System;

class FillTheMatrix
{
    static void Main()
    {

        int N = int.Parse(Console.ReadLine());

        char charInput = char.Parse(Console.ReadLine());

        int[,] matrix = new int[N, N];

        if (charInput == 'a')
        {
            matrix = ifCharInputA(matrix);
            print(matrix);
        }

        if (charInput == 'b')
        {
            matrix = ifCharInputB(matrix);
            print(matrix);
        }

        if (charInput == 'c')
        {
            matrix = ifCharInputC(matrix);
            print(matrix);
        }

        if (charInput == 'd')
        {
            matrix = ifCharInputD(matrix);
            print(matrix);
        }

    }

    public static int[,] ifCharInputA(int[,] fill)
    {
        int counter = 1;

        for (int col = 0; col < fill.GetLength(0); col++)
        {
            for (int row = 0; row < fill.GetLength(1); row++)
            {
                fill[col, row] = counter++;
            }
        }

        return fill;
    }

    public static int[,] ifCharInputB(int[,] fill)
    {
        int counter = 1;

        for (int col = 0; col < fill.GetLength(0); col++)
        {
            if ((col & 1) == 0)
            {
                for (int row = 0; row < fill.GetLength(1); row++)
                {
                    fill[col, row] = counter++;
                }
            }
            else
            {
                for (int row = fill.GetLength(1) - 1; row >= 0; row--)
                {
                    fill[col, row] = counter++;
                }
            }

        }
        return fill;
    }

    public static int[,] ifCharInputC(int[,] fill)
    {
        //TODO
        return fill;
    }

    public static int[,] ifCharInputD(int[,] fill)
    {
        // TODO
        return fill;
    }

    public static void print(int[,] print)
    {
        for (int row = 0; row < print.GetLength(1); row++)
        {
            for (int col = 0; col < print.GetLength(0); col++)
            {
                Console.Write(print[col, row]);

                if (col != print.GetLength(0) - 1)
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
        return;
    }
}