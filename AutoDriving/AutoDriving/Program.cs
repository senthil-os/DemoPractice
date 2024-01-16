using AutoDriving.Direction;
using System;

namespace AutoDriving
{
    class Program
    {
     public static void Main(string[] args)
        {
            var inputMaxCoordinate = Console.ReadLine().Trim();
            var inputStartPosition = Console.ReadLine().Trim().ToUpper();
            var destinationPath  = Console.ReadLine().Trim().ToUpper();

            AutoDriving.Util.Util util = new Util.Util();
            var maxCoordinate = util.ValidateMaxCoordinate(inputMaxCoordinate);
            var startPosition = util.ValidateStartPosition(inputStartPosition);
            bool isPathValid = util.ValidateDestinationPath(destinationPath);

            if (maxCoordinate.Item3 && startPosition.Item4 && isPathValid)
            {
                VehicleMovement vehicle = new VehicleMovement();
                vehicle.MinX = vehicle.MinY = 0;    
                
                vehicle.MaxX = maxCoordinate.Item1;
                vehicle.MaxY = maxCoordinate.Item2;

                //start position should not greater than Max coordinates
                vehicle.PositionX = startPosition.Item1 > vehicle.MaxX ? vehicle.MaxX : startPosition.Item1;
                vehicle.PositionY = startPosition.Item2 > vehicle.MaxY ? vehicle.MaxY : startPosition.Item2;

                vehicle.Direction = (AutoDriving.Util.Direction)startPosition.Item3;
                var currentPosition = vehicle.JourneyDestination(destinationPath);
                Console.WriteLine("{0} {1} {2}", currentPosition.Item1, currentPosition.Item2, currentPosition.Item3);
            }
            Console.ReadKey();
        }
    }
}
