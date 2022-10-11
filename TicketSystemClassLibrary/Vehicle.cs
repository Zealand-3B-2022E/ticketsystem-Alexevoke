using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketSystemClassLibrary
{
    /// <summary>
    /// This is the base class of vehicles
    /// </summary>
    public abstract class Vehicle
    {
        /// <summary>
        /// This is a property for the licenseplate of the vehicle
        /// </summary>
        public string? Licenseplate { get; set; }

        /// <summary>
        /// This is a property for a date
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// This method gives the price of the vehicle
        /// </summary>
        /// <returns>Returns the price of the vehicle. The return value is of the double type</returns>
        public abstract double Price();
        
        /// <summary>
        /// This is a method the gives the vehicle type of the vehicle
        /// </summary>
        /// <returns>Returns a string with containing the vehicle type</returns>
        public abstract string VehicleType();
    }
}
