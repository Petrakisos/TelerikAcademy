using System;
using System.Linq;

class LargestAreaInMatrix
{
    static void Main()
    {
        string input = Console.ReadLine();

        short[] result = input
            .Split(' ')
            .Select(a => Convert.ToInt16(a))
            .ToArray();

        int size = result[0];
        int elements = result[1];

        int?[][] matrix = new int?[size][];

        for (int i = 0; i < size; i++)
            matrix[i] = new int?[elements];

        for (int i = 0; i < size; i++)
        {
            input = null;
            input = Console.ReadLine();

            result = input
            .Split(' ')
            .Select(a => Convert.ToInt16(a))
            .ToArray();

            input = null;

            for (int j = 0; j < elements; j++)
                matrix[i][j] = result[j];
        }

        int max = 1;
        int counter = 0;
        int? curent;

        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < elements; j++)
            {
                counter = 0;
                if (matrix[i][j] == null)
                    continue;

                else
                {
                    counter = 1;
                    curent = matrix[i][j];
                    matrix[i][j] = null;
                    counter = Sequence(matrix, i, j, ref curent, ref counter);

                    if (counter > max)
                        max = counter;
                }
            }
        }
        Console.WriteLine(max);
    }

    static int Sequence(int?[][] matrix, int row, int col, ref int? curent, ref int counter)
    {
        if (col > 0 && matrix[row][col - 1] == curent)
        {
            counter++;
            matrix[row][col - 1] = null;
            counter = Sequence(matrix, row, col - 1, ref curent, ref counter);
        }

        if (row < matrix.Length - 1 && matrix[row + 1][col] == curent)
        {
            counter++;
            matrix[row + 1][col] = null;
            counter = Sequence(matrix, row + 1, col, ref curent, ref counter);
        }

        if (col < matrix[row].Length - 1 && matrix[row][col + 1] == curent)
        {
            counter++;
            matrix[row][col + 1] = null;
            counter = Sequence(matrix, row, col + 1, ref curent, ref counter);
        }

        if (row > 0 && matrix[row - 1][col] == curent)
        {
            counter++;
            matrix[row - 1][col] = null;
            counter = Sequence(matrix, row - 1, col, ref curent, ref counter);
        }
        return counter;
    }
}
