using System;
using System.Collections.Generic;
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
            // TestOpdracht8();
            // TestOpdracht10();
            TestOpdracht11();
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

        static void TestOpdracht10()
        {
            Wachtrijinstructie wachtrijInstructie = new Wachtrijinstructie();
            InstructieGroep instructieGroep = new InstructieGroep();
            WachtrijStarten wachtrijStarten = new WachtrijStarten();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Opdracht 10:");
            Console.ResetColor();

            for (int i = 0; i < 100; i++)
            {
                wachtrijInstructie.SporterNeemPlaatsInRij(new Sporter(MoveCollection.GetWillekeurigeMoves()));
            }

            Console.WriteLine($"{wachtrijInstructie.ToString()}: {wachtrijInstructie.GetAlleSporters().Count}");

            List<Sporter> sporters = wachtrijInstructie.SportersVerlatenRij(5);

            foreach (Sporter sporter in sporters)
            {
                instructieGroep.SporterNeemPlaatsInRij(sporter);
            }

            Console.WriteLine($"{instructieGroep.ToString()}: {instructieGroep.GetAlleSporters().Count}\n");
        }

        static void TestOpdracht11()
        {
            Game game = new Game();
            Console.WriteLine("Game gemaakt");
            game.Initialize();
            Console.WriteLine("Game geïnitialiseerd");
        }
    }
}
