# Primary Colors Guessing Game

This is a simple C# console-based guessing game where the player has to guess a randomly selected primary color (red, blue, or yellow). The player has 3 attempts to guess the correct color, and after each wrong guess, a hint is provided.

## Features

- The player is prompted to enter their name.
- The game randomly selects one of the three primary colors: red, blue, or yellow.
- The player has a maximum of 3 attempts to guess the correct color.
- A hint is provided after each incorrect guess to help the player.
- If the player guesses correctly, the game congratulates them. Otherwise, it reveals the correct color after 3 wrong attempts.

## How It Works

1. The player is welcomed and prompted to enter their favorite color and answer a fun question about magic.
2. The game randomly selects one of the following primary colors:
   - Red
   - Blue
   - Yellow
3. The player guesses the color, and after each wrong guess, a hint is displayed:
   - If the correct color is red: "Hint: It's the color of a stop sign."
   - If the correct color is blue: "Hint: It's the color of the sky on a clear day."
   - If the correct color is yellow: "Hint: It's the color of the sun."
4. The game continues until the player either guesses the correct color or runs out of attempts (3 maximum).

## Sample Output

Please enter your name: Emmanuel

Welcome Emmanuel. This is a guessing game.

Enter your favorite color: blue

Do you believe in magic? (yes or no): yes

I have selected a random primary color (red, blue, or yellow). Try to guess it! You have 3 attempts. Attempt 1: Enter your guess: red Incorrect guess! Hint: It's the color of the sky on a clear day. You have 2 attempts left. Try again. Attempt 2: Enter your guess: blue Congratulations Emmanuel! You guessed the correct color 'blue' after 2 attempts. Press Enter to exit.

## Requirements

- .NET Framework or .NET Core SDK
- Basic knowledge of C#

## How to Run

1. Clone or download this repository.
2. Open the project in an IDE like Visual Studio or use the .NET CLI.
3. Run the project by pressing `F5` or using the following command:

   ```bash
   dotnet run
Follow the prompts to interact with the game.

This `README.md` explains how the color guessing game works, provides a sample output, and 
