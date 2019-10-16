using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Waterskibaan
{
    abstract class Wachtrij
    {
        private Queue<Sporter> _sporters = new Queue<Sporter>();

        public abstract int MAX_LENGTE_RIJ { get; }
        public List<Sporter> GetAlleSporters()
        {

            return _sporters.ToList();
        }

        public void SporterNeemPlaatsInRij(Sporter sporter)
        {
            if (_sporters.Count < MAX_LENGTE_RIJ)
            {
                _sporters.Enqueue(sporter);
            }
        }

        public List<Sporter> SportersVerlatenRij(int aantal)
        {
            List<Sporter> sporters = new List<Sporter>();
            for (int i = 0; i < aantal; i++)
            {
                if (_sporters.Count > 0)
                {
                    sporters.Add(_sporters.Dequeue());
                }
            }
            return sporters;
        }
    }
}
