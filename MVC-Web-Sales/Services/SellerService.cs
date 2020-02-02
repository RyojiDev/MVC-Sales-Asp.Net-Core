using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVC_Web_Sales.Models;
using MVC_Web_Sales.Data;

namespace MVC_Web_Sales.Services
{
    public class SellerService
    {
        private readonly MVC_Web_SalesContext _context;

        public SellerService(MVC_Web_SalesContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }
    }
}
