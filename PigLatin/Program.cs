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
            int arrayLength = sentenceArray.Length;
            Console.WriteLine(arrayLength);

            string[] translatedWords = new string[arrayLength];

            //foreach (string word in sentenceArray)
            for (int i = 0; i < arrayLength; i++)
            {
                string word = sentenceArray[i];
                word = TranslateWord(word);
                Console.WriteLine(word);
                translatedWords[i] = word;
            }
            Console.WriteLine(translatedWords.Length);
            Console.WriteLine(string.Join(" ", translatedWords)); //
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

            firstVowelIndex = word.IndexOfAny(new char[] {'a', 'e', 'i', 'o', 'u'});

            if (firstVowelIndex == 0 || firstVowelIndex == -1)
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

            // Results(translatedWord, word);
        }

        public static void Results(string translatedWord, string word)
        {
            Console.WriteLine("The word {0} in piglatin is {1}", word, translatedWord);
            Thread.Sleep(1500);

            PlayAgain();
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
