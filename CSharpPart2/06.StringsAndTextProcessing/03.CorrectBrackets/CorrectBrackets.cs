namespace CorrectBrackets
{
    using System;

    class CorrectBrackets
    {
        static void Main()
        {
            string input = Console.ReadLine();

            char leftBracket = '(';
            char rightBracket = ')';

            int counterLeft = 0;
            int counterRight = 0;

            foreach (char bracket in input)
            {
                if (bracket == leftBracket)
                {
                    counterLeft++;
                    continue;
                }
                if (bracket == rightBracket)
                {
                    counterRight++;
                    continue;
                }
            }

            if (counterLeft == counterRight)
            {
                Console.WriteLine("Correct");
            }
            else
            {
                Console.WriteLine("Incorrect");
            }
        }
    }
}

