using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HeatingStore.Domain
{
    public class HeatingDevice
    {

        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        public string HeatingDeviceName { get; set; }
        [Required]
        public int BrandId { get; set; }
        public virtual Manufacturer Manufacturer { get; set; }
        [Required]
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public string Picture { get; set; }
        [Required]
        [Range(0, 5000)]
        public string Description { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public decimal Price { get; set; }
        public decimal Discount { get; set; }
        public virtual IEnumerable<Order> Orders { get; set; } = new List<Order>();
    }
}
