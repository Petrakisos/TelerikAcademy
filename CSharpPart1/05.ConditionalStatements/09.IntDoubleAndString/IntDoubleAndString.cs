using System;
class IntDoubleAndString
{
    static void Main()
    {
        string inputString = Console.ReadLine();
        string value = Console.ReadLine();

        switch (inputString)
        {
            case "integer": Console.WriteLine(int.Parse(value) + 1); break;
            case "real": Console.WriteLine("{0:F2}", double.Parse(value) + 1); break;
            case "text": Console.WriteLine(value + "*"); break;

            default:
                Console.WriteLine("First line: Please specify the type of value: integer, real, text\r\nSecond line: Please enter a value of the specified type");
                break;
        }
    }
}
