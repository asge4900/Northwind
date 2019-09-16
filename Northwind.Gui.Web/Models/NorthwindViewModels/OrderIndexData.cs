using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Northwind.Gui.Web.Models.NorthwindViewModels
{
    public class OrderIndexData
    {
        public IEnumerable<Order> Orders { get; set; }
        public IEnumerable<OrderDetail> OrderDetails { get; set; }
    }
}
