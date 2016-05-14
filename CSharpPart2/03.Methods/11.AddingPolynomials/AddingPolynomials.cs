using System;
using System.Collections.Generic;
using System.Linq;

class AddingPolynomials
{
    static void Main()
    {
        Console.ReadLine();

        int[] firstArrayCoeff = Input();

        int[] secondArrayCoeff = Input();

        int[] sum = AddingPolinoms(firstArrayCoeff, secondArrayCoeff);

        List<int> list = AddInList(sum);

        Console.WriteLine(string.Join(" ", list));
    }

    static int[] Input()
    {
        return Console.ReadLine()
                    .Split(' ')
                    .Select(int.Parse)
                    .ToArray();
    }

    public static int[] AddingPolinoms(int[] firstPolynom, int[] secondPolynom)
    {

        if (firstPolynom.Length < secondPolynom.Length)
        {
            return AddingPolinoms(secondPolynom, firstPolynom);
        }

        int[] sumOfPolynomials = new int[firstPolynom.Length];

        for (int i = 0; i < secondPolynom.Length; i++)
        {
            sumOfPolynomials[i] = firstPolynom[i] + secondPolynom[i];
        }

        for (int i = secondPolynom.Length; i < firstPolynom.Length; i++)
        {
            sumOfPolynomials[i] = firstPolynom[i];
        }

        return sumOfPolynomials;
    }

    private static List<int> AddInList(int[] sum)
    {
        List<int> list = new List<int>();

        for (int i = 0; i < sum.Length; i++)
        {
            list.Add(sum[i]);
        }

        return list;
    }
}