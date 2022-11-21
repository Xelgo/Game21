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
           
            cards.Reshaffle();

            InitPlayers(ref players);
    
            var ActivePlayers = new List<Player>(players);

            while (ActivePlayers.Count > 0)
            {
                PlayRound(ref ActivePlayers, cards);
                DeactivatePlayers(ref ActivePlayers);
            }

            EndGame(ref players);



        }

        static void PlayRound(ref List<Player> players, Cards cards)
        {
            for (int i = 0; i < players.Count; i++)
            {
                
                if(players[i]._AI)
                {   
                    Console.WriteLine($"Ходит компьютер с именем:  {players[i]._name}");
                    var card = cards.GetCard();
                   

                }
                else
                {
                    PlayersPlay(players[i], cards);
                }

                
            }

        }
        static void PlayersPlay(Player player, Cards cards)
        {
            Console.WriteLine($"Ходит игрок с именем:  {player._name}");
            Console.WriteLine($"У вас сейчас очков:   {player._points}");
            Console.WriteLine("Будете брать ещё одну карту? y - yes. n - no");
            
            var res = Console.ReadLine();

            while (true)
            {
                if (res == "y") { player.TakeCard(cards.GetCard());  break; }
                


                else if(res == "n") { player.Opening();  break; }
                
                else 
                {   
                    Console.WriteLine("Не понял вас. y - да, n - нет");
                    res = Console.ReadLine();

                }
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
        static void InitPlayers(ref List<Player> players)
        {

            Console.WriteLine("How many players will be play in game?");
            int countPlayers = int.Parse((Console.ReadLine() ?? "1"));

            for (int i = 1; i < countPlayers + 1; i++)
            { 
            Console.WriteLine($"Insert name player #{i}?");
            Player player = new Player(Console.ReadLine(), false);
            players.Add(player);
            }

        }

        static void DeactivatePlayers(ref List<Player> ActivePlayers)
        {

            for (int i = 0; i < ActivePlayers.Count; i++)
            {
                if (ActivePlayers[i]._active == false)
                {
                    ActivePlayers.Remove(ActivePlayers[i]);
                    i--;
                }
            }
        }

        static void EndGame(ref List<Player> players)
        {

            Player? Winner = null;

            foreach (var player in players)
            {
                if (player._points > 21)
                {
                    Console.WriteLine($"Игрок с именем проиграл, он набрал больше 21, его счёт: {player._points}");
                    continue;
                }

                if ((Winner?._points ?? 0) < player._points)
                {
                    Winner = player;
                }
                else if ((Winner?._points ?? 0) > 0 && Winner?._points == player._points)
                {
                    Console.WriteLine("Ничья!");
                    break;
                }
            }

            if (Winner != null)
            {
                Console.WriteLine($"Winner {Winner._name}");
            }
            else
            {
                Console.WriteLine("В этот раз без победителя :(");
            }

        }
    }
}



