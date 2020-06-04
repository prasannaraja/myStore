using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyStore.library;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MyStore.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Sale()
        {
            string productType = ProductType.PHYSICAL;
            ConcreteCreator factory = new ConcreteCreator();

            Product products = factory.GetProduct(productType);

            var PackageSlip = products.sale("Item", 3);

            switch (productType)
            {
                case "physical":
                    //generate packing slip
                    break;
                case "book":
                    //generate packing slip
                    break;
                case "membership":
                    //generate packing slip
                    break;
                case "Upgrade":
                    //generate packing slip
                    break;
                default:
                    break;
            }

            return Json(PackageSlip);
        }
    }
}
