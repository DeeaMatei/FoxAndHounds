using System;
using FoxAndHound.Classes.Interfaces;

namespace FoxAndHound.Classes.Implementations
{
    public class PcGame : IGame
    {
        public event ComputerMove OnComputerMove;
        public IComputer Computer { get; set; }
        public Referee Referee { get; set; }
        public Player SelectedPlayer { get; set; }
        public Status Outcome { get; set; }

        public PcGame(Player player)
        {
            SelectedPlayer = player;
            if (player == Player.Fox)
            {
                Computer = new HoundsComputer();
            }
            else
            {
                Computer = new FoxComputer();
            }
            this.OnComputerMove += Computer.OnComputerMove;
        }
        public void Initialize(IBoard board)
        {
            Referee = new Referee(board);
            Referee.Initialize();
            Referee.OnTurnChange += OnTurnChanged;
        }

        public void Start()
        {
            Referee.StartGame();
        }

        public void OnTurnChanged(Player currentMovingPlayer)
        {
            if (currentMovingPlayer != SelectedPlayer)
            {
                OnComputerMove?.Invoke(Referee.Layout);
                Referee.Board.Redraw();
                Referee.CheckEndGame();
                Referee.ChangeTurn();
            }
        }
    }
}