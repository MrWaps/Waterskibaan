using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Waterskibaan
{
    class WaterskibaanProgram
    {
        public LijnenVoorraad LijnenVoorraad = new LijnenVoorraad();
        public Kabel Kabel = new Kabel();

        public WaterskibaanProgram()
        {
            for (int i = 0; i < 15; i++)
            {
                LijnenVoorraad.LijnToevoegenAanRij(new Lijn());
            }
        }
        public void VerplaatsKabel()
        {
            Kabel.VerschuifLijnen();
            LijnenVoorraad.LijnToevoegenAanRij(Kabel.VerwijderLijnVanKabel());
        }

        public void SporterStart (Sporter sp)
        {
            Random rnd = new Random();

            Kabel.NeemLijnInGebruik(LijnenVoorraad.VerwijderEersteLijn());
            Kabel.Lijnen.First.Value.Sporter = sp;
            int RondenTeGaan = rnd.Next(1, 3);
            sp.AantalRondenNogTeGaan = RondenTeGaan;Console.WriteLine($"[SporterStart] Aantal ronden te gaan: {RondenTeGaan}");

            if (sp.Skies == null || sp.Zwemvest == null)
            {
                Exception e = new Exception();
                throw e;
            }
        }
    }
}
