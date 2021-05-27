using System;
using FoxAndHound.Classes.Interfaces;

namespace FoxAndHound.Classes
{
    public class Move
    {
        public Position Start { get; set; }
        public Position Destination { get; set; }
        public IPiece Piece { get; set; }

        public Move()
        {

        }

        public Move(string data)
        {
            //data = start.x start.y-destinatie.x destinatie.y
            var strings = data.Split('-');
            var start = strings[0].Split(' ');
            var destination = strings[1].Split(' ');
            Start = new Position(Convert.ToInt32(start[0]), Convert.ToInt32(start[1]));
            Destination = new Position(Convert.ToInt32(destination[0]), Convert.ToInt32(destination[1]));
        }
    }
}