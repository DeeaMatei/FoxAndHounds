namespace FoxAndHound.Classes
{
    public interface IGame
    {
        Referee Referee { get; set; }
        Status Outcome { get; set; }

        void Initialize();

        void Start();
    }
}