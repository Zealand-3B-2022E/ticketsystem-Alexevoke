using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketSystemClassLibrary;

namespace StoreBaeltTicketLibrary
{
    public class StorebaeltCar : Car
    {
        
        public StorebaeltCar() : base()
        {

        }

        public StorebaeltCar(string licenseplate, DateTime date) : base(licenseplate, date)
        {

        }
        
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
    }
}
