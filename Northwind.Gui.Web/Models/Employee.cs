using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Northwind.Gui.Web.Models
{
    //[Table("")]
    public class Employee
    {
        private ICollection<Employment> employments;      
        //[Column("ID")]
        //[Column(TypeName ="")]

        //[Key] is used to identify a property as the primary key when the property name is something other than classnameID or ID

        public int EmployeeID { get; set; }

        [Required(ErrorMessage = "Efternavn er påkrævet")]
        [Display(Name = "Efternavn")]
        [StringLength(20)]
        public string LastName { get; set; }        

        [Display(Name = "Fornavn")]
        [StringLength(10, ErrorMessage = "Name cannot be longer than 10 characters")]
        public string FirstName { get; set; }

        [Display(Name = "Jobtitel")]
        public string Title { get; set; }

        [Display(Name = "Titel")]
        public string TitleOfCourtesy { get; set; }
        
        [Display(Name = "Fødselsdato")]
        [DataType(DataType.Date)]        
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = false)]
        public DateTime BirthDate { get; set; }

        //[DataType(DataType.Date)]
        //[Display(Name = "Ansættelsesdato")]        
        //[DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = false)]
        //public DateTime HireDate { get; set; }

       
        public int? EmploymentID { get; set; }

        public Employment Employment { get; set; }

        [Required(ErrorMessage = "Adresse er påkrævet")]
        [Display(Name = "Adresse")]
        public string Address { get; set; }

        [Required(ErrorMessage = "By er påkrævet")]
        [Display(Name = "By")]
        public string City { get; set; }

        public string Region { get; set; }

        [Required(ErrorMessage = "Postnummer er påkrævet")]
        [Display (Name = "Postnummer")]
        public string PostalCode { get; set; }

        [Display (Name = "Land")]
        public string Country { get; set; }

        [Required(ErrorMessage = "Hjemmetelefon er påkrævet")]
        [DataType(DataType.PhoneNumber)]
        [Display (Name = "Hjemmetelefon")]
        public string HomePhone { get; set; }
        
        public string Extension { get; set; }
        //public string Photo { get; set; }

        [Display (Name = "Noter")]
        public string Notes { get; set; }

        //[DisplayFormat(NullDisplayText = "")]
        public int? ReportsTo { get; set; }

        public string PhotoPath { get; set; }

        [Display (Name = "Initialer")]
        public string Initials { get; set; }

        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }

        //[ForeignKey("ReportsTo")]
        public  Employee Boss { get; set; }
        public  ICollection<Employee> BossEmployees { get; set; }

        public ICollection<Employment> Employments { get => employments;
            set
            {
                var sortedEmployments = value.OrderBy(e => e.EmployeeID).ThenBy(e => e.HireDate).ToList();                

                for (int i = 1; i < sortedEmployments.Count; i++)
                {                    
                    if (sortedEmployments[i].HireDate < sortedEmployments[i-1].EndDate && sortedEmployments[i].EmployeeID == sortedEmployments[i-1].EmployeeID)
                    {
                        throw new ArgumentException("Dates cant overlap");
                    }
                    employments = value;
                }
                
            }
        }

        public ICollection<Order> Orders { get; set; }

        public string GetShortDescription()
        {
            if(Notes != null && Notes.Length > 40)
                return Notes.Substring(0, 40) + "...";
            return Notes;
        }
    }
}
