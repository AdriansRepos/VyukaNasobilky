using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VyukaNasobilky
{
    class GeneratorPrikladu
    {
        // ============================
        // TABULKOVÁ NÁSOBILKA
        // ============================
        public IEnumerable<Vypocty> GenerujNasobilku(int min, int max)
        {
            for (int a = min; a <= max; a++)
            {
                for (int b = min; b <= max; b++)
                {
                    yield return new Vypocty(a, b);
                }
            }
        }

        // ============================
        // NÁHODNÉ PŘÍKLADY
        // ============================
        public Vypocty GenerujNahodnyPriklad(int min, int max)
        {
            Random rnd = new();
            int a = rnd.Next(min, max + 1);
            int b = rnd.Next(min, max + 1);
            return new Vypocty(a, b);
        }
    }

}
