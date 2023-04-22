using HeatingStore.Models.Category;
using HeatingStore.Models.Manufacturer;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HeatingStore.Models.HeatingDevice
{
    public class HeatingDeviceEditVM
    {
        public HeatingDeviceEditVM()
        {
            Manufacturers = new List<ManufacturerPairVM>();
            Categories = new List<CategoryPairVM>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        [Display(Name = "Heating Device Name")]
        public string HeatingDeviceName { get; set; }

        [Required]
        [Display(Name = "Manufacturer")]
        public int ManufacturerId { get; set; }
        public virtual List<ManufacturerPairVM> Manufacturers { get; set; }

        [Required]
        [Display(Name = "Category")]
        public int CategoryId { get; set; }
        public virtual List<CategoryPairVM> Categories { get; set; }

        [Display(Name = "Picture")]
        public string Picture { get; set; }

        [Required]
        [Range(0, 5000)]
        [Display(Name = "Quantity")]
        public int Quantity { get; set; }
        [Required]
        [Display(Name = "Description")]
        public string Description { get; set; }

        [Required]
        [Display(Name = "Price")]
        public decimal Price { get; set; }

        [Display(Name = "Discount")]
        [DisplayFormat(DataFormatString = "{0:N0}")]
        public decimal Discount { get; set; }
    }
}
