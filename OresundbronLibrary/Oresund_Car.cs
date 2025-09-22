using Bridge;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OresundbronLibrary
{
    /// <summary>
    /// Car-class for Oresund
    /// </summary>
    public class Oresund_Car : Car
    {
        /// <summary>
        /// Standard-Constructor for Car-ticket.
        /// </summary>
        /// <param name="licenseplate">The licenseplate</param>
        [ExcludeFromCodeCoverage]
        public Oresund_Car(string licenseplate) : base(licenseplate) { }
        /// <summary>
        /// Detailed Constructor for Car-ticket.
        /// </summary>
        /// <param name="licenseplate">The licenseplate</param>
        /// <param name="isBrobizz">Whether Brobizz is applied</param>
        /// <param name="dateTime">The date of the ticket</param>
        [ExcludeFromCodeCoverage]
        public Oresund_Car(string licenseplate, bool isBrobizz, DateTime dateTime) : base(licenseplate, isBrobizz, dateTime) { }

        /// <summary>
        /// Returns the appropriate price
        /// </summary>
        /// <returns>isBrobizz?460:178/0.9</returns>
        public override double StandardPrice()
        {
            if (priceFactor == 1) return 460;
            else return 178 / 0.9;
        }
        /// <summary>
        /// Returns the type of a Car.
        /// </summary>
        /// <returns>"Oresund car"</returns>
        public override string VehicleType() => "Oresund car";
    }
}
