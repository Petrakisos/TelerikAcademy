﻿//Variable in Hexadecimal Format
//Description
//Declare an integer variable and assign it with the value 254 in hexadecimal format(0x##). 
//Use Windows Calculator to find its hexadecimal representation. Print the variable and ensure 
//that the result is 254.
using System;

class VarInHexFormat
{
    static void Main()
    {
        int decNum;
        decNum = 254;
        string hexValue = decNum.ToString("X");
        Console.WriteLine(hexValue);
    }
}