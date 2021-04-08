using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoxAndHound.Classes.Interfaces;

namespace FoxAndHound.Classes
{
    public class Layout
    {
        public Dictionary<Position, IPiece> Arrangement { get; set; }

        public void MovePiece(Move move) 
        {
        }
        public void Initialize() 
        {
        }
    }
}
