int maxAttempts = 7;
int gamesPlayed = 0;   // outside the loops: they must survive between games
int gamesWon = 0;
bool keepPlaying = true;

// Outer loop: one round = one whole game
while (keepPlaying)
{
    // Declared here so every game starts fresh (smallest scope).
    // While testing, replace the next line with: int secret = 42;
    int secret = Random.Shared.Next(1, 101);   // the upper bound is exclusive: 1 to 100
    int attempt = 1;                           // number of the CURRENT guess
    bool won = false;
    bool inputClosed = false;

    // Job 1: ONLY the guesses.
    // A while loop (not for), because "continue" must NOT use an attempt on invalid input.
    // In a for loop, continue would still run the iterator (attempt++).
    while (attempt <= maxAttempts)
    {
        Console.Write($"Guess #{attempt} (1-100): ");
        string? guessText = Console.ReadLine()?.Trim();

        // Only null means closed input (Ctrl+D). An empty line is just invalid.
        if (guessText == null)
        {
            Console.WriteLine("Input closed");
            inputClosed = true;
            break;
        }

        if (!int.TryParse(guessText, out int guess) || guess < 1 || guess > 100)
        {
            Console.WriteLine("Invalid input: enter a whole number from 1 to 100");
            continue;
        }

        if (guess == secret)
        {
            won = true;
            break;   // attempt is NOT increased, so it is the number of the winning guess
        }

        Console.WriteLine(guess > secret ? "Too high" : "Too low");
        attempt++;   // runs only for a valid wrong guess
    }

    // break inside the guesses loop leaves only that loop,
    // so the closed input needs its own exit from the outer loop.
    if (inputClosed)
    {
        break;
    }

    // Job 2: ONLY the result.
    gamesPlayed++;
    if (won)
    {
        gamesWon++;
        Console.WriteLine($"Correct! You won in {attempt} attempts");
    }
    else
    {
        Console.WriteLine($"Game over. The number was {secret}");
    }

    // Job 3: ONLY the y/n question. It can never jump back to the guesses.
    while (true)
    {
        Console.Write("Play again? (y/n): ");
        string? answer = Console.ReadLine()?.Trim().ToLower();

        if (answer == "y")
        {
            break;   // leaves only this loop, so the outer loop starts a new game
        }

        if (answer == "n" || answer == null)   // null = closed input
        {
            keepPlaying = false;   // tells the outer loop to stop
            break;
        }

        Console.WriteLine("Invalid input: answer with y or n");
    }
}

// After the outer loop, so the summary prints on EVERY way out of the program.
Console.WriteLine($"Games played: {gamesPlayed}");
Console.WriteLine($"Games won: {gamesWon}");