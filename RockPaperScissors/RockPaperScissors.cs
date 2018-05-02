using System;
using System.Linq;
using System.Threading;

namespace RockPaperScissors
{
    class Program
    {
        public static int userScore = 0;
        public static int compScore = 0;
        public static bool newGame = true;

        public static void Main()
        {
            
            Welcome();

            //Go get first input
            int hand1 = GetUserInput();
            string userSelection = IntSelectionToString(hand1);
            Console.WriteLine("You have chosen {0}.  Excellent move.", userSelection);
            Thread.Sleep(1500);
            
            //Get computer "input"
            Console.WriteLine("Now it's the computers turn!");
            Thread.Sleep(1500);
            int hand2 = GetCompInput();
            string compSelection = IntSelectionToString(hand2);
            Console.WriteLine("The computer has chosen {0}.", compSelection);
            Thread.Sleep(1500);

            //Decide winner
            int roundWinner = CompareHands(hand1, hand2);
            Thread.Sleep(1500);

            //give points
            Console.WriteLine(AnnounceRoundWinnerandScore(roundWinner));
            Thread.Sleep(1500);

            //report score
            Console.WriteLine("Your score is {0}.  The computer's score is {1}.", userScore, compScore);
            Thread.Sleep(1500);

            //Play again
            Console.WriteLine("Play again? (y/n)");
            string playAgain = Console.ReadLine();
            PlayAgain(playAgain);
        }

        public static void Welcome()
        {
            if (newGame)
            {
                Console.WriteLine("Welcome to Rock Paper Scissors!");
                newGame = false;
                Thread.Sleep(1500);
            }
            else
            {
                return;
            }
        }

        public static int GetUserInput()
        {
            Console.WriteLine("Enter 1 for Rock, 2 for Paper, or 3 for Scissors.");
            Thread.Sleep(1500);
            string userInput = Console.ReadLine();
            int userInputInt = 0;

            if (new[]{"1","2","3"}.Contains(userInput))
            {
                userInputInt = Int32.Parse(userInput);
            }
            else
            {
                Console.WriteLine("That is not a valid option.");
                Thread.Sleep(1000);
                GetUserInput();
            }

            return userInputInt;
        }

        public static int GetCompInput()
        {
            Random rnd = new Random();
            int computerInputInt = rnd.Next(1, 4);

            return computerInputInt;
        }

        public static string IntSelectionToString(int intSelection)
        {
            if (intSelection == 1)
            {
                return "rock";
            }
            else if (intSelection == 2)
            {
                return "paper";
            }
            else
            {
                return "scissors";
            }              
        }
        
        public static int CompareHands(int hand1, int hand2)  //0 = tie, 1 = user win, 2 = computer win
        {
            if (hand1 == hand2)
            {
                Console.WriteLine("You guys tie!");
                return 0; //"tie"
            }
            else
            {
                //1=rock 2-paper 3=scissors
                if (hand1 == 1)  //if player chooses 1 (rock)
                {
                    if (hand2 == 2)  //and comp gets paper
                    {
                        Console.WriteLine("Paper beats rock.");
                        return 2; //"rock loses to paper, computer wins";
                    }
                    else  //and comp gets scissors
                    {
                        Console.WriteLine("Rock beats scissors.");
                        return 1; //"rock beats scissors, you win";
                    }
                }
                else if (hand1 == 2)  //if player chooses 2 (paper)
                {
                    if (hand2 == 3) //and comp gets scissors
                    {
                        Console.WriteLine("Scissors beat paper.");
                        return 2; //"paper loses to scissors, computer wins";
                    }
                    else //and comp gets rock
                    {
                        Console.WriteLine("Paper beats rock.");
                        return 1; //"paper beats rock, you win";
                    }
                }
                else  //if player chooses 3 (scissors)
                {
                    if (hand2 == 1)  //and computer gets rock
                    {
                        Console.WriteLine("Rock beats scissors.");
                        return 2; //"scissors lose to rock, computer wins";
                    }
                    else  //and computer gets paper
                    {
                        Console.WriteLine("Scissors beats paper.");
                        return 1; //"scissors beat paper, you win";
                    }
                }
            }
        }

        public static string AnnounceRoundWinnerandScore(int roundWinner)
        {
            if (roundWinner == 0)
            {
                userScore = userScore + 1;
                compScore = compScore + 1;
                return "You both get a point";
            }
            else if (roundWinner == 1)
            {
                userScore = userScore + 1;
                return "You win this round!";
            }
            else
            {
                compScore = compScore + 1;
                return "Computer wins this round!";
            }
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
        
    }
}
