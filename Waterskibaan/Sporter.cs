using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Waterskibaan
{
    class Sporter : IMoves
    {
        public int AantalPunten { get; set; }
        public int AantalRondenNogTeGaan { get
            {
                return 0;
            }
            set
            {
                
            }
        }

        public Zwemvest Zwemvest { get; set; }
        public Skies Skies { get; set; }
        public Color KledingKleur { get; set; }
        public List<IMoves> Moves { get; set; }

        public Sporter(List<IMoves> moves)
        {
            AantalPunten = 0;
            Moves = moves;
        }

        public int Move()
        {
            throw new NotImplementedException();
        }
    }
}
