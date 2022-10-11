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

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestCarLicensePlateCannotExceedSevenCharacters()
        {
            //Arrange
            
            //Act
            Car car = new Car("DF98JLILL", DateTime.Now);

            //Assert
            Assert.Fail();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestMCLicensePlateCannotExceedSevenCharacters()
        {
            //Arrange

            //Act
            MC mc = new MC("DF98JLILL", DateTime.Now);

            //Assert
            Assert.Fail();
        }
    }
}