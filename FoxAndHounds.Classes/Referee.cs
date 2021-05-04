using FoxAndHound.Classes.Implementations;
using FoxAndHound.Classes.Interfaces;
using System.Windows.Forms;

namespace FoxAndHound.Classes
{
    public delegate void TurnChanged(Player currentMovingPlayer);

    public class Referee
    {
        public Layout Layout { get; set; }
        public IBoard Board { get; set; }
        public Player CurrentMovingPlayer { get; set; }

        public event TurnChanged OnTurnChange;

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

        public void StartGame()
        {
            CurrentMovingPlayer = Player.Fox;
            Board.CurrentMovingPlayer = CurrentMovingPlayer;
            OnTurnChange?.Invoke(CurrentMovingPlayer);
        }

        public void OnMoveProposed(object sender, MoveProposedEventArgs moveProposedEventArgs)
        {
            if ((moveProposedEventArgs.Move.Piece.GetType().Equals(typeof(Hound)) && CurrentMovingPlayer == Player.Hounds) || (moveProposedEventArgs.Move.Piece.GetType().Equals(typeof(Fox)) && CurrentMovingPlayer == Player.Fox))
            {
                if (moveProposedEventArgs.Move.Piece.GetAvailableMoves(moveProposedEventArgs.Move.Start, Layout).Contains(moveProposedEventArgs.Move.Destination))
                {
                    UpdateLayout(moveProposedEventArgs.Move);
                    Board.Redraw();
                    CheckEndGame();
                    ChangeTurn();
                }
            }
        }

        public void UpdateLayout(Move move)
        {
            Layout.MovePiece(move);
            Board.BoardLayout = Layout;
        }

        public void CheckEndGame()
        {
            foreach (var piece in Layout.Arrangement)
            {
                if (piece.Value.GetType().Equals(typeof(Fox)))
                {
                    if (piece.Value.GetAvailableMoves(piece.Key, Layout).Count.Equals(0))
                    {
                        MessageBox.Show("Hounds win!!!");
                    }
                    else if (piece.Key.Y.Equals(0))
                    {
                        MessageBox.Show("Fox wins!!!");
                    }
                }
            }
        }

        public void ChangeTurn()
        {
            CurrentMovingPlayer = CurrentMovingPlayer == Player.Fox ? Player.Hounds : Player.Fox;
            Board.CurrentMovingPlayer = CurrentMovingPlayer;
            OnTurnChange?.Invoke(CurrentMovingPlayer);
        }
    }
}