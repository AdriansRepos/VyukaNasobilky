using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VyukaNasobilky
{
    class Vypocty(int prvniCislo, int druheCislo)
    {
        public int PrvniCislo { get; } = prvniCislo;
        public int DruheCislo { get; } = druheCislo;
        public int Vysledek => PrvniCislo * DruheCislo;

        public override string ToString()
        {
            return $"{PrvniCislo} × {DruheCislo} = ";
        }               

        public void KontrolaOdpovedi(int odpoved)
        {
            if (odpoved == Vysledek)
            {
                Console.WriteLine("Správně!");
            }
            else
            {
                Console.WriteLine($"Špatně! Správná odpověď je {Vysledek}.");
            }
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
