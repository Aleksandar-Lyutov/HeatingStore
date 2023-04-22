using HeatingStore.Abstraction;
using HeatingStore.Data;
using HeatingStore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HeatingStore.Services
{
    public class HeatingDeviceService:IHeatingDeviceService
    {
        private readonly ApplicationDbContext _context;
        public HeatingDeviceService(ApplicationDbContext context)
        {
            _context = context;
        }
        public bool Create(string name, int manufacturerId, int categoryId, string picture, int quantity, string description, decimal price, decimal discount)
        {
            HeatingDevice item = new HeatingDevice
            {
                HeatingDeviceName = name,
                Manufacturer = _context.Manufacturers.Find(manufacturerId),
                Category = _context.Categories.Find(categoryId),
                Picture = picture,
                Quantity = quantity,
                Description = description,
                Price = price,
                Discount = discount
            };
            _context.HeatingDevices.Add(item);
            return _context.SaveChanges() != 0;
        }
        public HeatingDevice GetHeatingDeviceById(int heatingDeviceId)
        {
            return _context.HeatingDevices.Find(heatingDeviceId);
        }
        public List<HeatingDevice> GetHeatingDevices()
        {
            List<HeatingDevice> heatingDevices = _context.HeatingDevices.ToList();
            return heatingDevices;
        }
        public bool RemoveById(int heatingDeviceId)
        {
            var heatingDevice = GetHeatingDeviceById(heatingDeviceId);
            if (heatingDevice == default(HeatingDevice))
            {
                return false;
            }
            _context.Remove(heatingDevice);
            return _context.SaveChanges() != 0;
        }
        public List<HeatingDevice> GetHeatingDevices(string searchStringCategoryName, string searchStringManufacturerName, string searchStringHeatingDeviceName)
        {
            List<HeatingDevice> heatingDevices = _context.HeatingDevices.ToList();
            if (!String.IsNullOrEmpty(searchStringCategoryName) && !String.IsNullOrEmpty(searchStringManufacturerName))
            {
                heatingDevices = heatingDevices.Where(x => x.Category.CategoryName.ToLower().Contains(searchStringCategoryName.ToLower())
                && x.Manufacturer.ManufacturerName.ToLower().Contains(searchStringManufacturerName.ToLower())).ToList();
            }
            else if (!String.IsNullOrEmpty(searchStringHeatingDeviceName))
            {
                heatingDevices = heatingDevices.Where(x => x.HeatingDeviceName.ToLower().Contains(searchStringHeatingDeviceName.ToLower())).ToList();
            }
            else if (!String.IsNullOrEmpty(searchStringCategoryName))
            {
                heatingDevices = heatingDevices.Where(x => x.Category.CategoryName.ToLower().Contains(searchStringCategoryName.ToLower())).ToList();
            }
            else if (!String.IsNullOrEmpty(searchStringManufacturerName))
            {
                heatingDevices = heatingDevices.Where(x => x.Manufacturer.ManufacturerName.ToLower().Contains(searchStringManufacturerName.ToLower())).ToList();
            }
            return heatingDevices;
        }
        public bool Update(int heatingDeviceId, string name, int manufacturerId, int categoryId, string picture, int quantity, string description, decimal price, decimal discount)
        {
            var heatingDevice = GetHeatingDeviceById(heatingDeviceId);
            if (heatingDevice == default(HeatingDevice))
            {
                return false;
            }
            heatingDevice.HeatingDeviceName = name;
            heatingDevice.Manufacturer = _context.Manufacturers.Find(manufacturerId);
            heatingDevice.Category = _context.Categories.Find(categoryId);
            heatingDevice.Picture = picture;
            heatingDevice.Quantity = quantity;
            heatingDevice.Description = description;
            heatingDevice.Price = price;
            heatingDevice.Discount = discount;
            _context.Update(heatingDevice);
            return _context.SaveChanges() != 0;
        }
    }
}
