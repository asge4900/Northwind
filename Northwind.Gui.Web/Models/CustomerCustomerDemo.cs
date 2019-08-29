using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Northwind.Gui.Web.Models
{
    public class CustomerCustomerDemo
    {
        //Foreign key for Customer
        //public string CustermerID { get; set; }
        //public Customer Customer { get; set; }

        //Foreign Key for CustomerDemographic
        public string CustomerTypeID { get; set; }
        public CustomerDemographic CustomerDemographic { get; set; }
    }
}
