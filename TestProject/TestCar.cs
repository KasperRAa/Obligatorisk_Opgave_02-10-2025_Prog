using Bridge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    [TestClass]
    public class TestCar
    {
        [TestMethod]
        public void TestPrice()
        {
            //Arrange
            Car car = new Car("       ");

            //Act
            double price = car.Price();

            //Assert
            Assert.AreEqual(230, price, 0.01);
        }

        [TestMethod]
        public void TestVehicleType()
        {
            //Arrange
            Car car = new Car("       ");

            //Act
            string vehicleType = car.VehicleType();

            //Assert
            Assert.AreEqual("Car", vehicleType);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestLicenseplateLengthInvalid()
        {
            //Arrange, Act & Assert
            new Car("12345678");
        }

        [TestMethod]
        public void TestLicenseplateLengthValid()
        {
            //Arrange, Act & Assert
            new Car("1234567");
        }

        [TestMethod]
        public void TestBrobizz()
        {
            //Arrange
            Car car = new Car("       ", true);

            //Act
            double price = car.Price();

            //Assert
            Assert.AreEqual(207, price, 0.01);
        }
    }
}
