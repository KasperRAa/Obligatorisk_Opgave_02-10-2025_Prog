using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public abstract class Vehicle
    {
        /// <summary>
        /// The licenseplate of the ticketed vehicle.
        /// </summary>
        public readonly string Licenseplate;
        /// <summary>
        /// The Date of the ticket.
        /// </summary>
        public readonly DateTime Date;

        public Vehicle(string licenseplate)
        {
            if (licenseplate.Length > 7) throw new ArgumentException($"The licenseplate '{licenseplate}' is too long.");
            Licenseplate = licenseplate;
            Date = DateTime.Now;
        }

        /// <summary>
        /// Returns the price of a ticket.
        /// </summary>
        /// <returns>Price of a ticket</returns>
        public abstract double Price();

        /// <summary>
        /// Returns the type of vehicle.
        /// </summary>
        /// <returns>Type of vehicle</returns>
        public abstract string VehicleType();
    }
}
