using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace kassasysteemv2.Controllers
{
    public class ProductController : Controller
    {
        private readonly  ILogic.IProduct Logic = FactoryLogic.FactoryLogic.ProductLogic();
        public IActionResult Stock()
        {
            return View(Logic.Products());
        }
        //todo maak een update
        //todo maak een remove
        
    }
}