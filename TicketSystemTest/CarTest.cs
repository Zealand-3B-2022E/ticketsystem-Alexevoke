namespace TicketSystemTest
{
    [TestClass]
    public class CarTest
    {
        [TestMethod]
        public void TestPriceReturnsProperValue()
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
        public void TestVehicleTypeReturnsCorrectValue()
        {
            //Arrange
            Car car = new Car();
            string expectedValue = "Car";
            
            //Act
            string actualValue = car.VehicleType();
            
            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}