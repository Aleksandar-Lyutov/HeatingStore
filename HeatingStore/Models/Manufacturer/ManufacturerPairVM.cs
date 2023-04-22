using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HeatingStore.Models.Manufacturer
{
    public class ManufacturerPairVM
    {
        public int Id { get; set; }
        [Display(Name = "Manufacturer")]
        public string Name { get; set; }
    }
}
