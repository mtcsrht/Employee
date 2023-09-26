using EmployeeOOP;

Solution solution = new Solution();
Console.WriteLine("1. feladat");
foreach (var item in solution.employees)
{
    item.DataOut();
}

Console.WriteLine("2. feladat atlag eletkor");
Console.WriteLine($"{solution.AverageAge():0.00}");

Console.WriteLine("3.feladat Budapesten elok: "); 
foreach (var item in solution.LivesInBudapest())
{
    Console.WriteLine(item.Name);
}

Console.WriteLine("4.feladat");
solution.OldestPerson().DataOut();

Console.WriteLine("5. feladat");
if (solution.OlderThanFifty() == "False")
{
    Console.WriteLine("Nincs 50 év feletti!");
}
else
{
    Console.WriteLine("Van 50 év feletti");
    foreach (var item in solution.OlderThanFifty().Split(';').Skip(1))
    {
        Console.WriteLine(item);
    }
}

Console.WriteLine("6. feladat");
foreach (var item in solution.YoungerThanThirty())
{
    item.DataOut();
}

Console.WriteLine("7. feladat");
Employee youngest;
Employee oldest;

if (solution.OldestAndYoungest(out youngest, out oldest))
{
    Console.WriteLine("Van több a legfiatalabból.");
    
}
else
{
    Console.WriteLine("Csak egy van a legfiatalabból.");
}

Console.Write("Legfialatabb: ");
youngest.DataOut();
Console.Write("Legidősebb: ");
oldest.DataOut();

Console.WriteLine("8. feladat");
var dict = solution.OverTwelveMillion();
if (dict.Count > 0)
{
    foreach (var item in solution.OverTwelveMillion())
    {
        Console.WriteLine($"Név: {item.Key} Fizetés: {item.Value}");
    }
}
else
{
    Console.WriteLine("nincs ilyen!");
}

Console.WriteLine($"Developer átlagfizetés: {solution.AveragePayment(solution.employees.Select(e => e).Where(e => e.Position == "Developer").ToList())}");

Console.WriteLine($"Férfi átlag fizetés: {solution.MaleAveragePayment():0.00}");
Console.WriteLine($"Női átlag fizetés: {solution.FamaleAveragePayment():0.00}");