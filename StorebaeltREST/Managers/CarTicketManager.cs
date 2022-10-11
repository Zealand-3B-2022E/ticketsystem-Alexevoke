using StoreBaeltTicketLibrary;
using TicketSystemClassLibrary;
using System.Runtime.InteropServices;

namespace StorebaeltREST.Managers
{
    public class CarTicketManager
    {
        private static List<StorebaeltCar> _storebaeltCars = new List<StorebaeltCar>()
        {
            new StorebaeltCar("LOLOLOL", DateTime.Now)
            {
                Brobizz = true
            },
            new StorebaeltCar("LOLOLOL", DateTime.Now.AddDays(4))
            {
                Brobizz = true
            }
        };


        public StorebaeltCar Create(StorebaeltCar car)
        {
            _storebaeltCars.Add(car);
            return car;
        }

        public List<StorebaeltCar> GetAll()
        {
            return _storebaeltCars;
        }

        public List<StorebaeltCar> GetByLicenseplate(string licenseplate)
        {
            List<StorebaeltCar> cars = _storebaeltCars.FindAll(k => k.Licenseplate == licenseplate);

            return cars;
        }
    }
}
