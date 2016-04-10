//Third digit
//Description
//Write a program that reads an integer N from the console and prints true if the third digit of N is 7, or "false THIRD_DIGIT", where you should print the third digits of N.
//The counting is done from right to left, meaning 123456's third digit is 4.
//Input
//The input will always consist of exactly one line, containing the number N.
//Output
//The output should be a single line - print whether the third digit is 7, following the format described above.
//Sample tests
//Input Output
//5	false 0
//701	true
//9703	true
//877	false 8
//777877	false 8
//9999799	true

using System;

class ThirdDigit
{
    static void Main()
    {
        uint inputNumber = uint.Parse(Console.ReadLine());
        uint thirdDigit = 7;
        uint checkThirdDigit = (inputNumber % 1000) / 100;
        if (checkThirdDigit == thirdDigit)
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine("false " +  checkThirdDigit);
        }
    }
}
