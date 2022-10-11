namespace TicketSystemClassLibrary
{
    /// <summary>
    /// This is a class that represent a car. It contains two properties and two methods
    /// </summary>
    public class Car
    {
        /// <summary>
        /// This is the default constructor
        /// </summary>
        public Car()
        {

        }
        
        
        /// <summary>
        /// This is a property for the licenseplate of the car
        /// </summary>
        public string? Licenseplate{ get; set; }

        /// <summary>
        /// This is a property for a date
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// This a method that gives you the price of a car
        /// </summary>
        /// <returns>Returns the price of the car. The return value is of the double type</returns>
        public double Price()
        {
            double price = 240;
            return price;
        }
        /// <summary>
        /// This method gives you which type of vehicle it is
        /// </summary>
        /// <returns>Returns a string that tells you the vehicle type</returns>
        public string VehicleType()
        {
            string type = "Car";
            return type;
        }
    }
}