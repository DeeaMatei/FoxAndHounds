using System.Collections.Generic;
using System.Drawing;

namespace FoxAndHound.Classes.Interfaces
{
    public interface IPiece
    {
        Bitmap GetImage();

        List<Position> GetAvailableMoves(Position currentPosition, Layout currentLayout);
    }
}