using System;

class CheckForAPlayCard
{
    static void Main()
    {
        string cardSign = Console.ReadLine();

        string two = "2";
        string three = "3";
        string four = "4";
        string five = "5";
        string six = "6";
        string seven = "7";
        string eight = "8";
        string nine = "9";
        string ten = "10";
        string jack = "J";
        string queen = "Q";
        string king = "K";
        string ace = "A";

        if (cardSign == two || cardSign == three || cardSign == four || cardSign == five || cardSign == six || cardSign == seven || cardSign == eight || cardSign == nine || cardSign == ten || cardSign == jack || cardSign == queen || cardSign == king || cardSign == ace)
        {
            Console.WriteLine("yes " + cardSign);
        }
        else
        {
            Console.WriteLine("no " + cardSign);
        }
    }
}
