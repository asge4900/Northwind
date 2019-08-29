﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Northwind.Gui.Web.Models
{
    public class Employee
    {
        //[Column("ID")]
        public int EmployeeID { get; set; }

        [Required]
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
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime BirthDate { get; set; }

        [Display(Name = "Ansættelsesdato")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime HireDate { get; set; }

        [Display(Name = "Adresse")]
        public string Address { get; set; }

        [Display(Name = "By")]
        public string City { get; set; }

        public string Region { get; set; }

        [Display (Name = "Postnummer")]
        public string PostalCode { get; set; }

        [Display (Name = "Land")]
        public string Country { get; set; }

        [Display (Name = "Hjemmetelefon")]
        public string HomePhone { get; set; }
        
        public string Extension { get; set; }
        //public string Photo { get; set; }

        [Display (Name = "Noter")]
        public string Notes { get; set; }

        //public int ReportsTo { get; set; }
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

        public string GetShortDescription()
        {
            if(Notes.Length > 40)
                return Notes.Substring(0, 40) + "...";
            return Notes;
        }
    }
}