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
        short num1; //-10000
        sbyte num2; //-115
        byte num3;  //97
        ushort num4;    //52130    
        int num5;   //4825932

        num1 = -10000;
        Console.WriteLine(num1);
        num2 = -115;
        Console.WriteLine(num2);
        num3 = 97;
        Console.WriteLine(num3);
        num4 = 52130;
        Console.WriteLine(num4);
        num5 = 4825932;
        Console.WriteLine(num5);
        num1 = 1;
        num2 = 2;
        num3 = 3;
        num4 = 4;
        num5 = 5;
        Console.WriteLine("{0} {1} {2} {3} {4}", num1, num2, num3, num4, num5);
    }
}

