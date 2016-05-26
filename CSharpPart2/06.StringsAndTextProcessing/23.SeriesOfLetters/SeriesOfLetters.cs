namespace SeriesOfLetters
{
    using System;
    using System.Text;

    class SeriesOfLetters
    {
        static void Main()
        {
            string input = Console.ReadLine();

            StringBuilder formatedString = new StringBuilder();

            formatedString.Append(input[0]);

            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] != input[i - 1])
                {
                    formatedString.Append(input[i]);
                }
            }

            Console.WriteLine(formatedString.ToString());
        }
    }
}
