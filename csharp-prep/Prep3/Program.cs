using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");

          Random random = new Random();

        do
        {
            int magicNumber = random.Next(1, 101);
            int guessCount = 0;

            Console.WriteLine("I'm thinking of a number between 1 and 100.");

            while (true)
            {
                Console.Write("Take a guess: ");
                int guess = int.Parse(Console.ReadLine());
                guessCount++;

                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher!");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower!");
                }
                else
                {
                    Console.WriteLine($"You guessed it in {guessCount} tries!");
                    break;
                }
            }

            Console.Write("Do you want to play again? (yes/no) ");
        } while (Console.ReadLine().ToLower() == "yes");

        Console.WriteLine("Thanks for playing!  See you next time!");
    }
}

