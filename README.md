# C# and .NET Roadmap

**Student:** Ahmed | **Mentor:** Claude | **Last updated:** 2026-10-24

---

## 1. Course Overview

### Goal

Get a **junior/mid-level backend .NET job** in Egypt or remote. Interview preparation is built into every lesson.

### Full path

```
C#  ->  SQL Server + EF Core  ->  ASP.NET Core Web API  ->  Auth / Security / Testing  ->  Architecture  ->  TypeScript + Angular
 ^
 we are here
```

This file covers **Stage 1: C#** (Modules 0 to 15). The later stages get their own plan when I say **"start the next stage"**.

### Starting point

- 3+ years of backend work: Python, Django, DRF, PostgreSQL, Redis, Docker, Git, JWT, pytest, Paymob.
- Already know: Git, Docker, HTTP/REST, SQL/ORM concepts, OOP concepts, Linux basics.
- Education degree (not CS), so computer science basics (memory, stack vs heap, complexity) are explained when they matter.

### Environment

| Item | Setup |
|---|---|
| OS | Arch Linux (Omarchy) |
| Editor | Neovim (LazyVim) with `roslyn_ls`, Mason, netcoredbg |
| SDK | .NET 10 (`10.0.113`) |
| Formatter | csharpier `1.3.0` (via `dotnet tool`) |
| Workflow | Terminal-first, `dotnet` CLI only. No Visual Studio, no Windows steps. |
| Project root | `~/Alien/courses/csharp/CSharpCourse` (one solution, `CSharpCourse.slnx`) |

Linux notes: paths are case-sensitive and use `/`. Project and namespace names have no hyphens.

---

## 2. How Each Lesson Works

Every lesson follows the same 10 steps:

1. **Goal**: what I can do after the lesson.
2. **Concept**: a simple mental model.
3. **Python comparison**: key differences and mindset shifts.
4. **Example**: short, runnable code with exact commands.
5. **Common mistakes**: and how to read the compiler errors.
6. **Exercises**: Easy, Medium, Challenge (no solutions at first).
7. **Quiz**: 3 to 5 questions, then correction.
8. **Mini-task**: a small program using the lesson's ideas.
9. **Interview corner**: 2 to 3 common questions.
10. **Checklist**: "I can..." items to confirm before moving on.

### Rules of the method

- One topic at a time. No moving on until the quiz and exercises are solid.
- **Hint ladder** when stuck: small hint, bigger hint, partial solution, full solution.
- Code reviews like a senior developer: correctness, readability, naming, idiomatic C#, performance.
- Modern C# first, with older styles shown for legacy code.
- Commit to Git after every lesson or project, with a meaningful message.

---

## 3. Assessment

| What | When | Rule |
|---|---|---|
| Quiz | End of every lesson | Must be solid before the next lesson |
| Checkpoint test | Every 2 to 3 lessons | Mixed questions and a small coding task |
| Module exam | End of every module | Concepts, code reading, coding task, interview questions. **Score 80/100 to pass.** Below 80 gives a targeted review plan. |
| "Predict the output" and "find the bug" | Regularly | Builds code-reading skill |
| Algorithm practice | Occasionally | Arrays, strings, hash maps, recursion, sorting |
| Capstone review | End of each project | README, tests, and a code review |

---

## 4. Roadmap

Time estimates assume **15 to 20 hours per week**. Total: about **160 to 200 hours** (roughly 9 to 12 weeks).

