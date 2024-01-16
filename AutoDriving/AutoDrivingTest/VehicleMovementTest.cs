using System;
using System.Collections.Generic;
using System.Text;
using AutoDriving.Direction;
using NUnit.Framework;
using AutoDriving.Util;

namespace AutoDrivingTest
{
    public class VehicleMovementTest
    {
        private VehicleMovement _vehicleMovementFake { get; set; } = null!;

        [SetUp]
        public void Setup()
        {
            _vehicleMovementFake = new VehicleMovement();
        }

        [Test]
        public void TurnLeft_NorthToWest_Test()
        {
            //Assign
            _vehicleMovementFake.Direction = AutoDriving.Util.Direction.North;
            //Act
            _vehicleMovementFake.TurnLeft();
            //Assert
            Assert.AreEqual(Direction.West, _vehicleMovementFake.Direction);
        }

        [Test]
        public void TurnLeft_WestToSouth_Test()
        {
            //Assign
            _vehicleMovementFake.Direction = AutoDriving.Util.Direction.West;
            //Act
            _vehicleMovementFake.TurnLeft();
            //Assert
            Assert.AreEqual(Direction.South, _vehicleMovementFake.Direction);
        }

        [Test]
        public void TurnLeft_SouthToEast_Test()
        {
            //Assign
            _vehicleMovementFake.Direction = AutoDriving.Util.Direction.South;
            //Act
            _vehicleMovementFake.TurnLeft();
            //Assert
            Assert.AreEqual(Direction.East, _vehicleMovementFake.Direction);
        }

        [Test]
        public void TurnLeft_EastToNorth_Test()
        {
            //Assign
            _vehicleMovementFake.Direction = AutoDriving.Util.Direction.East;
            //Act
            _vehicleMovementFake.TurnLeft();
            //Assert
            Assert.AreEqual(Direction.North, _vehicleMovementFake.Direction);
        }

        [Test]
        public void TurnRight_NorthToEast_Test()
        {
            //Assign
            _vehicleMovementFake.Direction = AutoDriving.Util.Direction.North;
            //Act
            _vehicleMovementFake.TurnRight();
            //Assert
            Assert.AreEqual(Direction.East, _vehicleMovementFake.Direction);
        }

        [Test]
        public void TurnRight_EastToSouth_Test()
        {
            //Assign
            _vehicleMovementFake.Direction = AutoDriving.Util.Direction.East;
            //Act
            _vehicleMovementFake.TurnRight();
            //Assert
            Assert.AreEqual(Direction.South, _vehicleMovementFake.Direction);
        }


        [Test]
        public void TurnRight_SouthToWest_Test()
        {
            //Assign
            _vehicleMovementFake.Direction = AutoDriving.Util.Direction.South;
            //Act
            _vehicleMovementFake.TurnRight();
            //Assert
            Assert.AreEqual(Direction.West, _vehicleMovementFake.Direction);
        }


        [Test]
        public void TurnRight_WestToNorth_Test()
        {
            //Assign
            _vehicleMovementFake.Direction = AutoDriving.Util.Direction.West;
            //Act
            _vehicleMovementFake.TurnRight();
            //Assert
            Assert.AreEqual(Direction.North, _vehicleMovementFake.Direction);
        }

        [Test]
        public void MoveForward_NorthDirection_PositiveTest()
        {
            //Assign
            _vehicleMovementFake.Direction = Direction.North;
            _vehicleMovementFake.MaxY = 5;
            _vehicleMovementFake.PositionY = 1;
            //Act
            _vehicleMovementFake.MoveForward();
            //Assert
            Assert.AreEqual(2, _vehicleMovementFake.PositionY);
        }

        [Test]
        public void MoveForward_NorthDirection_NegativeTest()
        {
            //Assign
            _vehicleMovementFake.Direction = Direction.North;
            _vehicleMovementFake.MaxY = 5;
            _vehicleMovementFake.PositionY = 5;
            //Act
            _vehicleMovementFake.MoveForward();
            //Assert
            Assert.AreEqual(5, _vehicleMovementFake.PositionY);
        }

        [Test]
        public void MoveForward_WestDirection_PositiveTest()
        {
            //Assign
            _vehicleMovementFake.Direction = Direction.West;
            _vehicleMovementFake.MinX = 0;
            _vehicleMovementFake.PositionX = 2;
            //Act
            _vehicleMovementFake.MoveForward();
            //Assert
            Assert.AreEqual(1, _vehicleMovementFake.PositionX);
        }

        [Test]
        public void MoveForward_WestDirection_NegativeTest()
        {
            //Assign
            _vehicleMovementFake.Direction = Direction.West;
            _vehicleMovementFake.MinX = 0;
            _vehicleMovementFake.PositionX = 0;
            //Act
            _vehicleMovementFake.MoveForward();
            //Assert
            Assert.AreEqual(0, _vehicleMovementFake.PositionX);
        }

