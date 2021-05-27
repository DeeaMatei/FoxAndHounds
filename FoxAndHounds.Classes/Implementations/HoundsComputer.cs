using System.Windows.Forms;
using FoxAndHound.Classes.Interfaces;

namespace FoxAndHound.Classes.Implementations
{
    public class HoundsComputer : IComputer
    {
        public void OnComputerMove(Layout layout)
        {
            MessageBox.Show("HoundsMove");
        }
    }
}