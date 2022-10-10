using System.Diagnostics;

namespace TestUnitTesting1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestGenerateSlotAvailable()
        {
            //Arrange
            int capacity = 3;
            string location = "MITT";

            //Act
            var testTracker = new VehicleTracker(capacity, location);
            var vehicle = new Vehicle("MB00", false);

            //Assert
            Assert.AreEqual(capacity, testTracker.VehicleList.Count());
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
            Assert.IsTrue(testTracker.RemoveVehicle(1));
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

        [TestMethod]
        public void TestParkedPassholders()
        {
            //Arrange
            int capacity = 3;
            string location = "MITT";
            var parkedPassholders = 1;

            //Act
            var testTracker = new VehicleTracker(capacity, location);
            var vehicle1 = new Vehicle("MB04", true);
            var vehicle2 = new Vehicle("MB05", false);

            testTracker.AddVehicle(vehicle1);
            testTracker.AddVehicle(vehicle2);


            //Assert
            Assert.AreEqual(parkedPassholders, testTracker.ParkedPassholders().Count());
        }

        [TestMethod]
        public void TestPassholderPercentage()
        {
            //Arrange
            int capacity = 3;
            string location = "MITT";

            //Act
            var testTracker = new VehicleTracker(capacity, location);
            var vehicle1 = new Vehicle("MB07", false);
            var vehicle2 = new Vehicle("MB08", false);

            testTracker.AddVehicle(vehicle1);
            testTracker.AddVehicle(vehicle2);

            int percentage = testTracker.PassholderPercentage();
            int assertedPercentage = (2 / 3) * 100;

            //Assert
            Assert.AreEqual(assertedPercentage, percentage);
        }


    }
}