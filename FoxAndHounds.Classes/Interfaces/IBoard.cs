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
        Player CurrentMovingPlayer { get; set; }

        event MoveProposed OnMoveProposed;

        void Redraw();
    }
}