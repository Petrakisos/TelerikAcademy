using System;
using System.Numerics;
class BinaryToDecimal
{
    static void Main()
    {
        string n = Console.ReadLine(); // binary number
        BigInteger sum = 0;
        BigInteger intNum = BigInteger.Parse(n);
        ulong strn = (ulong)n.ToString().Length; //how many digits has my number
        for (ulong i = 0; i < strn; i++)
        {
            BigInteger lastDigit = intNum % 10; // get the last digit
            sum = sum + lastDigit * (ulong)(Math.Pow(2, i));
            intNum /= 10; //remove the last digit
        }
        Console.WriteLine(sum);
    }
}
