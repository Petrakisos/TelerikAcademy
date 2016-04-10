//Variable in Hexadecimal Format
//Description
//Declare an integer variable and assign it with the value 254 in hexadecimal format(0x##). 
//Use Windows Calculator to find its hexadecimal representation. Print the variable and ensure 
//that the result is 254.
using System;

class VarInHexFormat
{
    static void Main()
    {
        int decNum; // declare integer
        decNum = 254;   // assing value
        string hexValue = decNum.ToString("X"); // convert int as a hex in a string var
        Console.WriteLine(hexValue); // print
        int decValue = int.Parse(hexValue, System.Globalization.NumberStyles.HexNumber); // convert hex back to demical
        Console.WriteLine(decValue); // print
    }
}