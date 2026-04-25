using VyukaNasobilky;

while (true)
{
    Console.WriteLine("=== HLAVNÍ MENU ===");
    Console.WriteLine("1. Malá násobilka (1–10)");
    Console.WriteLine("2. Velká násobilka (11–20)");
    Console.WriteLine("3. Konec programu");
    Console.Write("Vyber možnost: ");

    char volba = Console.ReadKey().KeyChar;
    Console.WriteLine();

    switch (volba)
    {
        case '1':
            Podmenu("Malá násobilka", GeneratorPrikladu.GenerujMalouNasobilku, () => GeneratorPrikladu.GenerujNahodnouMalou());
            break;

        case '2':
            Podmenu("Velká násobilka", GeneratorPrikladu.GenerujVelkouNasobilku, () => GeneratorPrikladu.GenerujNahodnouVelkou());
            break;

        case '3':
            return;

        default:
            Console.WriteLine("Neplatná volba.");
            Console.ReadKey();
            break;
    }
}


// ============================
// PODMENU
// ============================
static void Podmenu(string nazev, Func<IEnumerable<Vypocty>> tabulkove, Func<IEnumerable<Vypocty>> nahodne)
{
    while (true)
    {
        Console.WriteLine($"=== {nazev} ===");
        Console.WriteLine("1. Příklady podle tabulek");
        Console.WriteLine("2. Náhodné příklady");
        Console.WriteLine("0. Návrat do hlavního menu");
        Console.Write("Vyber možnost: ");

        char volba = Console.ReadKey().KeyChar;
        Console.WriteLine();

        switch (volba)
        {
            case '1':
                ZpracujPriklady(tabulkove());
                break;

            case '2':
                ZpracujPriklady(nahodne());
                break;

            case '0':
                return;

            default:
                Console.WriteLine("Neplatná volba.");
                Console.ReadKey();
                break;
        }
    }
}


// ============================
// JEDNOTNÉ ZPRACOVÁNÍ PŘÍKLADŮ
// ============================
static void ZpracujPriklady(IEnumerable<Vypocty> priklady)
{
    foreach (var p in priklady)
    {
        if (!ZpracujPriklad(p.PrvniCislo, p.DruheCislo))
            return;
    }

    Console.WriteLine("Hotovo! Stiskni libovolnou klávesu...");
    Console.ReadKey();
}


// ============================
// ZPRACOVÁNÍ JEDNOHO PŘÍKLADU
// ============================
static bool ZpracujPriklad(int a, int b)
{
    Console.Write($"{a} × {b} = ");

    string? vstup = Console.ReadLine()?.Trim();

    if (vstup == "0")
        return false;

    if (!int.TryParse(vstup, out int odpoved))
    {
        Console.WriteLine("Neplatný vstup.");
        return true;
    }

    if (odpoved == a * b)
        Console.WriteLine("Správně!");
    else
        Console.WriteLine($"Špatně! Správná odpověď je {a * b}");

    return true;
}
