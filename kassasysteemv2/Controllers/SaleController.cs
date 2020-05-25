using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace kassasysteemv2.Controllers
{
    public class SaleController : Controller
    {
        private readonly ILogic.ISale saleLogic = FactoryLogic.FactoryLogic.SaleLogic();
            
        public IActionResult Index()
        {
            return View();
        }
    }
}