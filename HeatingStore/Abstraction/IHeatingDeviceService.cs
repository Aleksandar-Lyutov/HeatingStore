using HeatingStore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HeatingStore.Abstraction
{
    public interface IHeatingDeviceService
    {
        bool Create(string name, int manufacturerId, int categoryId, string picture, int quantity, string description, decimal price, decimal discount);
        bool Update(int heatingDeviceId, string name, int manufacturerId, int categoryId, string picture, int quantity, string description, decimal price, decimal discount);
        List<HeatingDevice> GetHeatingDevices();
        HeatingDevice GetHeatingDeviceById(int heatingDeviceId);
        bool RemoveById(int heatingDeviceId);
        List<HeatingDevice> GetHeatingDevices(string searchStringCategoryName, string searchStringManufacturerName, string searchStringHeatingDeviceName);
    }
}
