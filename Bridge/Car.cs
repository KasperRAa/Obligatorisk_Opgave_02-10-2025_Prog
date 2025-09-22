using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    /// <summary>
    /// 
    /// </summary>
    public class Car
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
        /// <returns>230</returns>
        public double Price() => 230;
        /// <summary>
        /// Returns the type of vehicle.
        /// </summary>
        /// <returns>"Car"</returns>
        public string VehicleType() => "Car";
    }
}
