using System;

class Program
{
    static void Main()
    {
        int salt = int.Parse(Console.ReadLine());
        int position = 0; // first readed digit - ot counts is on odd or even position
        int newCode = 0;
        int isLetter = 1000;
        int isDigit = 500;

        while (true)
        {
            int charCode = Console.Read(); // reads input like code
            char ch = (char)charCode; // reads input like symbol

            if (ch == '@')
            {
                break;
            }


 
            if (char.IsLetter(ch))
            {
                newCode = (charCode * salt) + isLetter;
            }
            else if (char.IsDigit(ch))
            {
                newCode = (charCode + salt) + isDigit;
            }
            else
            {
                newCode = charCode - salt;
            }

            if (position % 2 == 0) // if position is even
            {
                Console.WriteLine("{0:F2}", newCode / 100.0);
            }
            else
            {
                Console.WriteLine(newCode * 100);
            }
            position++; // after read the first digit read the next one
        }
    }
}
