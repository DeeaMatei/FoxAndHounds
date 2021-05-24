using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoxAndHound.Classes.Interfaces
{
    public delegate void ComputerMove(Layout layout);
    public interface IComputer
    {
        void OnComputerMove(Layout layout);
    }

}
