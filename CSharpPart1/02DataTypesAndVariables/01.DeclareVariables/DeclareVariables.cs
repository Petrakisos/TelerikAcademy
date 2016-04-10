//Declare Variables
//Description
//Declare five variables choosing for each of them the most appropriate of the types byte, sbyte, short, ushort,
//int, uint, long, ulong to represent the following values: 52130, -115, 4825932, 97, -10000. Choose a large 
//enough type for each number to ensure it will fit in it.Try to compile the code.
//You do not have to submit anything for this problem
using System;

class DeclareVarialbes
{
    static void Main()
    {
        short num1; //-10000 Declarate varible
        sbyte num2; //-115 Declarate varible
        byte num3;  //97 Declarate varible
        ushort num4;    //52130 Declarate varible
        int num5;   //4825932 Declarate varible

        num1 = -10000; // assing value
        Console.WriteLine(num1);
        num2 = -115;    // assing value
        Console.WriteLine(num2);
        num3 = 97;  // assing value
        Console.WriteLine(num3);
        num4 = 52130;   // assing value
        Console.WriteLine(num4);
        num5 = 4825932; // assing value
        Console.WriteLine(num5);
        num1 = 1;   // assing new value
        num2 = 2;   // assing new value
        num3 = 3;   // assing new value
        num4 = 4;   // assing new value
        num5 = 5;   // assing new value
        Console.WriteLine("{0} {1} {2} {3} {4}", num1, num2, num3, num4, num5);
    }
}

