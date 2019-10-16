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
        public int AantalRondenNogTeGaan { get; set; }
        public Zwemvest Zwemvest { get; set; }
        public Skies Skies { get; set; }
        public Color KledingKleur { get; set; }
        public List<IMoves> Moves { get; set; }

        public Sporter(List<IMoves> moves)
        {
            AantalPunten = 0;
            Moves = moves;
            Random rnd = new Random();
            Color c = new Color
            {
                R = (byte)rnd.Next(0, 256),
                G = (byte)rnd.Next(0, 256),
                B = (byte)rnd.Next(0, 256),
                A = 255
            };
            KledingKleur = c;
        }

        public int Move()
        {
            throw new NotImplementedException();
        }
    }
}
