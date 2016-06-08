namespace ReverseString
{
    using System;
    using System.Text;

    class StringReverse
    {
        static void Main()
        {
            string input = Console.ReadLine();

            StringBuilder Reversed = new StringBuilder(input.Length);

            foreach (char letter in input)
            {
                Reversed.Insert(0, letter);
            }

            Console.WriteLine(Reversed);

        }
    }
}