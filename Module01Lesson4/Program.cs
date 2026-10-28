// int n = 10;
//
// while (n < 5)
// {
//     Console.WriteLine("Hello");
//     n++;
// }
//
// Console.WriteLine("Done");
//

// string? numberText;
// int number = 1;
// do 
// {
//
//     if (number <= 0)
//     {
//         Console.WriteLine("Invalid input: Enter a positive number");
//     }
//     Console.Write("Enter a positive number: ");
//     numberText = Console.ReadLine();
// }
// while (!int.TryParse(numberText, out number) || number <= 0);
//
// Console.WriteLine($"You entered: {number}");

// while (true)
// {
//     Console.Write("Enter a positive number: ");
//     string? numberText = Console.ReadLine();
//
//     if (numberText == null)
//     {
//         Console.WriteLine("Input closed");
//         break;
//     }
//     if (!int.TryParse(numberText, out int number) || number <= 0)
//     {
//         Console.WriteLine("Invalid input: Enter a positive whole number");
//         continue;
//     }
//     Console.WriteLine($"You entered: {number}");
//     break;
// }


// Console.Write("Enter a whole number: ");
// string? numberText = Console.ReadLine();
//
// if (int.TryParse(numberText, out int number))
// {
//     for (int i = 1; i < 11; i++)
//     {
//         Console.WriteLine($" {number} x {i} = {number * i}");
//     }
// }
// else
// {
//     Console.WriteLine("Invalid input: Enter a whole number");
// }
//


// Console.Write("Enter a positive whole number: ");
// string? numberText = Console.ReadLine();
//
// if (int.TryParse(numberText, out int number) && number > 0)
// {
//     for (int i = 1; i <= number; i++)
//     {
//         if (i % 15 == 0)
//         {
//             Console.WriteLine("FizzBuzz");
//         }
//         else if (i % 5 == 0)
//         {
//             Console.WriteLine("Buzz");
//         }
//         else if (i % 3 == 0)
//         {
//             Console.WriteLine("Fizz");
//         }
//         else
//         {
//             Console.WriteLine(i);
//         }
//     }
// }
// else
// {
//     Console.WriteLine("Invalid input: Enter a positive whole number");
// }
//

// string text = "hello";
// int count = 0;
//
// foreach (char c in text)
// {
//     if (c == 'l')
//     {
//         count++;
//     }
// }
//
// Console.WriteLine(count);

int wordsProcessed = 0;   // outside the loop: it must keep its value between rounds

while (true)
{
    Console.Write("Enter a word (or \"quit\" to stop): ");
    string? word = Console.ReadLine()?.Trim();   // original casing, no outer spaces

    // Only null means the input is closed (Ctrl+D). An empty line is just invalid.
    if (word == null)
    {
        Console.WriteLine("Input closed");
        break;
    }

    // After Trim(), a spaces-only line is also empty.
    if (word == "")
    {
        Console.WriteLine("Invalid input: empty or spaces-only text is not allowed");
        continue;
    }

    // Lowercase copy, used only for comparing. The original word stays for printing.
    string lowerWord = word.ToLower();

    if (lowerWord == "quit")
    {
        break;
    }

    int vowelCount = 0;   // inside the loop: it starts fresh for every word

    foreach (char c in lowerWord)
    {
        if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
        {
            vowelCount++;
        }
    }

    Console.WriteLine($"\"{word}\" has {vowelCount} vowels");
    wordsProcessed++;
}

Console.WriteLine($"Words processed: {wordsProcessed}");