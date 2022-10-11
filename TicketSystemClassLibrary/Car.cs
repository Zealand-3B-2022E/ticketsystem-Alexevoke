namespace TicketSystemClassLibrary
{
    /// <summary>
    /// This is a class that represent a car. It contains two properties and two methods
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