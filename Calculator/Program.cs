// Calculator Mini task

Console.WriteLine("Welcome to Alien's Calculator");

Console.Write("First Number: ");
string? firstText = Console.ReadLine();

Console.Write("Second Number: ");
string? secondText = Console.ReadLine();

if (
    decimal.TryParse(firstText, out decimal firstNumber)
    && decimal.TryParse(secondText, out decimal secondNumber)
)
{
    Console.Write("Choose one of these operators (+, -, *, /, %): ");
    string? operatorText = Console.ReadLine()?.Trim();
    if (operatorText == "+")
    {
        Console.WriteLine(
            $"{firstNumber:F2} {operatorText} {secondNumber:F2} = {firstNumber + secondNumber:F2}"
        );
    }
    else if (operatorText == "-")
    {
        Console.WriteLine(
            $"{firstNumber:F2} {operatorText} {secondNumber:F2} = {firstNumber - secondNumber:F2}"
        );
    }
    else if (operatorText == "*")
    {
        Console.WriteLine(
            $"{firstNumber:F2} {operatorText} {secondNumber:F2} = {firstNumber * secondNumber:F2}"
        );
    }
    else if (operatorText == "%")
    {
        if (secondNumber != 0)
        {
            Console.WriteLine(
                $"{firstNumber:F2} {operatorText} {secondNumber:F2} = {firstNumber % secondNumber:F2}"
            );
        }
        else
        {
            Console.WriteLine("Cannot divide by zero");
        }
    }
    else if (operatorText == "/")
    {
        if (secondNumber != 0)
        {
            Console.WriteLine(
                $"{firstNumber:F2} {operatorText} {secondNumber:F2} = {firstNumber / secondNumber:F2}"
            );
        }
        else
        {
            Console.WriteLine("Cannot divide by zero");
        }
    }
    else
    {
        Console.WriteLine("Invalid input: You must choose one of these operators (+, -, *, /, %)");
    }
}
else
{
    Console.WriteLine("Invalid input: you should enter valid numbers (ex: 33.2, 10 and etc.) ");
}
