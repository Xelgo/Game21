namespace Game21.Models
{
    internal class Cards
    {
        private List<Card> cards;

        public List<Card> GetCards()
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
            if (cards.Count == 0)
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
}
