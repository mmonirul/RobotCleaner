using System.Collections.Generic;

namespace RobotAssignment
{
    public interface IInstructions
    {
        List<MovementStep> MovementSteps { get; }
        int NumberOfCommands { get; set; }
        Coordinates StartingCoordinates { get; set; }
    }
}