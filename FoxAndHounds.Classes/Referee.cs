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
            Board.OnMoveProposed += this.OnMoveProposed;
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
            if (moveProposedEventArgs.Move.Piece.GetAvailableMoves(moveProposedEventArgs.Move.Start, Layout).Contains(moveProposedEventArgs.Move.Destination))
            {
                UpdateLayout(moveProposedEventArgs.Move);
                Board.Redraw();
            }
        }

        public void UpdateLayout(Move move)
        {
            Layout.MovePiece(move);
            Board.BoardLayout = Layout;
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