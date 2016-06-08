using System;

class NumberAsArray
{
    static void Main()
    {
        Console.ReadLine();

        string firstArray = Console.ReadLine();
        string secondArray = Console.ReadLine();

        int sum = AddNumber(firstArray) + AddNumber(secondArray);

        Console.WriteLine(AddString(sum));

    }

    public static int AddNumber(string input)
    {
        string sum = "";

        input = input.Replace(" ", "");

        for (int digit = input.Length - 1;
                 digit >= 0;
                 digit--)
        {
            sum += input[digit];
        }

        return int.Parse(sum);
    }

    public static string AddString(int number)
    {
        string output = "";

        string numToString = number.ToString();

        for (int digit = numToString.Length - 1;
                 digit >= 0;
                 digit--)
        {
            output += numToString[digit];
            output += " ";
        }

        output = output.TrimEnd(' ');

        return output;
    }
}