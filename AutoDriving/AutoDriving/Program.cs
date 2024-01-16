using AutoDriving.Direction;
using System;

namespace AutoDriving
{
    class Program
    {
     public static void Main(string[] args)
        {
            //Inputs
            var inputMaxCoordinate = Console.ReadLine().Trim();
            var inputStartPosition = Console.ReadLine().Trim().ToUpper();
            var destinationPath  = Console.ReadLine().Trim().ToUpper();

            AutoDriving.Util.Util util = new Util.Util();

            //Validate
            var maxCoordinate = util.ValidateMaxCoordinate(inputMaxCoordinate);
            var startPosition = util.ValidateStartPosition(inputStartPosition);
            bool isPathValid = util.ValidateDestinationPath(destinationPath);
             // Valid inputs then execute 
            if (maxCoordinate.Item3 && startPosition.Item4 && isPathValid)
            {
                VehicleMovement vehicle = new VehicleMovement();
                vehicle.MinX = vehicle.MinY = 0;    
                
                vehicle.MaxX = maxCoordinate.Item1;
                vehicle.MaxY = maxCoordinate.Item2;

                //start position should not lesser than Min coordinates
                vehicle.PositionX = startPosition.Item1 < vehicle.MinX ? vehicle.MinX : startPosition.Item1;
                vehicle.PositionY = startPosition.Item2 < vehicle.MinY ? vehicle.MinY : startPosition.Item2;
                //start position should not greater than Max coordinates
                vehicle.PositionX = startPosition.Item1 > vehicle.MaxX ? vehicle.MaxX : startPosition.Item1;
                vehicle.PositionY = startPosition.Item2 > vehicle.MaxY ? vehicle.MaxY : startPosition.Item2;

                vehicle.Direction = (AutoDriving.Util.Direction)startPosition.Item3;
                
                //Vehicle Journey starts
                var currentPosition = vehicle.JourneyDestination(destinationPath);

                //Vehicle Destination reached
                Console.WriteLine("{0} {1} {2}", currentPosition.Item1, currentPosition.Item2, currentPosition.Item3);
            }
             else
            {
                Console.WriteLine("Invalid Inputs, Kindly Check the inputs.");
            }
            Console.ReadKey();
        }
    }
}