        [Test]
        public void MoveForward_SouthDirection_PositiveTest()
        {
            //Assign
            _vehicleMovementFake.Direction = Direction.South;
            _vehicleMovementFake.MinY = 0;
            _vehicleMovementFake.PositionY = 2;
            //Act
            _vehicleMovementFake.MoveForward();
            //Assert
            Assert.AreEqual(1, _vehicleMovementFake.PositionY);
        }

        [Test]
        public void MoveForward_SouthDirection_NegativeTest()
        {
            //Assign
            _vehicleMovementFake.Direction = Direction.South;
            _vehicleMovementFake.MinY = 0;
            _vehicleMovementFake.PositionY = 0;
            //Act
            _vehicleMovementFake.MoveForward();
            //Assert
            Assert.AreEqual(0, _vehicleMovementFake.PositionY);
        }


        [Test]
        public void MoveForward_EastDirection_PositiveTest()
        {
            //Assign
            _vehicleMovementFake.Direction = Direction.East;
            _vehicleMovementFake.MaxX = 5;
            _vehicleMovementFake.PositionX = 2;
            //Act
            _vehicleMovementFake.MoveForward();
            //Assert
            Assert.AreEqual(3, _vehicleMovementFake.PositionX);
        }

        [Test]
        public void MoveForward_EastDirection_NegativeTest()
        {
            //Assign
            _vehicleMovementFake.Direction = Direction.East;
            _vehicleMovementFake.MaxX = 5;
            _vehicleMovementFake.PositionX = 5;
            //Act
            _vehicleMovementFake.MoveForward();
            //Assert
            Assert.AreEqual(5, _vehicleMovementFake.PositionX);
        }


        [Test]
        public void JourneyDestination_NorthToSouthTest()
        {
            Tuple<int,int,char> tExpected = new Tuple<int,int,char>(2,2,'S');
            _vehicleMovementFake.MaxX = 5;
            _vehicleMovementFake.MaxY = 5;
            _vehicleMovementFake.MinX = 0;
            _vehicleMovementFake.MinY = 0;
            _vehicleMovementFake.PositionX = 1;
            _vehicleMovementFake.PositionY = 1;
            _vehicleMovementFake.Direction = Direction.North;
            //Assign
            string _strjourney = "FRFR";
            //Act
            var output = _vehicleMovementFake.JourneyDestination(_strjourney);
            //Assert
            Assert.AreEqual(tExpected, output);
        }

        [Test]
        public void JourneyDestination_SouthToNorthTest()
        {
            Tuple<int, int, char> tExpected = new Tuple<int, int, char>(1, 1, 'N');
            _vehicleMovementFake.MaxX = 5;
            _vehicleMovementFake.MaxY = 5;
            _vehicleMovementFake.MinX = 0;
            _vehicleMovementFake.MinY = 0;
            _vehicleMovementFake.PositionX = 2;
            _vehicleMovementFake.PositionY = 2;
            _vehicleMovementFake.Direction = Direction.South;
            //Assign
            string _strjourney = "FRFR";
            //Act
            var output = _vehicleMovementFake.JourneyDestination(_strjourney);
            //Assert
            Assert.AreEqual(tExpected, output);
        }

        [Test]
        public void JourneyDestination_WestToEastTest()
        {
            Tuple<int, int, char> tExpected = new Tuple<int, int, char>(1, 1, 'E');
            _vehicleMovementFake.MaxX = 5;
            _vehicleMovementFake.MaxY = 5;
            _vehicleMovementFake.MinX = 0;
            _vehicleMovementFake.MinY = 0;
            _vehicleMovementFake.PositionX = 2;
            _vehicleMovementFake.PositionY = 2;
            _vehicleMovementFake.Direction = Direction.West;
            //Assign
            string _strjourney = "FLFL";
            //Act
            var output = _vehicleMovementFake.JourneyDestination(_strjourney);
            //Assert
            Assert.AreEqual(tExpected, output);
        }

        [Test]
        public void JourneyDestination_EastToWestTest()
        {
            Tuple<int, int, char> tExpected = new Tuple<int, int, char>(3, 3, 'W');
            _vehicleMovementFake.MaxX = 5;
            _vehicleMovementFake.MaxY = 5;
            _vehicleMovementFake.MinX = 0;
            _vehicleMovementFake.MinY = 0;
            _vehicleMovementFake.PositionX = 2;
            _vehicleMovementFake.PositionY = 2;
            _vehicleMovementFake.Direction = Direction.East;
            //Assign
            string _strjourney = "FLFL";
            //Act
            var output = _vehicleMovementFake.JourneyDestination(_strjourney);
            //Assert
            Assert.AreEqual(tExpected, output);
        }
    }
}
