//Input Output
//3	false 3
//0	true 0
//5	false 5
//7	false 7
//35	true 35
//140	true 140

using System;

class DivideBy7And5
{
    static void Main()
    {
        int userInpunt = int.Parse(Console.ReadLine());

        if ((userInpunt % 7 == 0) && (userInpunt % 5 == 0))
        {
            Console.WriteLine("true" + " " + userInpunt);
        }
        else
        {
            Console.WriteLine("false" + " " + userInpunt);
        }
    }
}
