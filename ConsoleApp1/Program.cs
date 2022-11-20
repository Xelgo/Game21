
enum Color
{
    Diamonds = 1,
    Hearts,
    Clubs,
    Spades,
}
enum Rank
{
    Ace = 1,
    Jack,
    Queen,
    King,
    Ten,
    Nine,
    eight,
    seven,
    six,
}

class Card

{
    public Color color { get;}
    public Rank rank {get;}

    public Card(Color color, Rank rank)
    {
        this.color = color;
        this.rank = rank;
    }
}

class Cards
{
    private List<Card> cards;

    public List<Card>  GetCards()
    {
        return cards;
    }
    public Cards()
    {
        cards = new List<Card>();
        this.ReturnAllCards();
    }
    public void Reshaffle(int Coint = 1)
    {
        

        Random random = new Random();
        for (int j = 0; j < Coint; j++)
        {
            //Console.WriteLine("Reshaffle cards");

            for (int i = 0; i < cards.Count; i++)
            {
                var temp = cards[i];
                var NextIndex = random.Next(0, cards.Count);
                cards[i] = cards[NextIndex];
                cards[NextIndex] = temp;
            }
        }
    }

    public Card? GetCard()
    {
        if(cards.Count == 0) 
            return null;

        var card = cards[cards.Count - 1];
        cards.RemoveAt(cards.Count - 1);
        return card;
    }

    public void ReturnAllCards()
    {
        cards.Clear();
        foreach (Color color in Enum.GetValues(typeof(Color)))
        {
           foreach (Rank rank in Enum.GetValues(typeof(Rank)))
            {
                cards.Add(new Card(color, rank));
            }
        }
        this.Reshaffle(5);
    }
}

class Player
{

    private string _name;
    private int _points;
    private bool _active;
    private bool _AI;



    public Player(string? name, bool AI)
    {
        _name = name ?? "????";
        _AI = AI;
        _points = 0;
        _active = true;
    }
}





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