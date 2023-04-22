using HeatingStore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HeatingStore.Abstraction
{
    public interface IManufacturerService
    {
        List<Manufacturer> GetManufacturers();
        Manufacturer GetManufacturerById(int manufacturerId);
        List<HeatingDevice> GetHeatingDevicesByManufacturer(int manufacturerId);
    }
}
