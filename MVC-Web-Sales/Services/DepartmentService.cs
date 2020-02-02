using System.Collections.Generic;
using System.Linq;
using MVC_Web_Sales.Models;
using MVC_Web_Sales.Data;

namespace MVC_Web_Sales.Services
{
    public class DepartmentService
    {
        private readonly MVC_Web_SalesContext _context;

        public DepartmentService(MVC_Web_SalesContext context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }
    }
}
