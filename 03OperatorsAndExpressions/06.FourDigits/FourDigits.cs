//Description
//Write a program that takes as input a four-digit number in format abcd(e.g. 2011) and performs the following:
//Calculates the sum of the digits(in our example 2 + 0 + 1 + 1 = 4) and prints it on the console.
//Prints on the console the number in reversed order: dcba (in our example 1102) and prints the reversed number.
//Puts the last digit in the first position: dabc(in our example 1201) and prints the result.
//Exchanges the second and the third digits: acbd (in our example 2101) and prints the result.
//Constraints
//The number will always be a valid positive four-digit integer.
//The number will always start with a digit other than 0.
//Time limit: 0.1s
//Memory limit: 16MB
//Sample tests
//Input Output
//2011	 
//4
//1102
//1201
//2101

//3333	
//12
//3333
//3333
//3333

//9876	
//30
//6789
//6987
//9786

//1230	
//6
//0321
//0123
//1320
using System;

class FourDigits
{
    static void Main()
    {
        uint inputNumber = uint.Parse(Console.ReadLine());

        uint firstDigit = (inputNumber % 10000) / 1000;
        uint secondDigit = (inputNumber % 1000) / 100;
        uint thirdDigit = (inputNumber % 100) / 10;
        uint fourDigit = (inputNumber % 10) / 1;

        Console.WriteLine(firstDigit + secondDigit + thirdDigit + fourDigit);
        Console.WriteLine("{3}{2}{1}{0}", firstDigit, secondDigit, thirdDigit, fourDigit);
        Console.WriteLine("{3}{0}{1}{2}", firstDigit, secondDigit, thirdDigit, fourDigit);
        Console.WriteLine("{0}{2}{1}{3}", firstDigit, secondDigit, thirdDigit, fourDigit);
    }
}
