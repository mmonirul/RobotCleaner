using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotAssignment
{
    public class Clean
    {

        private readonly Instructions _instructions;
        private Coordinates Coordinates;
        public List<string> CleanedCoordinates;
        public Clean(Instructions instructions)
        {
            _instructions = instructions;
            Coordinates = instructions.StartingCoordinates;
            CleanedCoordinates = new List<string>() { Coordinates.ToString() };
        }
        public void Start()
        {
            foreach (MovementStep move in _instructions.MovementSteps)
            {
                for (int i = 0; i < move.NumberOfSteps; i++)
                {
                    Scroll(move);
                }
            }
        }

        private void Scroll(MovementStep move)
        {
            switch (move.Direction)
            {
                case "E":
                    Coordinates = new Coordinates(Coordinates.X + 1, Coordinates.Y);
                    break;
                case "W":
                    Coordinates = new Coordinates(Coordinates.X - 1, Coordinates.Y);
                    break;
                case "S":
                    Coordinates = new Coordinates(Coordinates.X, Coordinates.Y - 1);
                    break;
                case "N":
                    Coordinates = new Coordinates(Coordinates.X, Coordinates.Y + 1);
                    break;
            }
            AddNewCoordinates(Coordinates.ToString());
        }

        private void AddNewCoordinates(string cordinatesStr)
        {
            CleanedCoordinates.Add(cordinatesStr);
        }
    }
}
