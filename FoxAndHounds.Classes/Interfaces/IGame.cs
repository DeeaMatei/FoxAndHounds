using FoxAndHound.Classes.Interfaces;

namespace FoxAndHound.Classes
{
    public interface IGame
    {
        Referee Referee { get; set; }
        Status Outcome { get; set; }

        void Initialize(IBoard board);

        void Start();
    }
}