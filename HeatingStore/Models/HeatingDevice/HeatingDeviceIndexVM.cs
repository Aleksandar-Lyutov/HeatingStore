using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HeatingStore.Models.HeatingDevice
{
    public class HeatingDeviceIndexVM
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Heating Device Name")]
        public string HeatingDeviceName { get; set; }
        public int ManufacturerId { get; set; }
        [Display(Name = "Manufacturer")]
        public string ManufacturerName { get; set; }
        public int CategoryId { get; set; }
        [Display(Name = "Category")]
        public string CategoryName { get; set; }
        [Display(Name = "Picture")]
        public string Picture { get; set; }
        [Display(Name = "Quantity")]
        public int Quantity { get; set; }
        [Display(Name = "Description")]
        public string Description { get; set; }
        [Display(Name = "Price")]
        public decimal Price { get; set; }
        [Display(Name = "Discount")]
        [DisplayFormat(DataFormatString = "{0:N0}")]
        public decimal Discount { get; set; }
    }
}
