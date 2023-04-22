using HeatingStore.Abstraction;
using HeatingStore.Data;
using HeatingStore.Domain;
using System.Collections.Generic;
using System.Linq;

namespace HeatingStore.Services
{
    public class ManufacturerService:IManufacturerService
    {
        private readonly ApplicationDbContext _context;

        public ManufacturerService(ApplicationDbContext context)
        {
            _context = context;
        }

        public Manufacturer GetManufacturerById(int manufacturerId)
        {
            return _context.Manufacturers.Find(manufacturerId);
        }
        public List<Manufacturer> GetManufacturers()
        {
            List<Manufacturer> manufacturers = _context.Manufacturers.ToList();
            return manufacturers;
        }
        public List<HeatingDevice> GetHeatingDevicesByManufacturer(int manufacturerId)
        {
            return _context.HeatingDevices
                .Where(x => x.ManufacturerId == manufacturerId)
                .ToList();
        }
    }
}
