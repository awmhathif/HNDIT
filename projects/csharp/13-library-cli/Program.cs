var books = new List<Book>
{
    new("Clean Code", "Robert C. Martin"),
    new("The Pragmatic Programmer", "Andrew Hunt & David Thomas"),
    new("Eloquent JavaScript", "Marijn Haverbeke")
};

while (true)
{
    Console.WriteLine("\n1. List  2. Add  3. Search  0. Exit");
    Console.Write("Choose: ");
    switch (Console.ReadLine())
    {
        case "1":
            books.ForEach((b) => Console.WriteLine($"- {b.Title} — {b.Author}"));
            break;
        case "2":
            Console.Write("Title: "); var title = Console.ReadLine()?.Trim() ?? "";
            Console.Write("Author: "); var author = Console.ReadLine()?.Trim() ?? "";
            if (title.Length > 0) books.Add(new(title, author));
            break;
        case "3":
            Console.Write("Search: "); var q = (Console.ReadLine() ?? "").Trim();
            var found = books.Where(b => b.Title.Contains(q, StringComparison.OrdinalIgnoreCase) || b.Author.Contains(q, StringComparison.OrdinalIgnoreCase));
            foreach (var b in found) Console.WriteLine($"- {b.Title} — {b.Author}");
            break;
        case "0": return;
    }
}

record Book(string Title, string Author);
