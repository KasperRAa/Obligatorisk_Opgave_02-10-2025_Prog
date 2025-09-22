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

        /// <summary>
        /// The multiplication factor on the price of a ticket.
        /// </summary>
        protected double priceFactor = 1;

        /// <summary>
        /// Constructor for the abstract class Vehicle.
        /// </summary>
        /// <param name="licenseplate">The licenseplate for the ticketed vehicle</param>
        /// <param name="isBrobizz">Whether the has a Brobizz discount applied</param>
        /// <param name="dateTime">The date of the ticket</param>
        /// <exception cref="ArgumentException"></exception>
        public Vehicle(string licenseplate, bool isBrobizz, DateTime dateTime)
        {
            if (licenseplate.Length > 7) throw new ArgumentException($"The licenseplate '{licenseplate}' is too long.");
            Licenseplate = licenseplate;
            Date = dateTime;

            if (isBrobizz) priceFactor *= 0.9;
        }

        /// <summary>
        /// Returns the price of the ticket.
        /// </summary>
        /// <returns>Price of the ticket</returns>
        public double Price() => StandardPrice() * priceFactor;
        /// <summary>
        /// The standard price of a ticket.
        /// </summary>
        /// <returns>Standard price of a ticket</returns>
        public abstract double StandardPrice();

        /// <summary>
        /// Returns the type of vehicle.
        /// </summary>
        /// <returns>Type of vehicle</returns>
        public abstract string VehicleType();
    }
}
