using System;
using FoxAndHound.Classes.Interfaces;

namespace FoxAndHound.Classes.Implementations
{
    public class LanGame : IGame
    {
        public Referee Referee { get; set; }
        public Status Outcome { get; set; }

        public LanGame()
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