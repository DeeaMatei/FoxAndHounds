using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoxAndHound.Classes.Implementations;
using FoxAndHound.Classes.Interfaces;

namespace FoxAndHound.Classes
{
    public class Layout
    {
        public Dictionary<Position, IPiece> Arrangement { get; set; }

        public Layout()
        {
            Arrangement = new Dictionary<Position, IPiece>();
        }
        public void MovePiece(Move move) 
        {
        }
        public void Initialize() 
        {
            Arrangement.Add(new Position(4, 7), new Fox());
            Arrangement.Add(new Position(1, 0), new Hound());
            Arrangement.Add(new Position(3, 0), new Hound());
            Arrangement.Add(new Position(5, 0), new Hound());
            Arrangement.Add(new Position(7, 0), new Hound());
        }
    }
}
