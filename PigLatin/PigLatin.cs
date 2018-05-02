using System;
using System.Threading;

namespace PigLatin
{
    class Program
    {
        public static void Main()
        {
            
            Console.WriteLine("Hello! Ready to have some fun with pig latin?");
            Thread.Sleep(1500);
            Console.WriteLine("Type any word or sentence, and I'll tell you the pig latin transalation!");

            GetInput();
        }

        public static void GetInput()
        {
            string userInput;
            string[] inputToArray;

            Console.WriteLine("GO!");
            userInput = Console.ReadLine();
            Console.WriteLine("Great. Give me a second, and I'll get the translation for you.");
            Thread.Sleep(1500);

            inputToArray = userInput.Split(' ');
            
            TranslateSentence(inputToArray);
        }

        public static void TranslateSentence(string[] sentenceArray)
        {

            string[] translatedWords = new string[sentenceArray.Length];
            
            for (int i = 0; i < sentenceArray.Length; i++)
            {
                string word = sentenceArray[i];
                word = TranslateWord(word);
                translatedWords[i] = word;
            }

            Console.WriteLine(string.Join(" ", translatedWords));
            PlayAgain();
        }

        public static string ScrubWord(string word)
        {
            word = word.ToLower();
            return word;
        }
        
        public static string TranslateWord(string word)
        {
            word = ScrubWord(word);
            string firstPart;
            string restWord;
            string translatedWord;
            int firstVowelIndex;

            firstVowelIndex = word.IndexOfAny(new char[] {'a', 'e', 'i', 'o', 'u'}); //the first one that it finds

            if (firstVowelIndex <= 0)
            {
                translatedWord = word + "yay";
            }
            else
            {
                firstPart = word.Substring(0,firstVowelIndex);
                restWord = word.Substring(firstVowelIndex);
                translatedWord = restWord + firstPart + "ay";
            }
            
            return translatedWord;

        }


        public static void PlayAgain()
        {
            string keepPlaying;   
            Console.WriteLine("Another go? (y/n)");
            keepPlaying = Console.ReadLine();

            if (keepPlaying == "y")
            {
                GetInput();
            }
            else
            {
                Console.WriteLine("Thanks for stopping by!");
            }

        }

    }
}
