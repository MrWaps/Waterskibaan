﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Waterskibaan
{
    class LijnenVoorraad
    {
        private Queue<Lijn> _lijnen = new Queue<Lijn>();

        public void LijnToevoegenAanRij(Lijn lijn)
        {
            _lijnen.Enqueue(lijn);
        }

        public Lijn VerwijderEersteLijn()
        {
            if (_lijnen.Count > 0)
            {
                return _lijnen.Dequeue();
            } else
            {
                return null;
            }
        }

        public int GetAantalLijnen()
        {
            return _lijnen.Count;
        }

        public string ToString()
        {
            return $"{_lijnen.Count} lijnen op voorraad";
        }
    }
}
