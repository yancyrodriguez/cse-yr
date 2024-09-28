using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int userGuess = -1;
        

        while (userGuess != magicNumber)
        {
            Console.Write("What is your guess number? ");
            userGuess = int.Parse(Console.ReadLine());

            if (magicNumber > userGuess)

            {
                Console.WriteLine("Higher");
            }
            
            else if (userGuess > magicNumber)
            {
                Console.WriteLine("Lower");
            }

            else
            {
                Console.WriteLine($"You guessed it! The magic number is {magicNumber}.");
            }
            
        }
    }
}