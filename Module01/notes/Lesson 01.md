# Module 1, Lesson 1: Program Structure, Types, and Variables

**Student:** Ahmed | **Status:** Completed | **Project:** `Module01`

---

## 1. Goal

After this lesson I can:

- Read and write a basic C# program in the modern style.
- Declare variables with the right built-in type.
- Print text with string interpolation.
- Read the most common compiler errors.

---

## 2. Core Concepts

C# is **statically typed**: every variable has a type, and the type is fixed at **compile time** (when I build). The compiler checks types before the program runs.

### Built-in types

| Type | Use | Example |
|---|---|---|
| `int` | whole numbers (32-bit, about ±2.1 billion) | `int age = 28;` |
| `long` | big whole numbers (64-bit) | `long big = 10_000_000_000L;` |
| `double` | decimal numbers, **binary and approximate** | `double pi = 3.14;` |
| `decimal` | **money**, base 10 and exact | `decimal price = 19.99m;` |
| `bool` | true or false | `bool ok = true;` |
| `char` | one character, **single quotes** | `char c = 'A';` |
| `string` | text, **double quotes** | `string name = "Ahmed";` |

### Rules to remember

- Every statement ends with `;`.
- C# is **case-sensitive** (`Console` is not `console`).
- `var` is **not** dynamic typing. It is **type inference**: the compiler picks the type from the right side, **once, at compile time**, and the type never changes.
- A declaration (`int age`) creates a **new variable**. To change a value, assign **without** the type: `age = 8;`
- Naming convention:
  - Local variables and parameters: `camelCase` (`subTotal`)
  - Classes and methods: `PascalCase` (`Console`, `GetTotal`)

---

## 3. Python vs C#

| | Python | C# |
|---|---|---|
| Typing | Dynamic (type belongs to the **value**) | Static (type belongs to the **variable**) |
| Re-assign another type | `x = 5` then `x = "a"` works | Compile error |
| Blocks | Indentation | `{ }` braces |
| Line end | New line | `;` |
| Print | `print(f"Hi {name}")` | `Console.WriteLine($"Hi {name}");` |
| `7 / 2` | `3.5` | `3` (integer division) |
| `'A'` vs `"A"` | Both are `str` | `char` vs `string` (different types) |

**Mindset shift:** many Python mistakes appear at runtime. In C#, the compiler catches many of them before the program runs. Compiler errors are free help.

---

## 4. Example Code

Setup:

```bash
cd ~/Alien/courses/csharp/CSharpCourse
dotnet new console -n Module01
dotnet sln add Module01/Module01.csproj
cd Module01
dotnet run
```

`Program.cs` (modern style, top-level statements):

```csharp
string name = "Ahmed";
int age = 28;
decimal balance = 1500.75m;
bool isStudent = false;
var city = "Alexandria"; // compiler infers: string

Console.WriteLine($"Name: {name}, Age: {age}");
Console.WriteLine($"Balance: {balance} EGP, Student: {isStudent}");
Console.WriteLine($"City: {city}");

Console.WriteLine(7 / 2);   // 3   (integer division)
Console.WriteLine(7 / 2.0); // 3.5 (double division)
```

**Older style** (seen in courses and legacy code, same result):

```csharp
using System;

namespace Module01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
        }
    }
}
```

---

## 5. Common Compiler Errors

Read errors in this order: **file, line, code (`CSxxxx`), text**.

| Code I write | Error | Meaning |
|---|---|---|
| `int x = "hello";` | `CS0029` | Cannot convert `string` to `int` |
| `int y = 5` (no `;`) | `CS1002` | `;` expected |
| `console.WriteLine("a");` | `CS0103` | Name does not exist (wrong case or typo) |
| `int a = 5; int a = 6;` | `CS0128` | Variable already defined in this scope |
| `int n; Console.WriteLine(n);` | `CS0165` | Use of unassigned local variable |
| `var z;` | `CS0818` | `var` must be initialized |
| `decimal * double` | `CS0019` | Operator cannot be applied to these types |
| `int tax = someDecimal;` | `CS0266` | Cannot implicitly convert `decimal` to `int` |
| `decmial x;` | `CS0246` | Type or namespace not found (typo) |
| `Console.WrietLine(...)` | `CS0117` | `Console` has no such method (typo) |

### Senior habits for reading errors

1. Fix **errors first**, from top to bottom. Then rebuild. Then look at warnings.
2. One mistake can create several messages. Example: a duplicate `int age` gives `CS0128` (the real error) and also `CS0219` (a side effect: the second `age` is "never used").
3. `CS0103`, `CS0117`, `CS0246`: check for **typos** first.
4. Look for red underlines in Neovim before running.

---

## 6. Exercises (my solutions, corrected)

### Exercise 1: variables and interpolation

```csharp
string name = "Ahmed Mansour";
int age = 100;
string city = "Boko";

Console.WriteLine($"Hello this is {name}, I'm {age} years old. I'm from {city}");
```

### Exercise 2: arithmetic

```csharp
int a = 10;
int b = 3;

Console.WriteLine(a + b); // 13
Console.WriteLine(a - b); // 7
Console.WriteLine(a * b); // 30
Console.WriteLine(a / b); // 3  (integer division)
Console.WriteLine(a % b); // 1  (remainder)
```

### Exercise 3: print `3.5` from two `int` variables

```csharp
int x = 7;
int y = 2;
Console.WriteLine(x / (double)y); // 3.5
```

