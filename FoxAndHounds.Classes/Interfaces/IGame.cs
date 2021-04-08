using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoxAndHound.Classes
{
    public interface IGame
    {
        Referee Referee { get; set; }
        Player CurrentMovingPlayer { get; set; }
        Status Outcome { get; set; }

        void Initialize();
        void Start();

    }
}
