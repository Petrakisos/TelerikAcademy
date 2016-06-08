using System;
using System.Linq;

class MaximalSum
{
    static void Main()
    {
        string input = Console.ReadLine();

        int[] result = input
            .Split(' ')
            .Select(a => Convert.ToInt32(a))
            .ToArray();

        int size = result[0];
        int elements = result[1];

        int[][] matrix = new int[size][];

        for (int i = 0; i < size; i++)
            matrix[i] = new int[elements];

        for (int i = 0; i < size; i++)
        {
            input = null;
            input = Console.ReadLine();
            matrix[i] = input
            .Split(' ')
            .Select(a => Convert.ToInt32(a))
            .ToArray();
        }

        int max = int.MinValue;

        for (int i = 0; i < size - 2; i++)
        {
            for (int j = 0; j < elements - 2; j++)
            {
                int curentSum = sum(matrix, i, j);

                if (curentSum > max)
                {
                    max = curentSum;
                }
            }
        }
        Console.WriteLine(max);
    }

    static int sum(int[][] matrix, int row, int col, int rows = 3, int cols = 3)
    {
        int sum = 0;

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                sum += matrix[row + i][col + j];
            }
        }
        return sum;
    }
}