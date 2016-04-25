using System;
using System.Numerics;

class Program
{
    static void Main() // test the writen code on every step!!!!
    {
        // read input
        string strNum = Console.ReadLine();  //"123456789"; 
        int transCount = 0;

        while (strNum.Length > 1 && transCount < 10) // continue the loop while the strNum has more than one digit and if is == 1 stop the loop && if it makes less than 10 transofrmation continue the loop
        {
            BigInteger product = 1;
            while (strNum.Length > 0)
            {
                strNum = strNum.Substring(0, strNum.Length - 1); // .Substring return a part from the previous string. Working case 1. : set startindex - .Substring(10) - it will take from 10th symbol to the last. Working case 2. : startindex and lenght - .Substring(10, someString.Lenght - 1) - it will take from 10th symbol to the setted (someString.Lenght - 1) Present case : strat from 0 index till before last
                int sum = 0; // will store the present calculations
                for (int i = 0; i < strNum.Length; i += 2) // will obhodi every second int. Length count symbols not indexes 
                {
                    sum += (strNum[i] - '0'); // this collect every second symbol and because retuns char there is "- '0'"
                }

                product *= sum != 0 ? sum : 1; // if sum is different form 0 - mutilpy it with sum - and if sum is equal to zero then multipy it with 1
            }

            transCount++;
            strNum = product.ToString(); // take the product like new number
        }
        // print output
        if (transCount < 10)
        {
            Console.WriteLine(transCount);
        }

        Console.WriteLine(strNum);
    }
}
