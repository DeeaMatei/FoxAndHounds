using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoxAndHound.Classes.Interfaces;

namespace FoxAndHound.Classes
{
    public class Referee
    {
        public Layout Layout { get; set; }
        public IBoard Board { get; set; }

        public void OnMoveProposed(object sender, MoveProposedEventArgs moveProposedEventArgs)
        { 
        }

        public void UpdateLayout ()
        {

        }
        public bool CheckEndGame ()
        {
            throw new NotImplementedException();
        }

        public void ChangeTurn()
        {

        }
    }
}
