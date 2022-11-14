// Challenge: The Prototype

Console.WriteLine("User 1, enter a number between 0 and 100");
int numberToGuess = int.Parse(Console.ReadLine());

Console.WriteLine("User 2, guess the number");
int guessedNumber = -1;

while (numberToGuess != guessedNumber)
{
    guessedNumber = int.Parse(Console.ReadLine());
    
    if (numberToGuess < guessedNumber)
    {
        Console.WriteLine($"{guessedNumber} is too high.");
        Console.Write("What is your next guess? ");
    }
    else if (numberToGuess > guessedNumber)
    {
        Console.WriteLine($"{guessedNumber} is too low.");
        Console.Write("What is your next guess? ");

    }

    if (numberToGuess == guessedNumber)
    {
        Console.WriteLine("You guessed the number!");
    }
}
