using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotAssignment
{
    public class Instructions : IInstructions
    {
        private readonly List<MovementStep> _movementSteps;
        private int _numberOfCommands;
        public Instructions()
        {
            _movementSteps = new List<MovementStep>();
        }
        public int NumberOfCommands
        {
            get
            {
                if (_numberOfCommands < 0)
                    _numberOfCommands = 0;
                if (_numberOfCommands > 10000)
                    _numberOfCommands = 10000;
                return _numberOfCommands;
            }
            set
            {
                _numberOfCommands = value;
            }
        }

        public Coordinates StartingCoordinates { get; set; }
        public List<MovementStep> MovementSteps
        {
            get
            {
                return _movementSteps;
            }
        }

    }

    public class Coordinates
    {
        public Coordinates(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int X { get; }

        public int Y { get; }

        public override string ToString()
        {
            return X + " " + Y;
        }

    }
    public class MovementStep
    {
        private int _steps;

        public int NumberOfSteps
        {
            get
            {
                if (_steps < 0)
                    _steps = 0;
                if (_steps > 100000)
                    _steps = 100000;
                return _steps;
            }
            set
            {
                _steps = value;
            }
        }
        public string Direction { get; set; }
    }
}
