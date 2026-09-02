# C# fundamentals

## Variables

```csharp
string name = "Awm";
int score = 82;
bool passed = score >= 50;
```

## Methods

```csharp
static double Average(double a, double b)
{
    return (a + b) / 2;
}
```

## Collections

```csharp
var names = new List<string> { "A", "B", "C" };
foreach (var name in names)
{
    Console.WriteLine(name);
}
```

## Classes

```csharp
class Student
{
    public string Name { get; set; } = "";
    public double Mark { get; set; }
}
```

## Practice idea

Build a console program that accepts several students, calculates an average, assigns grades, and prints the highest mark.
