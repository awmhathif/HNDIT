var expenses = new List<(string Name, decimal Amount)>();
Console.WriteLine("Simple Expense Tracker");
Console.WriteLine("Enter an empty name to finish.\n");

while (true)
{
    Console.Write("Expense: ");
    var name = Console.ReadLine()?.Trim();
    if (string.IsNullOrWhiteSpace(name)) break;

    Console.Write("Amount: ");
    if (!decimal.TryParse(Console.ReadLine(), out var amount) || amount < 0)
    {
        Console.WriteLine("Invalid amount.\n");
        continue;
    }
    expenses.Add((name, amount));
}

Console.WriteLine("\nSummary");
foreach (var item in expenses)
    Console.WriteLine($"- {item.Name}: {item.Amount:C}");

var total = expenses.Sum(x => x.Amount);
Console.WriteLine($"Total: {total:C}");
Console.WriteLine($"Average: {(expenses.Count == 0 ? 0 : total / expenses.Count):C}");
