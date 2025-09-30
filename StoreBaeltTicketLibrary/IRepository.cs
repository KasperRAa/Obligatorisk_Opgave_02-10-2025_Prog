using Bridge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreBaeltTicketLibrary
{
    /// <summary>
    /// An interface for a repository of Vehicle-Tickets (Oresund)
    /// </summary>
    public interface IRepository
    {
        /// <summary>
        /// Buy a ticket for a car and add it to the Repository
        /// </summary>
        /// <param name="licenseplate">The car's licenseplate</param>
        /// <returns>The price of the Ticket</returns>
        public double BuyTicketCar(string licenseplate);
        /// <summary>
        /// Buy a ticket for a mc and add it to the Repository
        /// </summary>
        /// <param name="licenseplate">The mc's licenseplate</param>
        /// <returns>The price of the Ticket</returns>
        public double BuyTicketMC(string licenseplate);
        /// <summary>
        /// Get all tickets in the Repository
        /// </summary>
        /// <returns>A list containing all tickets in the Repository</returns>
        public List<Vehicle> GetAllTickets();
        /// <summary>
        /// Get all tickets in the Repository with a matching licenseplate
        /// </summary>
        /// <param name="licenseplate">The licenseplate to be matched</param>
        /// <returns>A list containing all tickets in the Repository with a matching licenseplate</returns>
        public List<Vehicle> GetAllTicketsOfPlate(string licenseplate);
    }
}
