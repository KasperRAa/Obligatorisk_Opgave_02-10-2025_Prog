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
        /// <summary>
        /// Standard-Constructor for MC-ticket.
        /// </summary>
        /// <param name="licenseplate">The licenseplate</param>
        public MC(string licenseplate) : base(licenseplate, false, DateTime.Now) { }
        /// <summary>
        /// Detailed Constructor for MC-ticket.
        /// </summary>
        /// <param name="licenseplate">The licenseplate</param>
        /// <param name="isBrobizz">Whether Brobizz is applied</param>
        /// <param name="dateTime">The date of the ticket</param>
        public MC(string licenseplate, bool isBrobizz, DateTime dateTime) : base(licenseplate, isBrobizz, dateTime) { }

        /// <summary>
        /// Returns the standard price of the ticket.
        /// </summary>
        /// <returns>120</returns>
        public override double StandardPrice() => 120;
        /// <summary>
        /// Returns the type of MoterCycle.
        /// </summary>
        /// <returns>"MC"</returns>
        public override string VehicleType() => "MC";
    }
}
