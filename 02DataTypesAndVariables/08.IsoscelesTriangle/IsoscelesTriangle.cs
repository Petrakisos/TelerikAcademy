using System;

class IsoscelesTriangle
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
/////////////////////////////////////////////////////////////////////////////////////////// 1
        char copyRight = '©';
        Console.WriteLine("{0,4}\n{0,3}{0,2}\n{0,2}{0,4}\n{0}{0,2}{0,2}{0,2}", copyRight);
////////////////////////////////////////////////////////////////////////////////////////// 2
        char COPYRIGHT = '©';
        Console.WriteLine(new String(' ', 5) + COPYRIGHT);
        Console.WriteLine(new String(' ', 4) + COPYRIGHT + new String(' ', 1) + COPYRIGHT);
        Console.WriteLine(new String(' ', 3) + COPYRIGHT + new String(' ', 3) + COPYRIGHT);
        Console.WriteLine(new String(' ', 2) + COPYRIGHT + new String(' ', 5) + COPYRIGHT);
        Console.WriteLine(new String(' ', 1) + COPYRIGHT + new String(' ', 7) + COPYRIGHT);
        Console.WriteLine(" " + new String(COPYRIGHT, 9));
////////////////////////////////////////////////////////////////////////////////////////// 3
        int n = 7;

        for (int i = 1; i <= n; i += 2)
        {
            for (int k = (n - i) / 2; k >= 0; k--)
                Console.Write(" ");
            for (int j = 1; j <= i; j++)
                Console.Write("©");
            Console.WriteLine();
        }
    }
}
