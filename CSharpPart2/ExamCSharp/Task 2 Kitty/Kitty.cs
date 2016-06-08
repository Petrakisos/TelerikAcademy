namespace Kitty
{
    using System;
    using System.Linq;

    class Kitty
    {
        static void Main()
        {
            var input = Console.ReadLine().ToArray();

            var moves = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            //int kittyIndex = 0;

            int countSouls = 0;
            int countFood = 0;
            int countdeadlock = 0;
            int jumpsBeforeDeadLock = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '@')
                {
                    input[i] = ' ';
                    countSouls++;
                }
                else if (input[i] == 'x' && input[i] % 2 == 0 && countSouls > 0)
                {
                    input[i] = '@';
                }
                else if (input[i] == 'x' && input[i] % 2 != 0 && countSouls > 0)
                {
                    input[i] = '*';
                }
                else if (input[i] == '*')
                {
                    input[i] = ' ';
                    countFood++;
                }
                else if (input[i] == 'x')
                {
                    countdeadlock++;
                }
            }

            if (countdeadlock == 0)
            {
                Console.WriteLine("Coder souls collected: {0}", countSouls);
                Console.WriteLine("Food collected: {0}", countFood);
                Console.WriteLine("Deadlocks: {0}", countdeadlock);
            }
            else
            {
                Console.WriteLine("You are deadlocked, you greedy kitty!");
                Console.WriteLine("Jumps before deadlock: {0}", jumpsBeforeDeadLock);
            }
        }
    }
}