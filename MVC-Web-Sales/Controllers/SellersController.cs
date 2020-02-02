using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVC_Web_Sales.Services;
using Microsoft.AspNetCore.Mvc;

namespace MVC_Web_Sales.Controllers
{
    public class SellersController : Controller
    {
        private readonly SellerService _sellerService;

        public SellersController(SellerService sellerService)
        {
            _sellerService = sellerService;
        }
        public IActionResult Index()
        {

            var list = _sellerService.FindAll();
            return View(list);
        }
    }
}