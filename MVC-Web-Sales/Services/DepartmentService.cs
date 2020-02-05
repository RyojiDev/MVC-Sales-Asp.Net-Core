using System.Collections.Generic;
using System.Linq;
using MVC_Web_Sales.Models;
using MVC_Web_Sales.Data;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MVC_Web_Sales.Services
{
    public class DepartmentService
    {
        private readonly MVC_Web_SalesContext _context;

        public DepartmentService(MVC_Web_SalesContext context)
        {
            _context = context;
        }

        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }
    }
}
