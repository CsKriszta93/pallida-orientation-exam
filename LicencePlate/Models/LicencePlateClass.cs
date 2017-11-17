using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LicencePlate.Models
{
    public class LicencePlateClass
    {
        public int Id { get; set; }
        public string Plate { get; set; }
        public string Car_brand { get; set; }
        public string Car_model { get; set; }
        public string Color { get; set; }
        public int Year { get; set; }
    }
}
