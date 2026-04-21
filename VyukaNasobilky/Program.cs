using VyukaNasobilky;

var generator = new GeneratorPrikladu();

while (true)
{    
    Console.WriteLine("=== HLAVNÍ MENU ===");
    Console.WriteLine("1. Malá násobilka (1–10)");
    Console.WriteLine("2. Velká násobilka (1–20)");
    Console.WriteLine("3. Konec programu");
    Console.Write("Vyber možnost: ");

    char volba = Console.ReadKey().KeyChar;
    Console.WriteLine();

    switch (volba)
    {
        case '1':
            Podmenu(generator, 1, 10);
            break;

        case '2':
            Podmenu(generator, 1, 20);
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
    static void Podmenu(GeneratorPrikladu generator, int min, int max)
{
    while (true)
    {        
        Console.WriteLine($"=== NÁSOBILKA {min}–{max} ===");
        Console.WriteLine("1. Příklady podle tabulek");
        Console.WriteLine("2. Náhodné příklady");
        Console.WriteLine("0. Návrat do hlavního menu");
        Console.Write("Vyber možnost: ");

        char volba = Console.ReadKey().KeyChar;
        Console.WriteLine();

        switch (volba)
        {
            case '1':
                PrikladyTabulkove(generator, min, max);
                break;

            case '2':
                PrikladyNahodne(generator, min, max);
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
// TABULKOVÉ PŘÍKLADY
// ============================
static void PrikladyTabulkove(GeneratorPrikladu generator, int min, int max)
{
    foreach (var priklad in generator.GenerujNasobilku(min, max))
    {
        if (!ZpracujPriklad(priklad.PrvniCislo, priklad.DruheCislo))
            return; // návrat do hlavního menu
    }

    Console.WriteLine("Hotovo! Stiskni libovolnou klávesu...");
    Console.ReadKey();
}


// ============================
// NÁHODNÉ PŘÍKLADY
// ============================
static void PrikladyNahodne(GeneratorPrikladu generator, int min, int max)
{
    while (true)
    {
        var priklad = generator.GenerujNahodnyPriklad(min, max);

        if (!ZpracujPriklad(priklad.PrvniCislo, priklad.DruheCislo))
            return; // návrat do hlavního menu
    }
}


// ============================
// ZPRACOVÁNÍ JEDNOHO PŘÍKLADU
// ============================
static bool ZpracujPriklad(int a, int b)
{
    Console.Write($"{a} × {b} = ");  // výsledek se píše na stejný řádek

    string? vstup = Console.ReadLine()?.Trim();

    // 0 = návrat do hlavního menu
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


