using I3WAD22_ASP_Exos.Models;
using I3WAD22_ASP_Exos.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace I3WAD22_ASP_Exos.Controllers
{
    public class ProductController : Controller
    {
        [ViewData]
        public string Title { get; set; }

        public ProductController()
        {
            this.Title = "Shopping";
        }

        public IActionResult Index()
        {
            Title = Title + ", faites votre choix";
            ProductIndexViewModel model = new ProductIndexViewModel();
            model.Products = new List<Product>() {
                new Product(){ Name = "Ordinateur", Price = 600M, Stock = 3},
                new Product(){ Name = "Ordinateur portable", Price = 799M, Stock = 5},
                new Product(){ Name = "Souris", Price = 12.5M, Stock = 30},
                new Product(){ Name = "Clavier", Price = 60M, Stock = 15},
                new Product(){ Name = "Smartphone", Price = 599M, Stock = 12}
            };
            return View(model);
        }
    }
}
