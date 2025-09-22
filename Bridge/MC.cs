using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    /// <summary>
    /// A class for the data of a ticketed MotorCycle
    /// </summary>
    public class MC : Vehicle
    {
        public MC(string licenseplate) : base(licenseplate) { }

        /// <summary>
        /// Returns the price of a ticket.
        /// </summary>
        /// <returns>120</returns>
        public override double Price() => 120;
        /// <summary>
        /// Returns the type of MoterCycle.
        /// </summary>
        /// <returns>"MC"</returns>
        public override string VehicleType() => "MC";
    }
}
