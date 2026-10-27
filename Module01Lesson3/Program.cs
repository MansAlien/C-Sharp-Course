// Console.Write("Enter your age: ");
// string? ageText = Console.ReadLine();
//
// if (int.TryParse(ageText, out int age))
// {
//     // Invalid range first, so the next checks only need an upper limit.
//     if (age < 0 || age > 120)
//     {
//         Console.WriteLine("Invalid age");
//     }
//     else
//     {
//         if (age <= 12)
//         {
//             Console.WriteLine("Child");
//         }
//         else if (age <= 17)
//         {
//             Console.WriteLine("Teenager");
//         }
//         else if (age <= 64)
//         {
//             Console.WriteLine("Adult");
//         }
//         else
//         {
//             Console.WriteLine("Senior");
//         }
//
//         Console.WriteLine($"Can vote: {(age >= 18 ? "Yes" : "No")}");
//     }
// }
// else
// {
//     Console.WriteLine("Invalid input: enter a valid whole number");
// }

// Console.Write("Enter the day number: ");
// string? dayText = Console.ReadLine();
//
// if (int.TryParse(dayText, out int dayNumber))
// {
//     switch (dayNumber)
//     {
//         case 1:
//             Console.WriteLine("Monday");
//             break;
//         case 2:
//             Console.WriteLine("Tuesday");
//             break;
//         case 3:
//             Console.WriteLine("Wednesday");
//             break;
//         case 4:
//             Console.WriteLine("Thursday");
//             break;
//         case 5:
//             Console.WriteLine("Friday");
//             break;
//         case 6:
//             Console.WriteLine("Saturday");
//             Console.WriteLine("Weekend");
//             break;
//         case 7:
//             Console.WriteLine("Sunday");
//             Console.WriteLine("Weekend");
//             break;
//         default:
//             Console.WriteLine("Invalid day");
//             break;
//     }
// }
// else
// {
//     Console.WriteLine("Invalid Day Number: enter a valid whole number from 1 to 7");
// }
//

// Console.Write("Enter grade: ");
// string? gradeText = Console.ReadLine()?.Trim();
// if (int.TryParse(gradeText, out int grade) && grade <= 100 && grade >= 0)
// {
//     switch (grade / 10)
//     {
//         case 10:
//         case 9:
//             Console.WriteLine("A");
//             break;
//         case 8:
//             Console.WriteLine("B");
//             break;
//         case 7:
//             Console.WriteLine("C");
//             break;
//         case 6:
//             Console.WriteLine("D");
//             break;
//         default:
//             Console.WriteLine("F");
//             break;
//     }
// }
// else
// {
//     Console.WriteLine("Invalid input: enter a whole number from 0 to 100");
// }

// Challenge 

Console.Write("Enter Year: ");
string? yearText = Console.ReadLine()?.Trim();
if (int.TryParse(yearText, out int year) && year > 0 )
{
    if( (year % 400 == 0) || (year % 4 == 0 && year % 100 != 0) )
    {
        Console.WriteLine("Leap year");
    }
    else
    {
        Console.WriteLine("Not a leap year");
    }
}
else
{
    Console.WriteLine("Invalid input: enter a whole number at least 1");
}