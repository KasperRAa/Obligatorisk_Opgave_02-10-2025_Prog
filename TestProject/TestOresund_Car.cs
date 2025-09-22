using OresundbronLibrary;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    [TestClass]
    [ExcludeFromCodeCoverage]
    public class TestOresund_Car
    {
        [TestMethod]
        public void TestPrice()
        {
            //Arrange
            Oresund_Car mc = new Oresund_Car("       ");

            //Act
            double price = mc.Price();

            //Assert
            Assert.AreEqual(460, price, 0.01);
        }

        [TestMethod]
        public void TestVehicleType()
        {
            //Arrange
            Oresund_Car mc = new Oresund_Car("       ");

            //Act
            string vehicleType = mc.VehicleType();

            //Assert
            Assert.AreEqual("Oresund car", vehicleType);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestLicenseplateLengthInvalid()
        {
            //Arrange, Act & Assert
            new Oresund_Car("12345678");
        }

        [TestMethod]
        public void TestLicenseplateLengthValid()
        {
            //Arrange, Act & Assert
            new Oresund_Car("1234567");
        }

        [TestMethod]
        public void TestBrobizz()
        {
            //Arrange
            Oresund_Car car = new Oresund_Car("       ", true, new DateTime(0));

            //Act
            double price = car.Price();

            //Assert
            Assert.AreEqual(178, price, 0.01);
        }
    }
}
