using FoxAndHound.Classes.Interfaces;

namespace FoxAndHound.Classes
{
    public class PvpLocal : IGame
    {
        public Referee Referee { get; set; }
        public Status Outcome { get; set; }

        public PvpLocal(IBoard board)
        {
            Referee = new Referee(board);
        }

        public void Initialize()
        {
            Referee.Initialize();
        }

        public void Start()
        {
            Referee.StartGame();
        }
    }
}