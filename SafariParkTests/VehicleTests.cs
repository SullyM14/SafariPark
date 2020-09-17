using NUnit.Framework;
using SafariPark;

namespace SafariParkTests
{
    public class Tests
    {
        [Test]
        public void WhenADefaultVehicleMovesTwiceItsPositionIS20()
        {
            Vehicle v = new Vehicle();
            var result = v.Move(2);
            Assert.AreEqual(20, v.Position);
            Assert.AreEqual("Moving along 2 times", result);
        }

        [Test]
        public void WhenAVehivleWithSpeed40IsMovedOnceItsPositionIs40()
        {
            Vehicle v = new Vehicle(5, 40);
            var result = v.Move();
            Assert.AreEqual(40, v.Position);
            Assert.AreEqual("Moving along", result);
        }




        [TestCase(5,5)] //Set Passengers
        [TestCase(-1,0)] //Set Passengers with negative number
        [TestCase(6,5)] //Set Passengers More than Capacity
        public void SetPassengers(int x, int result)
        {
            Vehicle v = new Vehicle(5, 40);
            v.NumPassengers = x;
            Assert.AreEqual(result, v.NumPassengers);
        }

        [TestCase(5, 1, 5)] //Set Passenegers after the capacity is filled
        [TestCase(3,4,5)] // Set passengers with only the right amount being allowed in the second time
        public void SetPassengersTwice(int x, int y, int result)
        {
            Vehicle v = new Vehicle(5, 40);
            v.NumPassengers = x;
            v.NumPassengers = y;
            Assert.AreEqual(result, v.NumPassengers);
        }

        //[Test]
        //public void SetPassengersNegativeNumber()
        //{
        //    Vehicle v = new Vehicle(5, 40);
        //    v.NumPassengers = -1;
        //    Assert.AreEqual(0, v.NumPassengers);
        //}

        //[Test]
        //public void SetPassengersMoreThanCapacity()
        //{
        //    Vehicle v = new Vehicle(5, 40);
        //    v.NumPassengers = 6;
        //    Assert.AreEqual(5, v.NumPassengers);
        //}
    }
}