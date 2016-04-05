//Boolean Variable
//Description
//Declare a Boolean variable called isFemale and assign an appropriate value corresponding to your gender.Print it on the console.

using System;

    class BooleanVariable
{
    static void Main()
    {
        bool isFemale = false; //boolean assing value
        Console.WriteLine(isFemale); // print
///////////////////////////////////////////////////////////
        string value = "False"; //  var string
        bool isFemale2 = bool.Parse(value); // declare bool and parse value. Value can assing other values --> value = "True"
        Console.WriteLine(value);   // 1

        value = "True";
        isFemale2 = bool.Parse(value);
        Console.WriteLine(value); // 2
    }
}
