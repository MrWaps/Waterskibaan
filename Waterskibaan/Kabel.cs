using System.Collections.Generic;

namespace Waterskibaan
{
    class Kabel
    {
        private LinkedList<Lijn> _lijnen;

        public bool IsStartPositieLeeg()
        {
            if (_lijnen.First == null)
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
            if (_lijnen.First == null)
            {
                _lijnen.AddFirst(lijn);
            }
        }

        public void VerschuifLijnen()
        {
            foreach (Lijn l in _lijnen)
            {
                if (l.PositieOpDeKabel == 9)
                {
                    _lijnen.Last.Value.Sporter.AantalRondenNogTeGaan--;
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
            if (_lijnen.Last.Value != null && _lijnen.Last.Value.Sporter.AantalRondenNogTeGaan == 1)
            {
                return _lijnen.Last.Value;
            } else
            {
                return null;
            }
        }

        public string ToString()
        {
            int[] lijnen = new int[9];
            int i = 0;
            string String = "";
            foreach (Lijn l in _lijnen)
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
