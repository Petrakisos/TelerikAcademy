//Exchange Variable Values
//Description
//Declare two integer variables a and b and assign them with 5 and 10 and after that exchange their values
//by using some programming logic.Print the variable values before and after the exchange.

using System;
class ExchangeVariableValues
{
    static void Main()
    {
        int a;
        int b;
        a = 5;
        b = 10;
        Console.WriteLine("{0} {1}", a, b);
        a = a + b;
        b = a - b;
        b = a + b;
        Console.WriteLine("{0} {1}", a, b);
    }
}
