using System.Windows.Forms;
using FoxAndHound.Classes.Interfaces;

namespace FoxAndHound.Classes.Implementations
{
    public class FoxComputer : IComputer
    {
        public void OnComputerMove(Layout layout)
        {
            MessageBox.Show("FoxMove");
        }
    }
}