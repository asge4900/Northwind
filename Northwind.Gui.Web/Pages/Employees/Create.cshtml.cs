using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Northwind.Entities;
using Northwind.Gui.Web.Models;
using Northwind.Services;

namespace Northwind.Gui.Web.Pages.Employees
{
    public class CreateModel : PageModel
    {
        private readonly NorthwindContext _context;
        
        public CreateModel(NorthwindContext context, CountryService countryService)
        {
            _context = context;
            AvailableCountries = countryService.GetCountries();
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Employee Employee { get; set; }

        public ValidateAddress ValidateAddress { get; set; }

        public ValidatePhoneNumber ValidatePhoneNumber { get; set; }

        public ProfanityFilter ProfanityFilter { get; set; }

        public List<SelectListItem> AvailableCountries { get; } 

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            ValidateAddressService validateAddressService = new ValidateAddressService()
            {
                Url = $"https://api.address-validator.net/api/verify?StreetAddress={Employee.Address}&City={Employee.City}&PostalCode={Employee.PostalCode}&CountryCode={Employee.Country}&APIKey=av-9ac5150d3050177d0125f0f892cc18b8"
            };         

            ValidatePhoneNumberService validatePhoneNumberService = new ValidatePhoneNumberService()
            {
                Url = $"http://apilayer.net/api/validate?access_key=544d232503a19a4942312ba30064b3a3&number={Employee.HomePhone}&country_code={Employee.Country}"
            };

            ProfanityFilterService profanityFilterService = new ProfanityFilterService()
            {
                Url = $"https://www.purgomalum.com/service/json?text={Employee.Notes}"
            };
            

            ValidateAddress = validateAddressService.ValidateAddress();

            ValidatePhoneNumber = validatePhoneNumberService.ValidatePhoneNumber();

            ProfanityFilter = profanityFilterService.ProfanityFilter();

            bool error = false;

            
                if (ValidateAddress.Status != "VALID")
                {
                    error = true;

                    ModelState.AddModelError($"{nameof(Employee)}.{nameof(Employee.Address)}",
                                $"Addressen er ugyldig");
                }

                if (ValidatePhoneNumber.Valid != true)
                {
                    error = true;

                    ModelState.AddModelError($"{nameof(Employee)}.{nameof(Employee.HomePhone)}",
                                $"Telefonnummer er ugyldig");
                }

                Employee.Notes = ProfanityFilter.Result;

                if (error == true)
                {
                    return Page();
                }

                _context.Employees.Add(Employee);
                await _context.SaveChangesAsync();

                return RedirectToPage("./Index");           
           
        }
    }
}