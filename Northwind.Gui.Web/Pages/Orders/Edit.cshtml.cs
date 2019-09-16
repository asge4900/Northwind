using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Northwind.Gui.Web.Models;

namespace Northwind.Gui.Web.Pages.Orders
{
    public class EditModel : PageModel
    {
        private readonly Northwind.Gui.Web.Models.NorthwindContext _context;

        public EditModel(Northwind.Gui.Web.Models.NorthwindContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Order Order { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Order = await _context.Order
                .Include(o => o.Customer)
                .Include(o => o.Employee)
                .Include(o => o.ShipViaNavigation).FirstOrDefaultAsync(m => m.OrderId == id);

            if (Order == null)
            {
                return NotFound();
            }
           ViewData["CustomerId"] = new SelectList(_context.Customers, "CustomerId", "CustomerId");
           ViewData["EmployeeId"] = new SelectList(_context.Employees, "EmployeeID", "FullName");
           ViewData["ShipVia"] = new SelectList(_context.Set<Shipper>(), "ShipperId", "CompanyName");
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Order).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OrderExists(Order.OrderId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool OrderExists(int id)
        {
            return _context.Order.Any(e => e.OrderId == id);
        }
    }
}
