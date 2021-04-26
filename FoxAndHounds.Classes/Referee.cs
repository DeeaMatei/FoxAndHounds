using System;
using FoxAndHound.Classes.Interfaces;

namespace FoxAndHound.Classes
{
    public class Referee
    {
        public Layout Layout { get; set; }
        public IBoard Board { get; set; }

        public Referee(IBoard board)
        {
            Board = board;
            Layout = new Layout();
        }

        public void Initialize()
        {
            Layout.Initialize();
            Board.BoardLayout = Layout;
        }

        public void StartGame(Player currentMovingPlayer)
        {
            currentMovingPlayer = Player.Player1;
        }

        public void OnMoveProposed(object sender, MoveProposedEventArgs moveProposedEventArgs)
        {
        }

        public void UpdateLayout()
        {
        }

        public bool CheckEndGame()
        {
            throw new NotImplementedException();
        }

        public void ChangeTurn()
        {
        }
    }
}