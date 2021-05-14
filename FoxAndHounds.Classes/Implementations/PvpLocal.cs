using FoxAndHound.Classes.Interfaces;

namespace FoxAndHound.Classes
{
    public class PvpLocal : IGame
    {
        public Referee Referee { get; set; }
        public Status Outcome { get; set; }

        public PvpLocal()
        {
            
        }

        public void Initialize(IBoard board)
        {
            Referee = new Referee(board);
            Referee.Initialize();
        }

        public void Start()
        {
            Referee.StartGame();
        }
    }
}