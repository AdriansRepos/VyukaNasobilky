
namespace VyukaNasobilky
{
    class GeneratorPrikladu
    {
        private const int MalaMin = 1;
        private const int MalaMax = 10;

        private const int VelkaMin = 11;
        private const int VelkaMax = 20;

        private static readonly Random rnd = new();

        // ============================
        // MALÁ – TABULKOVÁ
        // ============================
        public static IEnumerable<Vypocty> GenerujMalouNasobilku()
        {
            for (int a = MalaMin; a <= MalaMax; a++)
                for (int b = MalaMin; b <= MalaMax; b++)
                    yield return new Vypocty(a, b);
        }

        // ============================
        // MALÁ – NÁHODNÁ
        // ============================
        public static IEnumerable<Vypocty> GenerujNahodnouMalou()
        {
            while (true)
            {
                int a = rnd.Next(MalaMin, MalaMax + 1);
                int b = rnd.Next(MalaMin, MalaMax + 1);
                yield return new Vypocty(a, b);
            }
        }

        // ============================
        // VELKÁ – TABULKOVÁ
        // ============================
        public static IEnumerable<Vypocty> GenerujVelkouNasobilku()
        {
            for (int a = VelkaMin; a <= VelkaMax; a++)
                for (int b = VelkaMin; b <= VelkaMax; b++)
                    yield return new Vypocty(a, b);
        }

        // ============================
        // VELKÁ – NÁHODNÁ
        // ============================
        public static IEnumerable<Vypocty> GenerujNahodnouVelkou()
        {
            while (true)
            {
                int a = rnd.Next(VelkaMin, VelkaMax + 1);
                int b = rnd.Next(VelkaMin, VelkaMax + 1);
                yield return new Vypocty(a, b);
            }
        }
    }

}
