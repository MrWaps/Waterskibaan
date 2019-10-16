using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace Waterskibaan
{
    class Game
    {
        public WaterskibaanProgram Waterskibaan = new WaterskibaanProgram();
        
        public Wachtrijinstructie Wachtrijinstructie = new Wachtrijinstructie();
        public InstructieGroep InstructieGroep = new InstructieGroep();
        public WachtrijStarten WachtrijStarten = new WachtrijStarten();

        public List<IMoves> moves = new List<IMoves>();

        public void Initialize()
        {
            Sporter sp = new Sporter(moves)
            {
                Zwemvest = new Zwemvest(),
                Skies = new Skies(),
            };
            Console.WriteLine("Sporter gemaakt");
            Waterskibaan.SporterStart(sp);
            Console.WriteLine("Sporter teogevoegd");
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = new TimeSpan(0, 0, 1);
            timer.Tick += new EventHandler(dispatcher_Tick);
            timer.Start();
            Console.WriteLine("Timer gestart");
        }

        private void dispatcher_Tick(object sender, EventArgs e)
        {
            Waterskibaan.VerplaatsKabel();
            Waterskibaan.ToString();
            Console.WriteLine("Kabel verplaatst en geprint");
        }
    }
}
