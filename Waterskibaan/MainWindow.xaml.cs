using System;
using System.Windows;
using Waterskibaan.Properties;

namespace Waterskibaan
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            TestOpdracht8();
        }

        static void TestOpdracht8()
        {
            Sporter sporter1 = new Sporter(MoveCollection.GetWillekeurigeMoves());
            Sporter sporter2 = new Sporter(MoveCollection.GetWillekeurigeMoves())
            {
                Zwemvest = new Zwemvest(),
                Skies = new Skies()
            };
            WaterskibaanProgram waterskibaan = new WaterskibaanProgram();


            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Opdracht 8:");
            Console.ResetColor();

            foreach (Sporter s in new Sporter[] { sporter1, sporter2 })
            {
                try
                {
                    waterskibaan.SporterStart(s);
                }
                catch (Exception)
                {
                    Console.WriteLine("Geen Zwemvest of Skies");
                }
            }

            Console.WriteLine("");

        }
    }
}
