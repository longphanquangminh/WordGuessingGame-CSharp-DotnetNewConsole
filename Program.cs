using System;

namespace WordGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            string[] words = {"dog", "cat", "boy", "girl"};
            string wordToGuess = words[rand.Next(0, words.Length)];

            bool hasWon = false;

            for(int i = 0; i<words.Length/2; i++){
                Console.WriteLine("Guess The Word: ");

                for(int j = 0; j < words.Length; j++){
                    Console.WriteLine(words[j] + " ");
                }

                Console.WriteLine();

                string guess = Console.ReadLine();

                if(guess == wordToGuess){
                    hasWon = true;
                    break;
                }
            }
            if(hasWon){
                Console.WriteLine("You've won!");
            }
            else{
                Console.WriteLine("You've lost! The word was " + wordToGuess);
            }
        }
    }
}
