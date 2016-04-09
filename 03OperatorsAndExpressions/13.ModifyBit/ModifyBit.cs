//Input Binary representation Modified value Output
//5 
//2 
//0	00000000 00000101	00000000 00000001	1
//0 
//9 
//1	00000000 00000000	00000010 00000000	512
//15 
//1 
//1	00000000 00001111	00000000 00001111	15
//5343 
//7 
//0	00010100 11011111	00010100 01011111	5215
//62241
//11
//0	11110011 00100001	11110011 00100001	62241

using System;

class ModifyBit
{
    static void Main()
    {
        ulong n = ulong.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());
        ulong v = ulong.Parse(Console.ReadLine());

        if (v == 1)
        {
            ulong mask = (v << p);
            ulong answer = n | mask;
            Console.WriteLine(answer);
        }
        else
        {
            ulong mask = ~((ulong)1 << p);
            ulong answer = n & mask;
            Console.WriteLine(answer);
        }
    }
}

//ulong n = ulong.Parse(Console.ReadLine()); // Number
//int p = int.Parse(Console.ReadLine()); // Position
//ulong v = ulong.Parse(Console.ReadLine()); // bit value -> 1 | 0

//if (v == 0)
//{
//    ulong mask = ~((ulong)1 << p);
//    ulong result = n % mask;
//    Console.WriteLine(result);
//}
//else
//{
//    ulong mask = ((ulong)1 << p);
//    ulong result = n | mask;
//    Console.WriteLine(result);
