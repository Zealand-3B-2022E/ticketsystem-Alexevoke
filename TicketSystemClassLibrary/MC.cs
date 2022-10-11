using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketSystemClassLibrary
{
    /// <summary>
    /// This class represents a Motorcycle. It contains two properties and two methods
    /// </summary>
    public class MC : Vehicle
    {
        /// <summary>
        /// This is the default constructor
        /// </summary>
        public MC()
        {

        }

        /// <summary>
        /// This method gives the price of the MC
        /// </summary>
        /// <returns>Returns the price of the MC. The return value is of the double type</returns>
        public override double Price()
        {
            double price = 125;
            return price;
        }
        /// <summary>
        /// This is a method the gives the vehicle type of the MC
        /// </summary>
        /// <returns>Returns a string with containing the vehicle type</returns>
        public override string VehicleType()
        {
            string type = "MC";
            return type;
        }
    }
}
