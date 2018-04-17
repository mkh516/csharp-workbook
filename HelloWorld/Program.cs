using System;
					
public class Program
{
	public static void Main()
	{
		string name = "";
        string answer1 = "";
        string answer2 = "";
		int sisters = 0;
		int brothers = 0;
        string occupation = "";
		
        Console.WriteLine("Hi. What is your name?");
        name = Console.ReadLine();

        Console.WriteLine("Nice to meet you {0}.  Do you have any siblings (type yes or no)?", name);
        answer1 = Console.ReadLine();
        if (answer1 == "yes")
        {
            Console.WriteLine("Great!  How many sisters do you have?");
            sisters = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("And how many brothers do you have?");
            brothers = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Wonderful!  {0} sisters and {1} brothers for a total of {2} siblings.", sisters, brothers, sisters + brothers);
        }
        else if (answer1 == "no")
        {
            Console.WriteLine("Oh only child! Thanks for stopping by!");
        }
		
        Console.WriteLine("Do you work, {0} (type yes or no)?", name);
        answer2 = Console.ReadLine();
        if (answer2 == "yes")
        {
            Console.WriteLine("Congrats.  What do you do?");
            occupation = Console.ReadLine();
            Console.WriteLine("Oh {0} sounds interesting.", occupation);
        }
        else if (answer2 == "no")
        {
            Console.WriteLine("Well that's okay, I wish I didn't have to work!");
        }
	}
}