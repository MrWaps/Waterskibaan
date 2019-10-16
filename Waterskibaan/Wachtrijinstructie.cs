using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Waterskibaan
{
    class Wachtrijinstructie : Wachtrij
    {

        public override int MAX_LENGTE_RIJ
        {
            get { return 100; }
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
