using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Northwind.Gui.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Northwind.Gui.Web.Pages.Employees
{
    public class BossNamePageModel : PageModel
    {
        public SelectList BossNameSL { get; set; }

        public void PopulateBossesDropDownList(NorthwindContext _context,
            object selectedBoss = null)
        {
            var bossesQuery = from b in _context.Employees
                              orderby b.FullName
                              select b;
            BossNameSL = new SelectList(bossesQuery.AsNoTracking(),
                "Boss", "FullName", selectedBoss);
        }
    }
}
