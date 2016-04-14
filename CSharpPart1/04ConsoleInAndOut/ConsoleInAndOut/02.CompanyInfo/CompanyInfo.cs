using System;

class CompanyInfo
{
    static void Main()
    {

        string cName = Console.ReadLine();
        string cAddress = Console.ReadLine();
        string pNumber = Console.ReadLine();
        string fNumber = Console.ReadLine();
        string wSite = Console.ReadLine();
        string mFirstName = Console.ReadLine();
        string mLastName = Console.ReadLine();
        string mAge = Console.ReadLine();
        string mPhone = Console.ReadLine();

        if (fNumber == "")
        {
            fNumber = "(no fax)";
        }
 
        Console.WriteLine("{0}\nAddress: {1}\nTel. {2}\nFax: {3}\nWeb site: {4}\nManager: {5} {6} (age: {7}, tel. {8})", cName, cAddress, pNumber, fNumber, wSite, mFirstName, mLastName, mAge, mPhone);
    }
}
