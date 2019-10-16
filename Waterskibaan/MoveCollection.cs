using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Waterskibaan.Properties
{
    static class MoveCollection
    {
        private static List<IMoves> Moves = new List<IMoves>()
        {
            new Jump(),
            new EenBeen(),
            new EenHand(),
            new Omdraaien()
        };

        public static List<IMoves> GetWillekeurigeMoves()
        {
            List<IMoves> moves = new List<IMoves>();
            Random random = new Random();

            foreach (var move in Moves)
            {
                if (random.Next(0, 2) == 1)
                {
                    moves.Add(move);
                }
            }

            return moves;
        }
    }
}
