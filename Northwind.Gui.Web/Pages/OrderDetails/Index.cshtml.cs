using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Northwind.Entities;
using Northwind.Gui.Web.Models;
using Northwind.Services;

namespace Northwind.Gui.Web.Pages.OrderDetails
{
    public class IndexModel : PageModel
    {
        private readonly NorthwindContext _context;

        public IndexModel(NorthwindContext context)
        {
            _context = context;
        }

        public IList<OrderDetail> OrderDetail { get;set; }

        public ExchangeRate ExchangeRate { get; set; }
      

        public async Task OnGetAsync()
        {
            WebService webService = new WebService()
            {
                Url = $"https://openexchangerates.org/api/latest.json?app_id=384c003fabb64c4c86b8b21d985f8d7c"
            };

            ExchangeRate = webService.GetExchangeRate();

            OrderDetail = await _context.OrderDetail
                .Include(o => o.Order)
                .Include(o => o.Product).ToListAsync();
        }
    }
}
