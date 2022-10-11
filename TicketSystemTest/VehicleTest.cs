using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace TicketSystemTest
{
    [TestClass]
    public class VehicleTest
    {
        [TestMethod]
        [DataRow(240,false)]
        [DataRow(228,true)]
        public void TestCarPriceReturnsCorrectValueWithBrobizz(double expectedValue, bool brobizz)
        {
            //Arrange
            Car car = new Car();
            car.Brobizz = brobizz;
            double delta = 0.01;

            //Act
            double actualValue = car.Price();

            //Assert
            Assert.AreEqual(expectedValue, actualValue, delta);

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
        [DataRow(125, false)]
        [DataRow(118.75, true)]
        public void TestMCPriceReturnsCorrectValueWithBrobizz(double expectedValue, bool brobizz)
        {
            //Arrange
            MC mc = new MC();
            mc.Brobizz = brobizz;
            double delta = 0.01;

            //Act
            double actualValue = mc.Price();

            //Assert
            Assert.AreEqual(expectedValue, actualValue, delta);
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
        [TestMethod]
        [DataRow(240, 2, false)]
        [DataRow(228, 2, true)]
        [DataRow(192, 4, false)]
        [DataRow(182.40, 4, true)]
        [DataRow(192, 5, false)]
        [DataRow(182.40, 5, true)]

        public void TestStorebaeltCarPriceReturnsCorrectValueWithBrobizzAndWeekendDiscount(double expectedValue, double days, bool brobizz)
        {
            //Arrange
            StorebaeltCar car = new StorebaeltCar("LOLOLOL", DateTime.Now.AddDays(days));
            car.Brobizz = brobizz;
            double delta = 0.01;

            //Act
            double actualValue = car.Price();

            //Assert
            Assert.AreEqual(expectedValue, actualValue, delta);
            
        }

        [TestMethod]
        [DataRow(410, false)]
        [DataRow(161, true)]
        public void TestOresundCarPrice(double expectedValue, bool brobizz)
        {
            //Arrange
            OresundCar car = new OresundCar();
            car.Brobizz = brobizz;
            
            //Act
            double actualValue = car.Price();

            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        [DataRow(210, false)]
        [DataRow(73, true)]
        public void TestOresundMCPrice(double expectedValue, bool brobizz)
        {
            //Arrange
            OresundMC mc = new OresundMC();
            mc.Brobizz = brobizz;

            //Act
            double actualValue = mc.Price();

            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void TestOresundCarVehicleType()
        {
            //Arrange
            OresundCar car = new OresundCar();
            string expectedValue = "Oresund car";

            //Act
            string actualValue = car.VehicleType();

            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void TestOresundMCVehicleType()
        {
            //Arrange
            OresundMC mc = new OresundMC();
            string expectedValue = "Oresund MC";

            //Act
            string actualValue = mc.VehicleType();

            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}
