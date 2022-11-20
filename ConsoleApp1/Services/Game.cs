using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game21.Models;

namespace Game21.Services
{
    internal class Game

    {
   

        public static void StartGame()
        {
            Random random = new Random();

            var cards = new Cards();



            var players = new List<Player>();

            Console.WriteLine("Your Name?");
            Player player = new Player(Console.ReadLine(), false);
            players.Add(player);
            InitPlayer(ref players, random);
            InitBots(ref players, random);

            var res = 0;

            {



            }


        }



        static void InitBots(ref List<Player> players, Random random)
        {

            string[] randmomyName = { "Alex", "Victor", "Kostya", "Petya", "Joo", "Li", "Garry", "Vertu", "Osya" };



            Console.WriteLine("How many bots play in game?");
            int countBots = int.Parse((Console.ReadLine() ?? "3"));
            for (int i = 0; i < countBots; i++)
                players.Add(new Player(randmomyName[random.Next(0, randmomyName.Length)], true));
        }
        static void InitPlayer(ref List<Player> players)
        {

        }
    }
}



