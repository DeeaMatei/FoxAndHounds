using System;

namespace FoxAndHound.Classes.Implementations
{
    public class LanGame : IGame
    {
        public Referee Referee { get; set; }
        public Status Outcome { get; set; }
        public NetworkClient NetworkClient { get; set; }

        public void Initialize()
        {
            NetworkClient.OnDataRead += Referee.OnDataRead;
        }

        public void Start()
        {
            throw new NotImplementedException();
        }
    }
}