namespace CryptoCS
{
    using System;
    using System.Numerics;

    class Crypto
    {
        static BigInteger N26toDec(string n)
        {
            BigInteger result = 0;

            byte NumeralBase = 26;

            foreach (char letter in n)
            {
                result = (letter - 'a') + result * NumeralBase;
            }

            return result;
        }

        static BigInteger SeventoDec(string number)
        {
            BigInteger result = 0;

            byte NumeralBase = 7;

            foreach (char letter in number)
            {
                result = (letter - '0') + result * NumeralBase;
            }

            return result;
        }

        static string DecToNine(BigInteger dec)
        {
            string result = string.Empty;

            byte NumeralBase = 9;

            do
            {
                char letter = (char)('0' + (dec % NumeralBase));
                result = letter + result;
                dec /= NumeralBase;

            } while (dec > 0);

            return result;
        }

        static void Main(string[] args)
        {
            string input26 = Console.ReadLine();

            string subOrArr = Console.ReadLine();

            string input7 = Console.ReadLine();


            BigInteger converted26toDec = N26toDec(input26);
            BigInteger converted7toDec = SeventoDec(input7);

            if (subOrArr == "+")
            {
                BigInteger sum = converted26toDec + converted7toDec;
                Console.WriteLine(DecToNine(sum));
            }
            else if (subOrArr == "-")
            {
                BigInteger sum = converted26toDec - converted7toDec;
                Console.WriteLine(DecToNine(sum));
            }

            //Console.WriteLine(converted26toDec);
            //Console.WriteLine(converted7toDec);
        }
    }
}
