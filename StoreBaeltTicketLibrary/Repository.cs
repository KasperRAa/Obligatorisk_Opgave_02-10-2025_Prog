using Bridge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreBaeltTicketLibrary
{
    /// <summary>
    /// A repository-class for accessing the tickets in the system
    /// </summary>
    public class Repository : IRepository
    {
        private static List<Vehicle> _tickets = new List<Vehicle>();
        /// <summary>
        /// Buy a ticket for a car and add it to the system
        /// </summary>
        /// <param name="licenseplate">The car's licenseplate</param>
        /// <returns>The price of the Ticket</returns>
        public double BuyTicketCar(string licenseplate)
        {
            Car_StoreBaelt car = new(licenseplate, false, DateTime.Now);
            _tickets.Add(car);
            return car.Price();
        }
        /// <summary>
        /// Buy a ticket for a mc and add it to the system
        /// </summary>
        /// <param name="licenseplate">The mc's licenseplate</param>
        /// <returns>The price of the Ticket</returns>
        public double BuyTicketMC(string licenseplate)
        {
            MC mc = new(licenseplate, false, DateTime.Now);
            _tickets.Add(mc);
            return mc.Price();
        }
        /// <summary>
        /// Get all tickets in the system
        /// </summary>
        /// <returns>A list containing all tickets in the system</returns>
        public List<Vehicle> GetAllTickets() => _tickets;
        /// <summary>
        /// Get all tickets in the system with a matching licenseplate
        /// </summary>
        /// <param name="licenseplate">The licenseplate to be matched</param>
        /// <returns>A list containing all tickets in the system with a matching licenseplate</returns>
        public List<Vehicle> GetAllTicketsOfPlate(string licenseplate) => _tickets.Where(t => t.Licenseplate == licenseplate).ToList();

    }
}
