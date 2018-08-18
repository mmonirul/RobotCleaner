using System;
using System.Collections.Generic;
using System.Linq;

namespace RobotAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Instructions instructions = new Instructions();
            Inputs.GetNumberOfCommands(instructions);
            Inputs.GetStartingPosition(instructions);

            if (instructions.NumberOfCommands > 0)
            {
                Inputs.GetDirectionAndStep(instructions.NumberOfCommands, instructions);
            }

            Clean clean = new Clean(instructions);
            clean.Start();


            List <string> distinctCleanedCoordiantes = clean.CleanedCoordinates.Distinct().ToList();

            Console.WriteLine($"=> Cleaned: {distinctCleanedCoordiantes.Count}");

            Console.ReadLine();
        }
    }


}