| # | Module | Main topics | Estimate |
|---|---|---|---|
| 0 | Environment and workflow | `dotnet` CLI, project structure, NuGet, solutions, Neovim LSP, csharpier, netcoredbg, `.editorconfig`, nullable, analyzers | 3-5 h |
| 1 | Language basics | Program structure, types, `var`, operators, conversion, console I/O, `TryParse`, conditions, `switch`, loops | 6-8 h |
| 2 | Methods and scope | Parameters (optional, named, `params`, `ref`, `out`, `in`), return values, local functions, overloading, recursion | 5-6 h |
| 3 | Types and memory | Value vs reference types, stack vs heap, boxing, string immutability, `StringBuilder`, nullability, arrays, `Span<T>` intro | 8-10 h |
| 4 | Collections | `List`, `Dictionary`, `HashSet`, `Queue`, `Stack`, immutable collections, Big-O basics, sorting and comparers | 8-10 h |
| 5 | Object-oriented programming | Classes, properties, constructors, inheritance, polymorphism, abstract vs interface, `struct`, `enum`, `record`, extension methods, equality | 15-20 h |
| 6 | Error handling and resources | Exceptions, custom exceptions, `IDisposable`, `using`, GC basics, guard clauses | 6-8 h |
| 7 | Generics, delegates, events, lambdas | Generic constraints, variance intro, `Func`/`Action`, events, closures | 10-12 h |
| 8 | LINQ | Method and query syntax, `Where`, `Select`, `GroupBy`, `Join`, deferred vs immediate execution, pitfalls | 8-10 h |
| 9 | Modern C# features | Pattern matching, switch expressions, tuples, records and `with`, collection expressions, primary constructors, raw strings | 6-8 h |
| 10 | Files, text, and data | File I/O, `System.Text.Json`, `DateTime`/`DateTimeOffset`/`TimeProvider`, `CultureInfo`, regex basics | 8-10 h |
| 11 | Async and concurrency | `Task`, `async`/`await`, `CancellationToken`, `IAsyncEnumerable`, threads, `lock`, `Channel<T>`, comparison with Python `asyncio` and the GIL | 12-15 h |
| 12 | Testing, debugging, logging | xUnit, assertions, Moq or NSubstitute, Bogus, netcoredbg, `ILogger`, `dotnet test` | 10-12 h |
| 13 | Design principles and patterns | SOLID, DRY, KISS, dependency injection, Factory, Strategy, Observer, Decorator, Repository | 12-15 h |
| 14 | Advanced C# and .NET internals | Reflection, attributes, `Span<T>`, `ArrayPool`, BenchmarkDotNet, JIT, AOT, GC generations, NuGet packaging | 12-15 h |
| 15 | Capstone projects | A: banking/library system. B: data processing tool. C: multi-project solution with DI and tests | 30-40 h |

### Module 1 lessons (current module)

| Lesson | Topic | Status |
|---|---|---|
| 1 | Program structure, types, variables, string interpolation | Done |
| 2 | Operators, type conversion, console input, `int.TryParse` | In progress |
| 3 | Conditions: `if`, `switch` | Next |
| 4 | Loops: `for`, `while`, `foreach`, `break`/`continue` | Planned |
| Exam | Module 1 exam (80/100 to pass) | Planned |

---

## 5. Capstone Projects (Module 15)

| Project | Focus | Skills used |
|---|---|---|
| **A**: Library or banking system | OOP and correctness | Classes, collections, exceptions, unit tests |
| **B**: Data processing tool | Real-world data flow | Files, JSON, LINQ, async |
| **C**: Multi-project solution | Professional structure | Class library, console app, xUnit tests, dependency injection |

Each capstone gets a **README, tests, and a code review**, and goes on GitHub for my portfolio.

---

## 6. After Module 15: Next Stages

| Stage | Topics |
|---|---|
| 2 | SQL Server and T-SQL, EF Core |
| 3 | ASP.NET Core Web API (HTTP launch profile, no HTTPS dev certificates) |
| 4 | Authentication, security, testing |
| 5 | Architecture |
| 6 | TypeScript and Angular |

Say **"start the next stage"** and I will propose a detailed plan.

---

## 7. Progress Tracker

```
PROGRESS TRACKER
Date: 2026-10-24
Current module / lesson: Module 1, Lesson 2 (operators, conversion, TryParse), not started yet
Completed modules: Module 0
Quiz and exam scores: Module 1 Lesson 1 quiz 2.5/4 first try, fixed in retake
Strong topics: integer division and casts, decimal vs double, reading CS errors, naming conventions (improving)
Weak topics (to review): changing a value vs changing a type (var), SDK vs runtime wording
Projects done (with GitHub links): HelloWorld, Module01 (Lesson 1 receipt printer)
Next steps: Lesson 2 exercises, quiz, mini-task (simple calculator)
Notes about my environment or problems: Arch (Omarchy), LazyVim + roslyn_ls, csharpier 1.3.0, netcoredbg via Mason (install to confirm), solution file CSharpCourse.slnx
```

Paste this at the start of every new session so the mentor knows where we stopped.

---

## 8. Study Habits

- Study **15 to 20 hours per week** and keep a steady rhythm.
- Type the code. Do not copy and paste.
- Read every compiler error before asking for help: file, line, code, text.
- Commit after every lesson.
- Keep one notes file per lesson (`notes/moduleXX_lessonYY_notes.md`).
- Use official docs: <https://learn.microsoft.com/dotnet/csharp/>
