using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketSystemClassLibrary;

namespace StoreBaeltTicketLibrary
{
    /// <summary>
    /// This class inherits from the the car class and new functionality is added to support implementation
    /// for Storebaeltbroen
    /// </summary>
    public class StorebaeltCar : Vehicle
    {
        /// <summary>
        /// This is the default constructor
        /// </summary>
        public StorebaeltCar() : base()
        {

        }
        /// <summary>
        /// This constructor allows you to create a car object with a license plate and a date
        /// </summary>
        /// <param name="licenseplate">This is a license plate</param>
        /// <param name="date">This is a date</param>
        public StorebaeltCar(string licenseplate, DateTime date) : base(licenseplate, date)
        {

        }

        /// <summary>
        /// This method returns the correct price based on whether it is saturday or sunday and if you have 
        /// a brobizz
        /// </summary>
        /// <returns>Returns the price of the ticket for a car</returns>
        public override double Price()
        {
            double price = 240;

            if(Date.DayOfWeek == DayOfWeek.Saturday || Date.DayOfWeek == DayOfWeek.Sunday)
            {
                price = price * 0.80;
            }

            if (Brobizz)
            {
                price = price * 0.95;
            }

            return price;
        }
        /// <summary>
        /// This method gives you which type of vehicle it is
        /// </summary>
        /// <returns>Returns a string that tells you the vehicle type</returns>
        public override string VehicleType()
        {
            string type = "Car";
            return type;
        }

    }
}
