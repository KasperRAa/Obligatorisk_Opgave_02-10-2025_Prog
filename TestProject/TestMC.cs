using Bridge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    [TestClass]
    public class TestMC
    {
        [TestMethod]
        public void TestPrice()
        {
            //Arrange
            MC mc = new MC("       ");

            //Act
            double price = mc.Price();

            //Assert
            Assert.AreEqual(120, price, 0.01);
        }

        [TestMethod]
        public void TestVehicleType()
        {
            //Arrange
            MC mc = new MC("       ");

            //Act
            string vehicleType = mc.VehicleType();

            //Assert
            Assert.AreEqual("MC", vehicleType);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestLicenseplateLengthInvalid()
        {
            //Arrange, Act & Assert
            new MC("12345678");
        }

        [TestMethod]
        public void TestLicenseplateLengthValid()
        {
            //Arrange, Act & Assert
            new MC("1234567");
        }
    }
}
