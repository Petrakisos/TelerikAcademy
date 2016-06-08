namespace SquareRoot
{
    using System;

    class SquareRoot
    {
        static void Main()
        {
            try
            {
                double input = double.Parse(Console.ReadLine());

                if (input < 0)
                {
                    throw new FormatException("Invalid number");
                }

                double root = (Math.Sqrt(input));

                Console.WriteLine("{0:F3}", root);
            }
            catch (FormatException)
            {

                Console.WriteLine("Invalid number");
            }
            finally
            {
                Console.WriteLine("Good bye");
            }
        }
    }
}
