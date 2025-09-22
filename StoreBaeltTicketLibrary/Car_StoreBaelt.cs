using Bridge;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreBaeltTicketLibrary
{
    /// <summary>
    /// A unique extension of the Car-class, meant for StoreBaeltBroen
    /// </summary>
    public class Car_StoreBaelt : Car
    {
        /// <summary>
        /// Standard-Constructor for Car-ticket.
        /// </summary>
        /// <param name="licenseplate">The licenseplate</param>
        [ExcludeFromCodeCoverage]
        public Car_StoreBaelt(string licenseplate) : base(licenseplate) { }
        /// <summary>
        /// Detailed Constructor for Car-ticket.
        /// </summary>
        /// <param name="licenseplate">The licenseplate</param>
        /// <param name="isBrobizz">Whether Brobizz is applied</param>
        /// <param name="dateTime">The date of the ticket</param>
        [ExcludeFromCodeCoverage]
        public Car_StoreBaelt(string licenseplate, bool isBrobizz, DateTime dateTime) : base(licenseplate, isBrobizz, dateTime) { }

        /// <summary>
        /// Returns the standard price of the ticket for the given day.
        /// </summary>
        /// <returns>230 Mon-Fri | 195,5 Sat-Sun</returns>
        public override double StandardPrice() => 230 * GetDayFactor();

        /// <summary>
        /// Gets the factor of the day.
        /// </summary>
        /// <returns>The Factor of the day</returns>
        private double GetDayFactor()
        {
            switch (Date.DayOfWeek)
            {
                case DayOfWeek.Monday:
                    return 1.00;
                case DayOfWeek.Tuesday:
                    return 1.00;
                case DayOfWeek.Wednesday:
                    return 1.00;
                case DayOfWeek.Thursday:
                    return 1.00;
                case DayOfWeek.Friday:
                    return 1.00;
                case DayOfWeek.Saturday:
                    return 0.85;
                default://Sunday
                    return 0.85;
            }
        }
    }
}
