using Game21.Models;

class Program
{
    static void Main(string[] Args)
    {

        var cards = new Cards();
        InitGame(out var players);



        for (int i = 0; i < 150; i++)
        {
            var c = cards.GetCard();
            if (c == null)
            {
                Console.WriteLine("Колода закончилась");
                cards.ReturnAllCards();
                c = cards.GetCard();


            }
            Console.WriteLine($"Rank: {c?.rank}\t Color: {c?.color}");
        }



        /*
        List<Player> players = null;
        InitGame(out players);
        */
    }


    static void InitGame(out List<Player> players)
    {
        players = new List<Player>();

        Console.WriteLine("Your Name?");
        Player player = new Player(Console.ReadLine(), false);
        players.Add(player);

        InitBots(ref players);
    }
    static void InitBots(ref List<Player> players)
    {

        Console.WriteLine("How many bots play in game?");
        int countBots = int.Parse((Console.ReadLine() ?? "3"));

        for (int i = 0; i < countBots; i++)
            players.Add(new Player(Console.ReadLine(), true));
    }

}

