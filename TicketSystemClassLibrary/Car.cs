namespace TicketSystemClassLibrary
{
    /// <summary>
    /// This is a class that represent a car. It contains two methods and inherits from the vehicle class
    /// </summary>
    public class Car : Vehicle
    {
        /// <summary>
        /// This is the default constructor
        /// </summary>
        public Car()
        {

        }

        /// <summary>
        /// This constructor allows the initialization of a car object with a license plate and a date
        /// </summary>
        /// <param name="licenseplate">This is the license plate of the MC</param>
        /// <param name="date">This is a date</param>
        public Car(string licenseplate, DateTime date) : base(licenseplate, date)
        {

        }

        /// <summary>
        /// This is a method that gives you the price of the car
        /// </summary>
        /// <returns>Returns the price of the car. The return value is of the double type</returns>
        public override double Price()
        {
            double price = 240;
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