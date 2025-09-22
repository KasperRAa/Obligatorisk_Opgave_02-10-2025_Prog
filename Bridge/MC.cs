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
    public class MC
    {
        /// <summary>
        /// The licenseplate of the ticketed vehicle.
        /// </summary>
        public string Licenseplate;
        /// <summary>
        /// The Date of the ticket.
        /// </summary>
        public DateTime Date;

        /// <summary>
        /// Returns the price of a ticket.
        /// </summary>
        /// <returns>120</returns>
        public double Price() => 120;
        /// <summary>
        /// Returns the type of vehicle.
        /// </summary>
        /// <returns>"MC"</returns>
        public string VehicleType() => "MC";
    }
}
