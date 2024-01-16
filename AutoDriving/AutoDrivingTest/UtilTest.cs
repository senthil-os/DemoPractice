using AutoDriving.Util;
using NUnit.Framework;

namespace AutoDrivingTest
{
    public class UtilTest    {
        private Util _utilFake { get; set; } = null!;
        
        [SetUp]
        public void Setup()
        {
            _utilFake = new Util();
        }

        [Test]
        public void ValidateMaxCoordinate_PositiveTest()
        { //Assign
            string inputMaxCoordinate = "10 10";
            //var inputStartPosition = Console.ReadLine().Trim().ToUpper();
            //var destinationPath = Console.ReadLine().Trim().ToUpper();

            //Act
            var output = _utilFake.ValidateMaxCoordinate(inputMaxCoordinate.Trim());
            //Assert            _
          Assert.AreEqual(true,output.Item3);
        }

        [Test]
        public void ValidateMaxCoordinate_NegativeTest()
        {   //Assign
            string inputMaxCoordinate = "1010";
            //Act
            var output = _utilFake.ValidateMaxCoordinate(inputMaxCoordinate.Trim());
            //Assert            _
            Assert.AreEqual(false, output.Item3);
        }

        [Test]
        public void ValidateStartPosition_PositiveTest()
        { //Assign
            string inputStartPosition = "1 2 N";
            //Act
            var output = _utilFake.ValidateStartPosition(inputStartPosition.Trim());
            //Assert
            Assert.AreEqual(true, output.Item4);
        }

        [Test]
        public void ValidateStartPosition_NegativeTest()
        { //Assign
            string inputStartPosition = "1 2 G";
            //Act
            var output = _utilFake.ValidateStartPosition(inputStartPosition.Trim());
            //Assert 
            Assert.AreEqual(false, output.Item4);
        }

        [Test]
        public void ValidateDestinationPath_PositiveTest()
        { //Assign
           string destinationPath = "FF";
            //Act
            bool output = _utilFake.ValidateDestinationPath(destinationPath);
            //Assert
            Assert.AreEqual(true, output);
        }

        [Test]
        public void ValidateDestinationPath_NegativeTest()
        {   //Assign
            string destinationPath = "";
            //Act
            bool output = _utilFake.ValidateDestinationPath(destinationPath);
            //Assert
            Assert.AreEqual(false, output);
        }
    }
}