Key lesson: `:F2` only changes **how a result is printed**. It cannot fix integer division, because the division happens **before** formatting. Put the cast on the **operand**:

```csharp
Console.WriteLine((double)(x / y)); // 3   (int division happens first)
Console.WriteLine(x / (double)y);   // 3.5 (correct)
```

### Exercise 4: `double` vs `decimal`

```csharp
double doubleA = 0.1;
double doubleB = 0.2;
decimal decimalA = 0.1m;
decimal decimalB = 0.2m;

Console.WriteLine(doubleA + doubleB);   // 0.30000000000000004
Console.WriteLine(decimalA + decimalB); // 0.3
```

Why: `double` stores numbers in **binary**, and `0.1` cannot be stored exactly in binary (like `1/3` in decimal). `decimal` stores numbers in **base 10**, so `0.1` and `0.2` are exact.

### Exercise 5: price, quantity, 14% tax

```csharp
decimal price = 99.99m;
int quantity = 3;
decimal subTotal = price * quantity;
decimal tax = subTotal * .14m;
decimal total = subTotal + tax;

Console.WriteLine($"Subtotal: {subTotal:F2}"); // 299.97
Console.WriteLine($"Tax (14%): {tax:F2}");     // 42.00 (real value 41.9958)
Console.WriteLine($"Total: {total:F2}");        // 341.97
```

Mistakes I fixed:

- `int tax` can not hold a decimal value. Money stays `decimal`.
- `.14` is a `double`. A decimal literal needs the `m` suffix: `.14m`.
- Tax is **added** to the subtotal, not subtracted.
- `:F2` rounds only the **display**. The variable keeps the exact value.

---

## 7. Mini-task: Receipt Printer

```csharp
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
Console.WriteLine($"Total: {receiptTotal:F2} EGP");
```

Output:

```
Hello Mr. Mark, Welcome to Apple Store
Items: 15 x Apple @ 22.50 EGP
Subtotal: 337.50 EGP
Tax (14%): 47.25 EGP
Total: 384.75 EGP
```

Notes:

- `var` is fine for the strings because the type is obvious from the right side. For `decimal` I write the type, because `22.5m` is easy to misread.
- `decimal * int` works without a cast, because `int` converts to `decimal` safely.

---

## 8. Quiz Review

| Question | Answer |
|---|---|
| Q1: `9 / 4` and `9 % 4` | `2` and `1` |
| Q2: Is `var x = 10; x = "ten";` valid? | **No.** `var` infers `int` at compile time. Assigning a `string` is a type mismatch (`CS0029`). |
| Q3: Why `decimal` for money? | `double` is binary and approximate. `decimal` is base 10 and exact for values like `0.1`. Small errors add up in money. |
| Q4: `'A'` vs `"A"` | `char` (one character) vs `string` (text). Different types: `char c = "A";` is `CS0029`. |

### Weak spot to watch

**Changing a value is not the same as changing a type.**

```csharp
int age = 18;
age = 8;       // OK: same type, new value

var x = 10;    // type is int
x = "ten";     // ERROR: would need to change the type
```

---

## 9. SDK vs Runtime (Module 0 warm-up)

- **SDK:** everything needed to **build** .NET apps (compiler, `dotnet` CLI, templates, build tools). It includes a runtime.
- **Runtime:** the part that **runs** a compiled app (`.dll`).
- Developers install the SDK. Production servers usually need only the runtime.
- Check: `dotnet --list-sdks`, `dotnet --list-runtimes`.

**`bin/` and `obj/` in `.gitignore`:** they are generated by `dotnet build`, anyone can recreate them from the source, they can be large, and they contain machine-specific files that cause useless Git conflicts. Rule: commit **source**, not **build output**.

---

## 10. Interview Corner (strong answers)

**1. `int` vs `long`, `double` vs `decimal`?**

> `int` is 32-bit (about ±2.1 billion). `long` is 64-bit (about ±9 quintillion), used when `int` can overflow. `double` is binary, approximate, and fast. `decimal` is base 10, exact for decimal values, slower, and used for money.

**2. Is `var` dynamic typing?**

> No. `var` is **type inference**. The compiler infers the type at compile time, and it never changes. It is still static typing.

**3. What does "statically typed" mean?**

> The type of every variable is known and checked at **compile time**. Pro: errors are caught early and tooling (IntelliSense) works better. Con: more rules and sometimes more code, with explicit conversions like `(double)y`.

---

## 11. Checklist

- [x] I can create a console project and add it to the solution.
- [x] I can declare variables of the 7 main types.
- [x] I understand that `7 / 2` is `3` in C#.
- [x] I can explain why `var` is still static typing.
- [x] I can read a `CSxxxx` error message (file, line, code, text).
- [x] I did the 6 error experiments and fixed them.

---

## 12. Quick Reference Card

```csharp
// Types
int i = 1;  long l = 1L;  double d = 1.5;  decimal m = 1.5m;
bool b = true;  char c = 'A';  string s = "text";

// Interpolation and formatting
Console.WriteLine($"Total: {total:F2}");

// Cast on the operand, not on the result
x / (double)y

// Re-assign (no type keyword)
age = 8;

// Naming: camelCase for locals, PascalCase for methods and classes
```

---

## Git

```bash
cd ~/Alien/courses/csharp/CSharpCourse
git add .
git commit -m "docs: add Module 1 Lesson 1 notes"
```
