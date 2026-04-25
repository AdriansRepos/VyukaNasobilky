
namespace VyukaNasobilky
{
    class Vypocty
    {
        public int PrvniCislo { get; }
        public int DruheCislo { get; }
        public int Vysledek => PrvniCislo * DruheCislo;

        public Vypocty(int prvniCislo, int druheCislo)
        {
            PrvniCislo = prvniCislo;
            DruheCislo = druheCislo;
        }

        public override string ToString()
        {
            return $"{PrvniCislo} × {DruheCislo} = ";
        }    

    /*public void GenerujPriklad()
    {
        Random random = new Random();
        PrvniCislo = random.Next(1, 10);
        DruheCislo = random.Next(1, 10);
        Vysledek = PrvniCislo * DruheCislo;
    }*/
    }
}
