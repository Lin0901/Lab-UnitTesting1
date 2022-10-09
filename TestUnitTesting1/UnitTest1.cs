namespace TestUnitTesting1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSlotsAvailable()
        {
            //Arrange
            int capacity = 1;
            string location = "MITT";

            //Act
            var testTracker = new VehicleTracker(capacity, location);
            var vehicle = new Vehicle("MB00", false);
            testTracker.AddVehicle(vehicle);

            //Assert
            Assert.AreEqual(testTracker.SlotsAvailable, 0);
        }

        [TestMethod]
        public void TestAddingVehicle()
        {
            //Arrange
            var testTracker = new VehicleTracker(2, "MITT PARK");
            var vehicle = new Vehicle("MB01", false);

            //Act
            testTracker.AddVehicle(vehicle);

            //Assert
            Assert.IsTrue(vehicle != null);
        }

        [TestMethod]
        public void TestRemovingVehicle()
        {
            //Arrange
            var testTracker = new VehicleTracker(3, "DT");
            var vehicle = new Vehicle("MB02", false);

            //Act
            testTracker.AddVehicle(vehicle);
            testTracker.RemoveVehicle("MB02");

            //Assert
            Assert.IsTrue(vehicle != null);
        }

        [TestMethod]
        public void TestOverCapacity()
        {
            //Arrange
            int capacity = 4;
            string location = "BW";

            //Act
            var testTracker = new VehicleTracker(capacity, location);
            var vehicle = new Vehicle("MB03", false);
            testTracker.AddVehicle(vehicle);

            //Assert
            Assert.AreEqual(capacity, testTracker.Capacity);

        }

        public void TestVehicleException()
        {
            //Arrange
            int capacity = 1;
            string location = "MITT";

            //Act
            var testTracker = new VehicleTracker(capacity, location);
            var vehicle1 = new Vehicle("MB04", false);
            var vehicle2 = new Vehicle("MB05", true);
            var vehicle3 = new Vehicle("MB06", false);

            //Assert
            Assert.ThrowsException<IndexOutOfRangeException>(() =>
            {

                testTracker.AddVehicle(vehicle1);
                testTracker.AddVehicle(vehicle2);
                testTracker.AddVehicle(vehicle3);

            });
        }

        [TestMethod]
        public void TestPercentagePassed()
        {
            //Arrange
            int capacity = 3;
            string location = "MITT";

            //Act
            var testTracker = new VehicleTracker(capacity, location);
            var vehicle1 = new Vehicle("MB07", true);
            var vehicle2 = new Vehicle("MB08", false);

            testTracker.AddVehicle(vehicle1);
            testTracker.AddVehicle(vehicle2);

            //Assert
            Assert.AreEqual(capacity, testTracker.VehicleList.Count);

        }


    }
}