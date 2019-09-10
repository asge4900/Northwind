using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Northwind.Gui.Web.Models;
using Northwind.Services;

namespace Northwind.Gui.Web.Pages.Employees
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
            return Page();
        }

        [BindProperty]
        public Employee Employee { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            //ValidatePhoneNumberService validatePhoneNumberService = new ValidatePhoneNumberService()
            //{
            //    Url = $"http://apilayer.net/api/validate?access_key=544d232503a19a4942312ba30064b3a3&number={Employee.HomePhone}&country_code=&format=1"
            //};

            _context.Employees.Add(Employee);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}