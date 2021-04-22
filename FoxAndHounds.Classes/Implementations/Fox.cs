using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoxAndHound.Classes.Interfaces;

namespace FoxAndHound.Classes.Implementations
{
    public class Fox : IPiece
    {
        public List<Position> GetAvailableMoves(Position currentPosition, Layout currentLayout)
        {
            throw new NotImplementedException();
        }

        public Bitmap GetImage()
        {
            Bitmap bitmap = new Bitmap(Resources.fox);
            return bitmap;
        }
    }
}
