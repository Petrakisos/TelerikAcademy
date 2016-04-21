using System;

class PrintADeck
{
    static void Main()
    {
        string cardSign = Console.ReadLine();

        string[] deck = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };

        int character = 0;

        switch (cardSign)
        {
            case "J": character = 11; break;
            case "Q": character = 12; break;
            case "K": character = 13; break;
            case "A": character = 14; break;
            default: character = int.Parse(cardSign); break;
        }

        for (int i = 0; i <= character - 2; i++)
        {
            Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", deck[i]);
        }
    }
}
