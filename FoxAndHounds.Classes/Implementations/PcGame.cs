using System;
using FoxAndHound.Classes.Interfaces;

namespace FoxAndHound.Classes.Implementations
{
    public class PcGame : IGame
    {
        public Referee Referee { get; set; }
        public Player CurrentMovingPlayer { get; set; }
        public Status Outcome { get; set; }

        public void Initialize(IBoard board)
        {
            throw new NotImplementedException();
        }

        public void Start()
        {
            throw new NotImplementedException();
        }
    }
}