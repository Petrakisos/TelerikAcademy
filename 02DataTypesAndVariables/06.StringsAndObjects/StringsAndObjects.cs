//Strings and Objects
//Description
//Declare two string variables and assign them with Hello and World.Declare an object variable and assign it with 
//the concatenation of the first two variables(mind adding an interval between). Declare a third string variable 
//and initialize it with the value of the object variable(you should perform type casting).

using System;

class StringsAndObjects
{
    static void Main()
    {
        string hello = "Hello"; // declare string variable
        string world = "World"; // declare string varuable
        object helloworld = hello + " " + world;    // declare object variable and assing concatenation of the declarated variables
        string casthelloworld = (string)helloworld; // declare string variable which cast object variable
        Console.WriteLine(casthelloworld); // print casted object
    }
}
