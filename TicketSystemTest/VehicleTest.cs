namespace TicketSystemTest
{
    [TestClass]
    public class VehicleTest
    {
        [TestMethod]
        public void TestCarPriceReturnsProperValue()
        {
            //Arrange
            Car car = new Car();
            double expectedValue = 240;

            //Act
            double actualValue = car.Price();

            //Assert
            Assert.AreEqual(expectedValue, actualValue);

        }

        [TestMethod]
        public void TestCarVehicleTypeReturnsCorrectValue()
        {
            //Arrange
            Car car = new Car();
            string expectedValue = "Car";
            
            //Act
            string actualValue = car.VehicleType();
            
            //Assert
            Assert.AreEqual(expectedValue, actualValue);

        }

        [TestMethod]
        public void TestMCPriceReturnsProperValue()
        {
            //Arrange
            MC mc = new MC();
            double expectedValue = 125;

            //Act
            double actualValue = mc.Price();

            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void TestMCVehicleTypeReturnsCorrectValue()
        {
            //Arrange
            MC mc = new MC();
            string expectedValue = "MC";

            //Act
            string actualValue = mc.VehicleType();

            //Assert
            Assert.AreEqual(expectedValue, actualValue);

        }
    }
}