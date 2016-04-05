//Float or Double
//Description
//Which of the following values can be assigned to a variable of type float and which to a variable 
//of type double: 34.567839023, 12.345, 8923.1234857, 3456.091? Write a program to assign the numbers 
//in variables and print them to ensure no precision is lost.
using System;

class FloatOrDouble
{
    static void Main()
    {
        float num1; //12.345
        float num2; //3456.091
        double num3;    //8923.1234857
        double num4;    //34.567839023

        num1 = 12.345f; //give value for varialbe
        Console.WriteLine(num1);
        num2 = 3456.091f;   //give value for varialbe
        Console.WriteLine(num2);
        num3 = 8923.1234857f;   //give value for varialbe
        Console.WriteLine(num3);
        num4 = 34.567839023;    //give value for varialbe
        Console.WriteLine(num4);
        num1 = 1.111111f; // changed varialbe value
        num2 = 2.222222f;   // changed varialbe value
        num3 = 3.33333333333333;    // changed varialbe value
        num4 = 4.44444444444444;    // changed varialbe value
        Console.WriteLine("{0} {1} {2} {3}" , num1, num2, num3, num4);
    }
}
