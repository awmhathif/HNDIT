Console.WriteLine("Grade Calculator");
Console.Write("Student name: ");
var name = Console.ReadLine()?.Trim() ?? "Student";
Console.Write("Mark (0-100): ");

if (!double.TryParse(Console.ReadLine(), out var mark) || mark is < 0 or > 100)
{
    Console.WriteLine("Invalid mark.");
    return;
}

static string Grade(double mark) => mark switch
{
    >= 75 => "A",
    >= 65 => "B",
    >= 55 => "C",
    >= 40 => "S",
    _ => "F"
};

Console.WriteLine($"{name}: {mark:0.#}% → Grade {Grade(mark)}");
