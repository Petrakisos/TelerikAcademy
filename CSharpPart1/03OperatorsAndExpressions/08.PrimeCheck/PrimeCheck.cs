using System;

class PrimeCheck
{
    static void Main()
    {
        int inputNumber = int.Parse(Console.ReadLine());
        bool isPrime = true;
        int count = 1;
        while (count <= Math.Sqrt(inputNumber))
        {
            if (inputNumber % count == 0 && count > 1)
            {
                isPrime = false;
            }
            count++;
        }
        if (inputNumber < 2)
        {
            isPrime = false;
        }
        if (isPrime == true)
        {
            Console.WriteLine("true");
        }
        if (isPrime == false)
        {
            Console.WriteLine("false");
        }
    }
}
