using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Northwind.Gui.Web.Models
{
    [Table("Employments")]
    public class Employment
    {
        private DateTime hireDate;
        private DateTime? endDate;

        public int EmploymentID { get; set; }
        public int EmployeeID { get; set; }
        
        public Employee Employee { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Ansættelsesdato")]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = false)]
        public DateTime HireDate { get => hireDate; set => hireDate = value; }

        [DataType(DataType.Date)]
        //[Display(Name = "")]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = false)]
        public DateTime? EndDate
        {
            get => endDate;
            set
            {               
                if (hireDate < value)
                {
                    endDate = value;
                }
                else
                    throw new ArgumentException("End date cant be before hire date");
            }
        }        
    }
}
