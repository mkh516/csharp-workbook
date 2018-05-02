using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main()
        {
            int num = 0;
            for (int i = 0; i < 100; i++)
            {
                num++;
                if (num % 3 == 0 && num % 5 == 0)
                {
                    Console.WriteLine("Fizzbuzz", num);
                }
                else if (num % 3 == 0)
                {
                    Console.WriteLine("Fizz", num);
                }
                else if (num % 5 == 0)
                {
                    Console.WriteLine("Buzz", num);                
                }
                else
                {
                    Console.WriteLine(num);
                }
            }
        }
    }
}
