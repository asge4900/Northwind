using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Northwind.Gui.Web.Models;

namespace Northwind.Gui.Web.Pages.OrderDetails
{
    public class IndexModel : PageModel
    {
        private readonly Northwind.Gui.Web.Models.NorthwindContext _context;

        public IndexModel(Northwind.Gui.Web.Models.NorthwindContext context)
        {
            _context = context;
        }

        public IList<OrderDetail> OrderDetail { get;set; }

        public async Task OnGetAsync()
        {
            OrderDetail = await _context.OrderDetail
                .Include(o => o.Order)
                .Include(o => o.Product).ToListAsync();
        }
    }
}
