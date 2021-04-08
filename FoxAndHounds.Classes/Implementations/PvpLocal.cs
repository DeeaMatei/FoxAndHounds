using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoxAndHound.Classes
{
    public class PvpLocal : IGame
    {
        public Referee Referee { get; set; }
        public Player CurrentMovingPlayer { get; set; }
        public Status Outcome { get; set; }

        public void Initialize()
        {
        }

        public void Start()
        {
        }
    }
}
