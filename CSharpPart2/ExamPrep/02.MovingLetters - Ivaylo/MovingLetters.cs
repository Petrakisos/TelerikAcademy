using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovingLettersIvaylo
{
    class MovingLetters
    {
        static StringBuilder ExtractLetters(string[] words)
        {
            StringBuilder result = new StringBuilder();
            int maxWordLenght = 0;

            for (int i = 0; i < words.Length; i++)
            {
                string currentWord = words[i];
                if (maxWordLenght < currentWord.Length)
                {
                    maxWordLenght = currentWord.Length;
                }
            }

            for (int i = 0; i < maxWordLenght; i++)
            {
                for (int j = 0; j < words.Length; j++)
                {
                    string currentWord = words[j];

                    if (i < currentWord.Length)
                    {
                        int lastLetter = - 1 - i;
                        result.Append(currentWord[lastLetter]);
                    }
                }
            }

            return result;
        }

        static string MoveLetters(StringBuilder stragePieceOfWords)
        {
            for (int i = 0; i < stragePieceOfWords.Length; i++)
            {
                char currentSymbol = stragePieceOfWords[i];
                int transition = char.ToLower(currentSymbol) - 'a' + 1;

                int nextPosition = (i + transition) % stragePieceOfWords.Length;
                stragePieceOfWords.Remove(i, 1);
                stragePieceOfWords.Insert(nextPosition, currentSymbol);
            }

            return stragePieceOfWords.ToString();
        }

        static void Main()
        {
            string[] words = Console.ReadLine().Split(' ');

            StringBuilder strangeCombinationOfLetters = ExtractLetters(words);
            string finalResult = MoveLetters(strangeCombinationOfLetters);

            Console.WriteLine(finalResult);
        }
    }
}
