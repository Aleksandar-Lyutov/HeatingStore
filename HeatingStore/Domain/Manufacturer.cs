using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HeatingStore.Domain
{
    public class Manufacturer
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        public string ManufacturerName { get; set; }
        public virtual IEnumerable<HeatingDevice> HeatingDevices { get; set; } = new List<HeatingDevice>();
    }
}
