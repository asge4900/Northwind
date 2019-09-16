using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Northwind.Gui.Web.Models
{
    public partial class CustomerCustomerDemo
    {
        public string CustomerId { get; set; }
        public string CustomerTypeId { get; set; }

        public Customer Customer { get; set; }
        public CustomerDemographic CustomerType { get; set; }
    }
}
