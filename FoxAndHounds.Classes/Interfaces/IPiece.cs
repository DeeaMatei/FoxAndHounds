using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoxAndHound.Classes.Interfaces
{
    public interface IPiece
    {
        Bitmap GetImage();
        List<Position> GetAvailableMoves(Position currentPosition, Layout currentLayout);
    }
}
