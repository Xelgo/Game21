namespace Game21.Models
{
    internal class Player
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
}
