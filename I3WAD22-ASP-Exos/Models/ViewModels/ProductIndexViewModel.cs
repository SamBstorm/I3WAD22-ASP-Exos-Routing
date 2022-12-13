using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace I3WAD22_ASP_Exos.Models.ViewModels
{
    public class ProductIndexViewModel
    {
        public List<Product> Products { get; set; }

        public int nbProduct { get => Products?.Count ?? 0; }
    }
}
