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
    public class EditModel : PageModel
    {
        private readonly Northwind.Gui.Web.Models.NorthwindContext _context;

        public EditModel(Northwind.Gui.Web.Models.NorthwindContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Employment Employment { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Employment = await _context.Employment
                .Include(e => e.Employee).FirstOrDefaultAsync(m => m.EmploymentID == id);

            if (Employment == null)
            {
                return NotFound();
            }
           ViewData["EmployeeID"] = new SelectList(_context.Employees, "EmployeeID", "LastName");
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Employment).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EmploymentExists(Employment.EmploymentID))
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

        private bool EmploymentExists(int id)
        {
            return _context.Employment.Any(e => e.EmploymentID == id);
        }
    }
}
