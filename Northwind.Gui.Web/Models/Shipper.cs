using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Northwind.Gui.Web.Models
{
    [Table("Shippers")]
    public partial class Shipper
    {
        public Shipper()
        {
            Orders = new HashSet<Order>();
        }

        public int ShipperId { get; set; }
        public string CompanyName { get; set; }
        public string Phone { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
