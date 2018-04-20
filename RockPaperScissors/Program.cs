using System;
using System.Linq;

namespace RockPaperScissors
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Enter hand 1:");
            string hand1 = Console.ReadLine().ToLower();
            

            Console.WriteLine("Enter hand 2:");
            string hand2 = Console.ReadLine().ToLower();
            Console.WriteLine(CompareHands(hand1, hand2));

            // leave this command at the end so your program does not close automatically
            Console.WriteLine("Play again? (y/n)");
            string playAgain = Console.ReadLine();
            PlayAgain(playAgain);
        }
        
        public static string CompareHands(string hand1, string hand2)
        {
            if (hand1 == hand2)
            {
                return "tie";
            }
            else
            {
                if (hand1 == "rock")
                {
                    if (hand2 == "paper")
                    {
                        return hand1 + " loses to " + hand2;
                    }
                    else
                    {
                        return hand1 + " beats " + hand2;
                    }
                }
                else if (hand1 == "paper")
                {
                    if (hand2 == "scissors")
                    {
                        return hand1 + " loses to " + hand2;
                    }
                    else
                    {
                        return hand1 + " beats " + hand2;
                    }
                }
                else
                {
                    if (hand2 == "rock")
                    {
                        return hand1 + " loses to " + hand2;
                    }
                    else
                    {
                        return hand1 + " beats " + hand2;
                    }
                }
            }
            // return hand1 + ' ' + hand2;
        }

        public static void PlayAgain(string playAgain)
        {
            if (playAgain == "y")
            {
                Main();
            }
            else
            {
                Console.WriteLine("Thanks for playing!");
            }
        }

        public static bool ValidateEntry(string entry)
        {
            string[] validEntries = new string[] {"rock", "paper", "scissors"};
            if (validEntries.Contains(entry))
            {
              return true;
            }
            else
            {
              return false;
            }
        }
        
    }
}
