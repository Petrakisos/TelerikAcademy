//Print the ASCII Table
//Find online more information about ASCII(American Standard Code for Information Interchange) 
//and write a program that prints the visible characters of the ASCII table on the console(characters 
//from 33 to 126 including).
//Note: You may need to use for-loops(learn in Internet how).
//Output
//The 94 characters on single line
// ASCII is a 7bit code.

using System;

class PrintTheAsciiTable
{
    static void Main()
    {
        for (byte counterAsciiChar = 33; counterAsciiChar < 127; counterAsciiChar++)
        {
            Console.Write("{0}", (char)counterAsciiChar);
        }
    }
}
