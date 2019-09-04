﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Northwind.Gui.Web.Models;

namespace Northwind.Gui.Web.Pages.Employments
{
    public class DeleteModel : PageModel
    {
        private readonly Northwind.Gui.Web.Models.NorthwindContext _context;

        public DeleteModel(Northwind.Gui.Web.Models.NorthwindContext context)
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
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Employment = await _context.Employment.FindAsync(id);

            if (Employment != null)
            {
                _context.Employment.Remove(Employment);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
