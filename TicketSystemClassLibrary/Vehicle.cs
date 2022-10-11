using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TicketSystemClassLibrary
{
    /// <summary>
    /// This is the base class of vehicles it contains two properties and two methods
    /// </summary>
    public abstract class Vehicle
    {
        
        /// <summary>
        /// This is the default constructor
        /// </summary>
        public Vehicle()
        {
            Brobizz = false;
        }

        /// <summary>
        /// This constructor allows the initialization of a vehicle object with a license plate and a date
        /// </summary>
        /// <param name="licenseplate">This is the license plate of the vehicle</param>
        /// <param name="date">This is a date</param>
        public Vehicle(string? licenseplate, DateTime date)
        {
            if (licenseplate != null)
            {
                if (licenseplate.Length > 7)
                {
                    throw new ArgumentOutOfRangeException("The License plate can only have a length of 7 characters");
                }
            }
            Licenseplate = licenseplate;
            Date = date;
            Brobizz = false;
        }



        /// <summary>
        /// This is a property for the licenseplate of the vehicle
        /// </summary>
        public string? Licenseplate { get; private set; }
     

        /// <summary>
        /// This is a property for a date
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// This property is true or false. True if the vehicle has a Brobizz and false if it doesn't
        /// </summary>
        public bool Brobizz { get; set; }

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
