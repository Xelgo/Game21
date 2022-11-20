namespace Game21.Models
{
    internal class Card
    {
        public Color color { get; }
        public Rank rank { get; }

        public Card(Color color, Rank rank)
        {
            this.color = color;
            this.rank = rank;
        }
    }
}
