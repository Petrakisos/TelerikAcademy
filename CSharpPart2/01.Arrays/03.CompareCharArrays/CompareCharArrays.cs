using System;

class CompareCharArrays
{
    static void Main()
    {
        string first = Console.ReadLine();
        string second = Console.ReadLine();

        int compare = first.CompareTo(second);

        if (compare == 1)
        {
            Console.WriteLine(">");
        }
        else if (compare == -1)
        {
            Console.WriteLine("<");
        }
        else if (compare == 0)
        {
            Console.WriteLine("=");
        }
    }
}
