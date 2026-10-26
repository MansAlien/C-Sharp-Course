// string name = "Ahmed";
// int age = 18;
// decimal balance = 1500.75m;
// bool isStudent = false;
// var city = "Alexandria";
//
// Console.WriteLine($"Name: {name}, Age:{age}");
// Console.WriteLine($"Balance: {balance} EGP, Student: {isStudent}");
// Console.WriteLine($"City: {city}");
//
// Console.WriteLine(7 / 2);
// Console.WriteLine(7 / 2.0);
//

// Easy -----------------------------------------------------
// Exercise 1
string name = "Ahmed Mansour";
int age = 100;
string city = "Boko";

Console.WriteLine($"Hello this is {name}, I'm {age} years old. I'm from {city}");

// Exercise 2
int a = 10;
int b = 3;

Console.WriteLine(a + b);
Console.WriteLine(a - b);
Console.WriteLine(a * b);
Console.WriteLine(a / b);
Console.WriteLine(a % b);

// Medium
// Exercise 3
int x = 7;
int y = 2;
Console.WriteLine($"{x / (double)y}");

// Exercise 4
double d_num_1 = 0.1;
double d_num_2 = 0.2;

decimal dc_num_1 = 0.1m;
decimal dc_num_2 = 0.2m;

// Here it print the number as "0.30000000000000004" which is the number with all the decimal places
Console.WriteLine(d_num_1 + d_num_2);

//  Here it printed the number with one decimal place
Console.WriteLine(dc_num_1 + dc_num_2);

// Exercise 5
decimal price = 99.99m;
int quantity = 3;
decimal subTotal = price * quantity;
decimal tax = subTotal * .14m;
decimal total = subTotal + tax;

Console.WriteLine($"Before Tax: {subTotal:F2}");
Console.WriteLine($"After Tax: {total:F2}");
Console.WriteLine($"Tax (14%): {tax:F2}");

// Mini-task
// var is able to auto set the variable type one time so it's ok to use it here because it would know that it's string by itself.
var storeName = "Apple Store";
var customerName = "Mark";
var itemName = "Apple";
decimal applePrice = 22.5m;
int appleQuantity = 15;

decimal receiptSubTotal = applePrice * appleQuantity;
decimal receiptTax = receiptSubTotal * .14m;
decimal receiptTotal = receiptSubTotal + receiptTax;

Console.WriteLine($"Hello Mr. {customerName}, Welcome to {storeName}");
Console.WriteLine($"Items: {appleQuantity} x {itemName} @ {applePrice:F2} EGP");
Console.WriteLine($"Subtotal: {receiptSubTotal:F2} EGP");
Console.WriteLine($"Tax (14%): {receiptTax:F2} EGP");
Console.WriteLine($"Total : {receiptTotal:F2} EGP");
