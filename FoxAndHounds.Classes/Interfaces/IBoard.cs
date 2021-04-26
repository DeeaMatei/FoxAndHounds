using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoxAndHound.Classes.Interfaces
{
    public delegate void MoveProposed(object sender, MoveProposedEventArgs args);

    public class MoveProposedEventArgs
    {
        public Move Move { get; set; }
    }
    public interface IBoard
    {
        Layout BoardLayout { get; set; }
        event MoveProposed OnMoveProposed;
    }
}
