using System.Collections.Generic;
using System;

namespace Waterskibaan
{
    class Kabel
    {
        public LinkedList<Lijn> Lijnen = new LinkedList<Lijn>();

        public bool IsStartPositieLeeg()
        {
            Console.WriteLine("Eerste positie leeg check");
            if (Lijnen.First == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void NeemLijnInGebruik(Lijn lijn)
        {
            Console.WriteLine("Neem lijn in gebruik check");
            if (IsStartPositieLeeg() && lijn != null)
            {
                Lijnen?.AddFirst(lijn);
                Console.WriteLine("Neem lijn in gebruik");
            }
        }

        public void VerschuifLijnen()
        {
            foreach (Lijn l in Lijnen)
            {
                if (l.PositieOpDeKabel == 9)
                {
                    Lijnen.Last.Value.Sporter.AantalRondenNogTeGaan--;
                    Console.WriteLine($"[VerschuifLijnen] Aantal ronden te gaan: {Lijnen.Last.Value.Sporter.AantalRondenNogTeGaan}");
                    if (Lijnen.Last.Value.Sporter.AantalRondenNogTeGaan == 0)
                    {
                        VerwijderLijnVanKabel();
                    }
                    l.PositieOpDeKabel = 0;
                }
                else
                {
                    l.PositieOpDeKabel++;
                }
            }
        }

        public Lijn VerwijderLijnVanKabel()
        {
            if (Lijnen.Count > 0 && Lijnen.Last.Value.PositieOpDeKabel == 9 && (Lijnen.Last.Value.Sporter == null || Lijnen.Last.Value.Sporter.AantalRondenNogTeGaan == 0))
            {
                Console.WriteLine("Lijn verwijderd van kabel");
                return Lijnen.Last.Value;
            }
            else
            {
                return null;
            }
        }

        public string ToString()
        {
            int[] lijnen = new int[9];
            int i = 0;
            string String = "";
            foreach (Lijn l in Lijnen)
            {
                if (l.PositieOpDeKabel != null)
                {
                    lijnen[i] = l.PositieOpDeKabel;
                }
            }
            foreach (int g in lijnen)
            {
                String += ($"{g} | ");
            }
            return String;
        }
    }
}
