using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Northwind.Gui.Web.Models;

namespace Northwind.Gui.Web.Pages.Orders
{
    public class CreateModel : PageModel
    {
        private readonly Northwind.Gui.Web.Models.NorthwindContext _context;

        public CreateModel(Northwind.Gui.Web.Models.NorthwindContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["CustomerId"] = new SelectList(_context.Customers, "CustomerId", "CustomerId");
        ViewData["EmployeeId"] = new SelectList(_context.Employees, "EmployeeID", "FullName");
        ViewData["ShipVia"] = new SelectList(_context.Set<Shipper>(), "ShipperId", "CompanyName");
            return Page();
        }

        [BindProperty]
        public Order Order { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Order.Add(Order);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}