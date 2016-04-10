using System;

class Age
{
    static void Main()
    {
        string enteredDate = Console.ReadLine();
        DateTime myDate = DateTime.ParseExact(enteredDate, "MM.dd.yyyy", null);
        DateTime now = DateTime.Now;
        int Age = (int)((now - myDate).TotalDays / 365.242199);
        Console.WriteLine(Age);
        Console.WriteLine(Age + 10);
    }
}