using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamRandomizer.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Saisir le nombre de joueurs par équipe: ");
            var teamSize = int.Parse(System.Console.ReadLine());

            IList<string> players = new List<string>();
            System.Console.WriteLine("Saisir les joueurs et terminer par une ligne vide");

            var player = System.Console.ReadLine();
            while (!String.IsNullOrEmpty(player))
            {
                players.Add(player);
                player = System.Console.ReadLine();
            }

            var teamRandomizer = new TeamRandomizer(teamSize);
            var teams = teamRandomizer.Build(players);

            foreach (var team in teams)
            {
                System.Console.WriteLine("Team " + team.Name);
                foreach (var teamPlayer in team.Players)
                {
                    System.Console.WriteLine(teamPlayer);
                }
                System.Console.WriteLine("------------------");
                System.Console.WriteLine();
            }

            System.Console.Write("Appuyer sur une touche pour quitter.");
            System.Console.ReadKey();
        }
    }
}
