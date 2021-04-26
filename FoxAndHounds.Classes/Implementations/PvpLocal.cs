using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoxAndHound.Classes.Interfaces;

namespace FoxAndHound.Classes
{
    public class PvpLocal : IGame
    {
        public Referee Referee { get; set; }
        public Player CurrentMovingPlayer { get; set; }
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
            Referee.StartGame(CurrentMovingPlayer);
        }
    }
}
