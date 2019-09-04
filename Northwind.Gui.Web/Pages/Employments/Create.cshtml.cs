using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Northwind.Gui.Web.Models;

namespace Northwind.Gui.Web.Pages.Employments
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
        ViewData["EmployeeID"] = new SelectList(_context.Employees, "EmployeeID", "LastName");
            return Page();
        }

        [BindProperty]
        public Employment Employment { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Employment.Add(Employment);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}