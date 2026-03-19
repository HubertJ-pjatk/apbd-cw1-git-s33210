Console.WriteLine("Witaj w programie statystycznym!");
Console.WriteLine("Podaj liczby po przecinku:");
string input = Console.ReadLine();

if (string.IsNullOrWhiteSpace(input))
{
    Console.WriteLine("Błąd: Nie podano żadnych danych!");
    return;
}

Helper.WypiszLiczby(input);