using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotAssignment
{
    public static class Inputs
    {
        public static void GetNumberOfCommands(Instructions instructions)
        {
            Console.WriteLine("Number of commands->");
            instructions.NumberOfCommands = int.Parse(Console.ReadLine());
        }
        public static void GetStartingPosition(Instructions instructions)
        {
            Console.WriteLine("Starting position ->");
            var startingPosition = Console.ReadLine().Split(null);
            if (startingPosition.Length > 1)
            {
                instructions.StartingCoordinates = new Coordinates(int.Parse(startingPosition[0]), int.Parse(startingPosition[1]));
            }
        }

        public static void GetDirectionAndStep(int numberOfCommands, Instructions instructions)
        {
            Console.WriteLine($"Movement {numberOfCommands}:");
            for (int i = 0; i < numberOfCommands; i++)
            {
                var movementWithDirections = Console.ReadLine().Split(null);
                if (movementWithDirections.Length > 1)
                {
                    var movementStep = new MovementStep
                    {
                        Direction = movementWithDirections[0].ToUpper(),
                        NumberOfSteps = int.Parse(movementWithDirections[1])
                    };
                    instructions.MovementSteps.Add(movementStep);

                }

            }
        }

    }
}
