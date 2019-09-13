using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Northwind.Gui.Web.Models;

namespace Northwind.Gui.Web.Pages.Employments
{
    public class CreateModel : PageModel
    {
        private readonly NorthwindContext _context;

        public CreateModel(NorthwindContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["EmployeeID"] = new SelectList(_context.Employees, "EmployeeID", "FullName");
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

            //int lastEmploymentID = Employment.EmploymentID;           

            return RedirectToPage("./Index");
        }
    }
}