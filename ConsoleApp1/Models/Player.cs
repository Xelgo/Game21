namespace Game21.Models
{
    internal class Player
    {
        
        
     
        public bool _active { get; set; }

        public int _points { get; set; } // Спросить у брата почему,
                                         // когда отсутствует set нельзя в
                                         // методе класса всё таки поменять переменную

        public bool _AI { get; }
        public string _name { get;}

        public Player(string? name, bool AI)
        {
            _name = name ?? "????";
            _AI = AI;
            _points = 0;
            
            _active = true;
        }

        public void TakeCard(Card? card)
        {
            Console.WriteLine();
            Console.WriteLine($"Вы взяли карту и она даёт вам очков: {card?.Point}");
            _points = _points + (card?.Point ?? 0);

            Console.WriteLine($"Сейчас у вас очков: {_points}");
            Console.WriteLine();
            _active =  (_points < 21);



            

        }

        public void Opening()
        {
            _active = false;
            Console.WriteLine($"Счет у игрока {this._name} - {this._points}");
            if(_points > 21)
            {
                Console.WriteLine("Игрок проиграл"); 
            }
        }
    }
}
