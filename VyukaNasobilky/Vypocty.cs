
namespace VyukaNasobilky
{   // Třída pro reprezentaci jednoho příkladu násobilky, obsahuje dvě čísla a výsledek jejich násobení.
    class Vypocty(int prvniCislo, int druheCislo)
    {   // Konstruktor třídy Vypocty, který inicializuje dvě čísla a vypočítá jejich násobení.
        public int PrvniCislo { get; } = prvniCislo;
        public int DruheCislo { get; } = druheCislo;
        public int Vysledek => PrvniCislo * DruheCislo;

        /// <summary>
        /// Metoda ToString() pro formátování výstupu příkladu násobilky ve formátu "a × b = ".
        /// </summary>
        /// <returns>Řetězec ve formátu "a × b = "</returns>
        public override string ToString()
        {
            return $"{PrvniCislo} × {DruheCislo} = ";
        }

        // Metoda pro generování náhodného příkladu násobilky, která nastaví dvě čísla a vypočítá jejich násobení.
        /*public void GenerujPriklad()
        {
            Random random = new Random();
            PrvniCislo = random.Next(1, 10);
            DruheCislo = random.Next(1, 10);
            Vysledek = PrvniCislo * DruheCislo;
        }*/
    }
}
