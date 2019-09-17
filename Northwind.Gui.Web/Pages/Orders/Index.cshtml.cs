using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Northwind.Gui.Web.Models;
using Northwind.Gui.Web.Models.NorthwindViewModels;

namespace Northwind.Gui.Web.Pages.Orders
{
    public class IndexModel : PageModel
    {
        private readonly NorthwindContext _context;

        public IndexModel(NorthwindContext context)
        {
            _context = context;
        }

        public IList<Order> Order { get; set; }   
        public string DateSort { get; set; }

        public async Task OnGetAsync(string sortOrder, int? id)
        {
            
            DateSort = string.IsNullOrEmpty(sortOrder) ? "date" : "";

            IQueryable<Order> orderIQ = from o in _context.Order
                                              select o;
           

            switch (sortOrder)
            {                
                
                case "date":
                    orderIQ = orderIQ.OrderBy(o => o.RequiredDate);
                    break;
                default:
                    orderIQ = orderIQ.OrderByDescending(o => o.RequiredDate);
                    break;
            }

            Order = await orderIQ
                .Include(o => o.Customer)
                .Include(o => o.Employee)
                .Include(o => o.ShipViaNavigation)                                    
                .Where(o => o.ShippedDate == null).Take(25)
                .ToListAsync();          
        }
    }
}
