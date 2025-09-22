using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    /// <summary>
    /// A class for the data of a ticketed car
    /// </summary>
    public class Car : Vehicle
    {
        public Car(string licenseplate) : base(licenseplate, false) { }
        public Car(string licenseplate, bool isBrobizz) : base(licenseplate, isBrobizz) { }

        /// <summary>
        /// Returns the price of the ticket.
        /// </summary>
        /// <returns>230 * Factors</returns>
        public override double StandardPrice() => 230;
        /// <summary>
        /// Returns the type of a Car.
        /// </summary>
        /// <returns>"Car"</returns>
        public override string VehicleType() => "Car";
    }
}
