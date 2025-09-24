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
    /// MC-class for Oresund
    /// </summary>
    public class Oresund_MC : MC
    {
        /// <summary>
        /// Standard-Constructor for MC-ticket.
        /// </summary>
        /// <param name="licenseplate">The licenseplate</param>
        [ExcludeFromCodeCoverage]
        public Oresund_MC(string licenseplate) : base(licenseplate) { }
        /// <summary>
        /// Detailed Constructor for MC-ticket.
        /// </summary>
        /// <param name="licenseplate">The licenseplate</param>
        /// <param name="isBrobizz">Whether Brobizz is applied</param>
        /// <param name="dateTime">The date of the ticket</param>
        [ExcludeFromCodeCoverage]
        public Oresund_MC(string licenseplate, bool isBrobizz, DateTime dateTime) : base(licenseplate, isBrobizz, dateTime) { }

        /// <summary>
        /// Returns the appropriate price
        /// </summary>
        /// <returns>isBrobizz?235:92/0.9</returns>
        public override double StandardPrice()
        {
            if (priceFactor == 1) return 235;
            else return 92 / 0.9;
        }
        /// <summary>
        /// Returns the type of a MC.
        /// </summary>
        /// <returns>"Oresund MC"</returns>
        public override string VehicleType() => "Oresund MC";
    }
}
