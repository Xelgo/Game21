namespace Game21.Models
{
    internal class Card
    {
        public Color color { get; }
        public Rank rank { get; }
        public int Point { get; }
        public Card(Color color, Rank rank)
        {
            this.color = color;
            this.rank = rank;

            switch (rank)
            {
                case Rank.Two:
                    Point = 2;
                    break;
                case Rank.Free:
                    Point = 3;
                    break;
                case Rank.Four:
                    Point = 4;
                    break;
                case Rank.five:
                    Point = 5;
                    break;
                case Rank.six:
                    Point = 6;
                    break;
                case Rank.seven:
                    Point = 7;
                    break;
                case Rank.eight:
                    Point = 8;
                    break;
                case Rank.Nine:
                    Point = 9;
                    break;
                case Rank.Ten:
                    Point = 10;
                    break;
                case Rank.Jack:
                    Point = 2;
                    break;
                case Rank.Queen:
                    Point = 3;
                    break;
                case Rank.King:
                    Point = 4;
                    break;
                case Rank.Ace:
                    Point = 0;
                    break;
                default:
                    break;
            }



        }
    }
}
