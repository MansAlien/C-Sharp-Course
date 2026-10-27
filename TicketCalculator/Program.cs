decimal baseTicketPrice = 100m;

// Age: validate first and stop early (guard clause), so the user is never asked more questions after a bad answer.
Console.Write("Enter your age: ");
string? ageText = Console.ReadLine()?.Trim();

if (!int.TryParse(ageText, out int age) || age < 0 || age > 120)
{
    Console.WriteLine("Invalid age: enter a whole number from 0 to 120");
    return;
}

// The order of calculation matters because the percentages stack:
// age discount -> day surcharge -> member discount (last).
decimal priceAfterAgeDiscount;
if (age <= 12)
{
    priceAfterAgeDiscount = baseTicketPrice * 0.5m;
}
else if (age >= 65)
{
    priceAfterAgeDiscount = baseTicketPrice * 0.6m;
}
else
{
    priceAfterAgeDiscount = baseTicketPrice;
}

// Day
Console.Write("Enter the day number (1 = Monday, 7 = Sunday): ");
string? dayText = Console.ReadLine()?.Trim();

if (!int.TryParse(dayText, out int day) || day < 1 || day > 7)
{
    Console.WriteLine("Invalid day: enter a whole number from 1 to 7");
    return;
}

decimal priceAfterDaySurcharge;
switch (day)
{
    case 5:
    case 6:
    case 7:
        priceAfterDaySurcharge = priceAfterAgeDiscount * 1.2m;
        break;
    default:
        // The range check above guarantees days 1 to 4 reach this point.
        priceAfterDaySurcharge = priceAfterAgeDiscount;
        break;
}

// Member
Console.Write("Are you a member? (y/n): ");
string? memberText = Console.ReadLine()?.Trim().ToLower();

if (memberText != "y" && memberText != "n")
{
    Console.WriteLine("Invalid answer: enter y for yes or n for no");
    return;
}

decimal finalPrice = memberText == "y" ? priceAfterDaySurcharge * 0.9m : priceAfterDaySurcharge;

Console.WriteLine($"Base price: {baseTicketPrice:F2} EGP");
Console.WriteLine($"After age discount: {priceAfterAgeDiscount:F2} EGP");
Console.WriteLine($"After day surcharge: {priceAfterDaySurcharge:F2} EGP");
Console.WriteLine($"Final price: {finalPrice:F2} EGP");