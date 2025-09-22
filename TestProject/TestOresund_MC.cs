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
    public class TestOresund_MC
    {
        [TestMethod]
        public void TestPrice()
        {
            //Arrange
            Oresund_MC mc = new Oresund_MC("       ");

            //Act
            double price = mc.Price();

            //Assert
            Assert.AreEqual(235, price, 0.01);
        }

        [TestMethod]
        public void TestVehicleType()
        {
            //Arrange
            Oresund_MC mc = new Oresund_MC("       ");

            //Act
            string vehicleType = mc.VehicleType();

            //Assert
            Assert.AreEqual("Oresund MC", vehicleType);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestLicenseplateLengthInvalid()
        {
            //Arrange, Act & Assert
            new Oresund_MC("12345678");
        }

        [TestMethod]
        public void TestLicenseplateLengthValid()
        {
            //Arrange, Act & Assert
            new Oresund_MC("1234567");
        }

        [TestMethod]
        public void TestBrobizz()
        {
            //Arrange
            Oresund_MC car = new Oresund_MC("       ", true, new DateTime(0));

            //Act
            double price = car.Price();

            //Assert
            Assert.AreEqual(92, price, 0.01);
        }
    }
}
