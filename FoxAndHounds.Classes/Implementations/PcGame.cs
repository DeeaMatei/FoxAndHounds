using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoxAndHound.Classes.Implementations
{
    public class PcGame : IGame
    {
        public Referee Referee { get; set; }
        public Player CurrentMovingPlayer { get; set; }
        public Status Outcome { get; set; }

        public void Initialize()
        {
            throw new NotImplementedException();
        }

        public void Start()
        {
            throw new NotImplementedException();
        }
    }
}
