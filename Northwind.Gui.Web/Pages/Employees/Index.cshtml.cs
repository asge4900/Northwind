using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Northwind.Gui.Web.Models;

namespace Northwind.Gui.Web.Pages.Employees
{
    public class IndexModel : PageModel
    {
        private readonly NorthwindContext _context;

        public IndexModel(NorthwindContext context)
        {
            _context = context;
        }
        
        public string NameSort { get; set; }
        public string DateSort { get; set; }
        public string CurrentFilter { get; set; }
        public string CurrentSort { get; set; }       

        //public IList<Employee> Employee { get;set; }

        public PaginatedList<Employee> Employee { get; set; }

        public async Task OnGetAsync(string sortOrder, string currentFilter, string seachString, int? pageIndex)
        {
            CurrentFilter = sortOrder;
            NameSort = string.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            DateSort = sortOrder == "Date" ? "date_desc" : "Date";
            if (seachString != null)
            {
                pageIndex = 1;
            }
            else
            {
                seachString = currentFilter;
            }
            CurrentFilter = seachString;

            IQueryable<Employee> employeeIQ = from e in _context.Employees
                                              select e;
            if (!string.IsNullOrEmpty(seachString))
            {                
                employeeIQ = employeeIQ.Where(e => e.FullName.Contains(seachString, StringComparison.OrdinalIgnoreCase)                                        
                                        || e.Initials.Contains(seachString, StringComparison.OrdinalIgnoreCase)
                                        //|| e.Region.Equals(seachString, StringComparison.OrdinalIgnoreCase)
                                        || e.Country.Equals(seachString, StringComparison.OrdinalIgnoreCase));
            }

            switch (sortOrder)
            {
                case "name_desc":
                    employeeIQ = employeeIQ.OrderByDescending(e => e.LastName);
                    break;
                case "Date":
                    employeeIQ = employeeIQ.OrderBy(e => e.HireDate);
                    break;
                case "date_desc":
                    employeeIQ = employeeIQ.OrderByDescending(e => e.HireDate);
                    break;
                default:
                    employeeIQ = employeeIQ.OrderBy(e => e.LastName);
                    break;
            }

            int pageSize = 3;
            Employee = await PaginatedList<Employee>.CreateAsync(
                employeeIQ.Include(e => e.Boss)
                .AsNoTracking(), pageIndex ?? 1, pageSize);

            //Employee = await employeeIQ.AsNoTracking().ToListAsync();
        }
    }
}
