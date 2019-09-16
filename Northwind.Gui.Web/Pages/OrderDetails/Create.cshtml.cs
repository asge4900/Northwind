using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Northwind.Gui.Web.Models;

namespace Northwind.Gui.Web.Pages.OrderDetails
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
        ViewData["OrderId"] = new SelectList(_context.Order, "OrderId", "OrderId");
        ViewData["ProductId"] = new SelectList(_context.Set<Product>(), "ProductId", "ProductId");
            return Page();
        }

        [BindProperty]
        public OrderDetail OrderDetail { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.OrderDetail.Add(OrderDetail);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}