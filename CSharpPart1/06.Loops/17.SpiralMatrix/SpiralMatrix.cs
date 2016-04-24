using System;

class SpiralMatrix
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());

        int[,] spiral = new int[N, N];

        int row = 0;
        int col = 0;
        int matrix = N * N;

        string direction = "right";

        for (int i = 1; i <= matrix; i++)
        {
            if (direction == "right" && (col > N - 1 || spiral[row, col] != 0))
            {
                direction = "down";
                row++;
                col--;
            }

            if (direction == "down" && (row > (N - 1) || spiral[row, col] != 0))
            {
                direction = "left";
                row--;
                col--;
            }

            if (direction == "left" && (col < 0 || spiral[row, col] != 0))
            {
                direction = "up";
                row--;
                col++;
            }

            if (direction == "up" && (row < 0 || spiral[row, col] != 0))
            {
                direction = "right";
                row++;
                col++;
            }

            spiral[row, col] = i;

            if (direction == "right")
            {
                col++;
            }

            if (direction == "down")
            {
                row++;
            }

            if (direction == "left")
            {
                col--;
            }

            if (direction == "up")
            {
                row--;
            }
        }

        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                Console.Write("{0} ", spiral[i, j]);
            }

            Console.WriteLine();
        }
    }
}
