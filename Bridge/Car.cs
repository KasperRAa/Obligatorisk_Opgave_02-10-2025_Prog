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
        /// <summary>
        /// Standard-Constructor for Car-ticket.
        /// </summary>
        /// <param name="licenseplate">The licenseplate</param>
        public Car(string licenseplate) : base(licenseplate, false, DateTime.Now) { }
        /// <summary>
        /// Detailed Constructor for Car-ticket.
        /// </summary>
        /// <param name="licenseplate">The licenseplate</param>
        /// <param name="isBrobizz">Whether Brobizz is applied</param>
        /// <param name="dateTime">The date of the ticket</param>
        public Car(string licenseplate, bool isBrobizz, DateTime dateTime) : base(licenseplate, isBrobizz, dateTime) { }

        /// <summary>
        /// Returns the standard price of the ticket.
        /// </summary>
        /// <returns>230</returns>
        public override double StandardPrice() => 230;
        /// <summary>
        /// Returns the type of a Car.
        /// </summary>
        /// <returns>"Car"</returns>
        public override string VehicleType() => "Car";
    }
}
