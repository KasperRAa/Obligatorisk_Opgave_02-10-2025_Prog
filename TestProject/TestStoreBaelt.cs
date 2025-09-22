using StoreBaeltTicketLibrary;
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
    public class TestStoreBaelt
    {
        [TestMethod]
        [DataRow(22, 230)]
        [DataRow(23, 230)]
        [DataRow(24, 230)]
        [DataRow(25, 230)]
        [DataRow(26, 230)]
        [DataRow(27, 195.5)]
        [DataRow(28, 195.5)]
        public void TestCar_Extension(int day, double Price)
        {
            //Arrange
            DateTime date = new DateTime(2025, 09, day);
            Car_StoreBaelt mc = new Car_StoreBaelt("       ", false, date);

            //Act
            double price = mc.Price();

            //Assert
            Assert.AreEqual(Price, price, 0.01);
        }

        [TestMethod]
        [DataRow(22, 207)]
        [DataRow(23, 207)]
        [DataRow(24, 207)]
        [DataRow(25, 207)]
        [DataRow(26, 207)]
        [DataRow(27, 175.95)]
        [DataRow(28, 175.95)]
        public void TestCar_ExtensionBrobizz(int day, double Price)
        {
            //Arrange
            DateTime date = new DateTime(2025, 09, day);
            Car_StoreBaelt mc = new Car_StoreBaelt("       ", true, date);

            //Act
            double price = mc.Price();

            //Assert
            Assert.AreEqual(Price, price, 0.01);
        }
    }
}
