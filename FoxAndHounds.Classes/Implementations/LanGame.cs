using System;
using FoxAndHound.Classes.Interfaces;

namespace FoxAndHound.Classes.Implementations
{
    public class LanGame : IGame
    {
        public Referee Referee { get; set; }
        public Status Outcome { get; set; }
        public NetworkClient NetworkClient { get; set; }

        public LanGame(NetworkClient client)
        {
            NetworkClient = client;
        }

        public void Initialize(IBoard board)
        {
            Referee = new Referee(board);
            NetworkClient.OnDataRead += Referee.OnDataRead;
            Referee.Initialize();
        }

        public void Start()
        {
            Referee.StartGame();
        }
    }
}