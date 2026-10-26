Console.Write("Enter your age: ");
string? ageText = Console.ReadLine();

if (int.TryParse(ageText, out int age))
{
    // Invalid range first, so the next checks only need an upper limit.
    if (age < 0 || age > 120)
    {
        Console.WriteLine("Invalid age");
    }
    else
    {
        if (age <= 12)
        {
            Console.WriteLine("Child");
        }
        else if (age <= 17)
        {
            Console.WriteLine("Teenager");
        }
        else if (age <= 64)
        {
            Console.WriteLine("Adult");
        }
        else
        {
            Console.WriteLine("Senior");
        }

        Console.WriteLine($"Can vote: {(age >= 18 ? "Yes" : "No")}");
    }
}
else
{
    Console.WriteLine("Invalid input: enter a valid whole number");
}
