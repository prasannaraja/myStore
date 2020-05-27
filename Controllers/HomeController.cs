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

        public IActionResult GetProduct()
        {
            ConcreteCreator factory = new ConcreteCreator();
            Product products = factory.GetProduct("product");
            var PackageSlip = products.sale("Item", 3);

            return Json(PackageSlip);
        }
    }
}
