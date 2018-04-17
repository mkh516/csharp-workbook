using System;
using System.Threading;

namespace DataTypes
{
    class Program
    {
        static int complete;
        static void Main()
        {
            string playerName;
            string readyPlay;
            int stick;

            Console.WriteLine("Hi there, what is your name?");
            playerName = Console.ReadLine();
            Console.WriteLine("Nice to meet you, {0}.  Welcome to the cavern of secrets!", playerName);
            Thread.Sleep(1500);
            Console.WriteLine("You wake up on the cold floor of a dark cavern, and you can't remember how you got there.");
            Thread.Sleep(1500);
            Console.WriteLine("You get to your feet and see a stick on the floor next to you, do you pick it up? (y/n)");
            readyPlay = Console.ReadLine();

            if (readyPlay == "y")
            {
                stick = 1;
                Console.WriteLine("You have taken the stick, {0}!", playerName);
                Thread.Sleep(1500);
            }
            else
            {
                stick = 0;
                Console.WriteLine("I hope you don't need that stick later...");
                Thread.Sleep(1500);
            };
            
            ChapterOne(playerName, readyPlay, stick);
        }

        static void NotReady(string playerName)
        {
            Console.WriteLine("Oh {0}, I suppose you aren't ready for the challenge.", playerName);
        }

        static void ChapterOne(string playerName, string readyPlay, int stick) 
        {
            Thread.Sleep(1500);
            Console.WriteLine("As you proceed further into the cave, you see a small glowing object");
            Thread.Sleep(1500);
            Console.WriteLine("Do you approach it? (y/n)");
            readyPlay = Console.ReadLine();

            if (readyPlay == "y")
            {
                ChapterTwo(stick, playerName, readyPlay);
            }
            else
            {
                NotReady(playerName);
            }
        }

        static void ChapterTwo(int stick, string playerName, string readyPlay)
        {
            Thread.Sleep(1500);
            Console.WriteLine("You approach the object...");

            Thread.Sleep(1500);
            Console.WriteLine("As you draw closer, you begin to make out the object as an eye!");

            Thread.Sleep(1500);
            Console.WriteLine("It's a giant spider!! Do you fight?? (y/n)");
            readyPlay = Console.ReadLine();

            if (readyPlay == "y")
            {
                Console.WriteLine("You must not be afraid of spiders, {0}.", playerName);
                Thread.Sleep(1500);
                ChapterThree(stick, playerName, readyPlay);
            }
            else 
            {
                Thread.Sleep(1500);
                NotReady(playerName);
            }
        }

        static void ChapterThree(int stick, string playerName, string readyPlay)
        {

            Console.WriteLine("Let the fighting begin!");
            Thread.Sleep(1500);
            Console.WriteLine("You must hit above a 5 to kill the spider.");
            Thread.Sleep(1500);
            Console.WriteLine("If the spider hits higher than you, you will die!");
            Thread.Sleep(1500);
            
            int playerNum = 0;
            int spiderNum = 0;
            Random rnd = new Random();

            //stick taken
            if (stick == 1)
            {
                Console.WriteLine("Good thing you grabbed this stick!");
                Thread.Sleep(1500);

                Console.WriteLine("You quickly jab the spider in it's eye and gain an advantage.");
                Thread.Sleep(1500);

                playerNum = rnd.Next(3, 10);
                spiderNum = rnd.Next(1, 5);

                Console.WriteLine("You hit a {0}.", playerNum);
                Thread.Sleep(1500);
                Console.WriteLine("The spider hit a {0}.", spiderNum);
                Thread.Sleep(1500);

                gameResults(playerNum, spiderNum, playerName);
            }
            
            else 
            {
                Console.WriteLine("Too bad you didn't grab that stick, {0}! You probably could have used it right about now.", playerName);
                Thread.Sleep(1500);

                playerNum = rnd.Next(1, 8);
                spiderNum = rnd.Next(1, 5);

                Console.WriteLine("You hit a {0}.", playerNum);
                Thread.Sleep(1500);
                Console.WriteLine("The spider hit a {0}.", spiderNum);
                Thread.Sleep(1500);

                gameResults(spiderNum, playerNum, playerName);
            }
        }

        static void gameResults (int spiderNum, int playerNum, string playerName)
        {
             if (spiderNum > playerNum)
                {
                    Console.WriteLine("The spider has dealt more damage than you!");
                    complete = 0;
                }
                else if (playerNum < 5)
                {
                    Console.WriteLine("You didn't do enough damage to kill the spider, but you manage to escape");
                    complete = 1;
                }
                else
                {
                    Console.WriteLine("You killed the spider!");
                    complete = 1;
                }
            
            Thread.Sleep(1500);
            endGame(complete, playerName);
        }

        static void endGame(int complete, string playerName)
        {
            string keepPlaying;

            if (complete == 1)
            {
                Console.WriteLine("You managed to escape the cavern alive, {0}! Would you like to play again? (y/n)", playerName);
                keepPlaying = Console.ReadLine();

                if (keepPlaying == "y")
                {
                    Main();
                }
                else
                {
                    Console.WriteLine("Thanks for playing!");
                }
            }
            else
            {
                Console.WriteLine("You died, {0}! Would you like to play again? (y/n)", playerName);
                keepPlaying = Console.ReadLine();
                if (keepPlaying == "y")
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
}
