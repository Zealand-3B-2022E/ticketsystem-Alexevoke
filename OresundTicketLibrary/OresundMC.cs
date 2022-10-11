using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketSystemClassLibrary;

namespace OresundTicketLibrary
{
    public class OresundMC : MC
    {
        public OresundMC() : base()
        {

        }

        public OresundMC(string licenseplate, DateTime date) : base(licenseplate, date)
        {

        }
        public override double Price()
        {
            double price = 210;

            if (Brobizz)
            {
                price = 73;
                return price;
            }

            return price;
        }

        public override string VehicleType()
        {
            string type = "Oresund MC";
            return type;
        }
    }
}
