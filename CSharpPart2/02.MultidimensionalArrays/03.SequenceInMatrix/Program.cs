using System;
using System.Linq;

class SequenceInMatrix
{
    static void Main()
    {
        string input = Console.ReadLine();

        int[] array = input
            .Split(' ')
            .Select(a => Convert.ToInt32(a))
            .ToArray();

        int size = array[0];
        int elements = array[1];

        string[][] matrix = new string[size][];

        for (int i = 0; i < size; i++)
        {
            matrix[i] = new string[elements];
        }

        for (int i = 0; i < size; i++)
        {
            input = null;
            input = Console.ReadLine();
            matrix[i] = input
            .Split(' ')
            .Select(a => a)
            .ToArray();
        }

        int max = 1;
        int counter = 0;

        string curent;

        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < elements; j++)
            {
                counter = 0;
                if (matrix[i][j] == "x")
                {
                    continue;
                }
                else
                {
                    counter = 1;
                    curent = matrix[i][j];
                    matrix[i][j] = "x";
                    counter = Sequence(matrix, i, j, curent, counter);

                    if (counter > max)
                        max = counter;
                }
            }
        }
        Console.WriteLine(max);
    }

    static int Sequence(string[][] matrix, int row, int col, string curent, int counter)
    {
        for (int i = row - 1; i <= row + 1; i++)
        {
            for (int j = col - 1; j <= col + 1; j++)
            {
                if (i < 0 || j < 0 || i > matrix.Length - 1 || j > matrix[row].Length - 1)
                    continue;

                else
                {
                    if (matrix[i][j] == curent)
                    {
                        counter++;
                        matrix[i][j] = "x";
                        counter = Sequence(matrix, i, j, curent, counter);
                    }
                }
            }
        }
        return counter;
    }
}