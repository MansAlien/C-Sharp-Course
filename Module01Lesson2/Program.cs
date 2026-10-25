// // Input
// Console.WriteLine("What is your age?");
// string? input = Console.ReadLine();
//
// if (int.TryParse(input, out int age))
// {
//     Console.WriteLine($"Hello, your age is {age}");
// }
// else
// {
//     Console.WriteLine("This not a valid whole number");
// }
//
// // Explicit cast cuts the decimal part
// double price = 9.99;
// Console.WriteLine((int)price);          // 9
// Console.WriteLine(Math.Round(price));   // 10


// Exercise 1
// Console.WriteLine(10 / 4); -> 2
// Console.WriteLine(10 % 4); -> 2
// Console.WriteLine(10 / 4.0); -> 2.5
// // Exercise 2
// Console.WriteLine("What is your name ?");
// string? name = Console.ReadLine();
//
//
// if (! string.IsNullOrWhiteSpace(name))
// {
//     Console.WriteLine($"Hello {name}!");
// }
// else
// {
//     Console.WriteLine($"Hello Guest!");
// }
// Exercise 3
// Console.Write("First number: ");
// string? num1 = Console.ReadLine();
// Console.Write("Second number: ");
// string? num2 = Console.ReadLine();
//
// if (int.TryParse(num1, out int a) && int.TryParse(num2, out int b))
// {
//     Console.WriteLine($"Sum: {a + b}");
//     Console.WriteLine($"Difference: {a - b}");
//     Console.WriteLine($"Product: {a * b}");
//     if (b != 0)
//     {
//         Console.WriteLine($"Real Division: {a / (double)b:F2}");
//     }
//     else
//     {
//         Console.WriteLine("Can't divide by zero");
//     }
// }
// else
// {
//     Console.WriteLine("Please enter valid whole numbers.");
// }

// Exercise 4
// Console.Write("Enter the temperature in celsius: ");
// string? temp = Console.ReadLine();
//
// if (double.TryParse(temp, out double c))
// {
//     Console.WriteLine($"Fahrenheit: {(c * 9/ 5) + 32:F1}");
// }
// else
// {
//     Console.WriteLine("Enter a valid number");
// }
// Exercise 5
// Console.Write("Enter the bill amount: ");
// string? billText = Console.ReadLine();
// Console.Write("Enter the tip percentage (A whole number): ");
// string? tipText = Console.ReadLine();
//
// if (decimal.TryParse(billText, out decimal billAmount) && int.TryParse(tipText, out int tipPercentage))
// {
//     // Negative values make no sense for a bill or a tip.
//     if (billAmount > 0 && tipPercentage >= 0)
//     {
//         decimal tip = billAmount * tipPercentage / 100;
//         Console.WriteLine($"Bill: {billAmount:F2}");
//         Console.WriteLine($"Tip: {tip:F2}");
//         Console.WriteLine($"Total: {billAmount + tip:F2}");
//     }
//     else
//     {
//         Console.WriteLine("The bill must be greater than 0 and the tip cannot be negative.");
//     }
// }
// else
// {
//     Console.WriteLine("Invalid input. The bill must be a number and the tip a whole number");
// }
