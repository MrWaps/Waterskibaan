﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Waterskibaan
{
    class Wachtrijinstructie : IWachtrij
    {
        public int MAX_LENGTE_RIJ = 100;
        public List<Sporter> GetAlleSporters()
        {
            throw new NotImplementedException();
        }

        public void SporterNeemPlaatsInRij(Sporter sporter)
        {
            throw new NotImplementedException();
        }

        public List<Sporter> SportersVerlatenRij(int aantal)
        {
            throw new NotImplementedException();
        }
    }
}