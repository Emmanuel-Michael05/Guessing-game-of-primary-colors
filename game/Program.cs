using System;

namespace game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Welcome " + name + ". This is a guessing game.");
            Console.WriteLine();
            Console.Write("Enter your favorite color: ");
            string favoriteColor = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Do you believe in magic? (yes or no): ");
            string ans = Console.ReadLine().ToLower();
            Console.WriteLine();

            // Array of primary colors
            string[] primaryColors = { "red", "blue", "yellow" };
            Random rand = new Random();
            string correctColor = primaryColors[rand.Next(primaryColors.Length)]; // Randomly pick a primary color

            string guessedColor;
            int attempts = 0;
            int maxAttempts = 3;

            Console.WriteLine("I have selected a random primary color (red, blue, or yellow). Try to guess it!");
            Console.WriteLine($"You have {maxAttempts} attempts.");

            // Start guessing loop with attempt limit
            do
            {
                Console.Write($"Attempt {attempts + 1}: Enter your guess: ");
                guessedColor = Console.ReadLine().ToLower();
                attempts++;

                if (guessedColor == correctColor)
                {
                    Console.WriteLine($"Congratulations {name}! You guessed the correct color '{correctColor}' after {attempts} attempts.");
                    break;
                }
                else if (attempts < maxAttempts)
                {
                    // Provide a hint if the guess is wrong
                    Console.WriteLine("Incorrect guess!");
                    if (correctColor == "red")
                    {
                        Console.WriteLine("Hint: It's the color of a stop sign.");
                    }
                    else if (correctColor == "blue")
                    {
                        Console.WriteLine("Hint: It's the color of the sky on a clear day.");
                    }
                    else if (correctColor == "yellow")
                    {
                        Console.WriteLine("Hint: It's the color of the sun.");
                    }
                    Console.WriteLine($"You have {maxAttempts - attempts} attempts left. Try again.");
                }

            } while (attempts < maxAttempts);

            // If max attempts reached and the player didn't guess the color
            if (attempts == maxAttempts && guessedColor != correctColor)
            {
                Console.WriteLine($"Sorry, {name}, you've used all {maxAttempts} attempts. The correct color was '{correctColor}'.");
            }

            Console.WriteLine("Press Enter to exit.");
            Console.ReadLine();
        }
    }
}
