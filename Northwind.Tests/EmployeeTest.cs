using Northwind.Gui.Web.Models;
using Northwind.Gui.Web.Pages.Employees;
using System;
using System.Collections.Generic;
using Xunit;

namespace Northwind.Tests
{
    public class EmployeeTest
    {
        [Fact]
        public void Notes_Getshortdeciption()
        {
            Employee employee = new Employee()
            {
                Notes = "One morning, when Gregor Samsa woke from troubled."
            };

            string expected = "One morning, when Gregor Samsa woke from...";

            string actual = employee.GetShortDescription();

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("Poul", "Erik", "Poul Erik")]
        [InlineData("Knud", "Svendsen", "Knud Svendsen")]
        public void GetFullName(string firstname, string lastname, string expected)
        {
            Employee employee = new Employee()
            {
                FirstName = firstname,
                LastName = lastname
            };

            string actual = employee.FullName;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void PeriodsOverlapShouldThrowException()
        {
            Employment employment1 = new Employment()
            {
                EmployeeID = 1,
                HireDate = new DateTime(2000, 05, 10),
                EndDate = new DateTime(2010, 05, 05)
            };

            Employment employment2 = new Employment()
            {
                EmployeeID = 1,
                HireDate = new DateTime(2005, 07, 13)
            };

            Employment employment3 = new Employment()
            {
                EmployeeID = 2,
                HireDate = new DateTime(2010, 07, 13)
            };

            Employment employment4 = new Employment()
            {
                EmployeeID = 2,
                HireDate = new DateTime(2004, 07, 13),
                EndDate = new DateTime(2008, 07, 15)
            };

            Employee employee = new Employee();

            List<Employment> employments = new List<Employment>()
            {
                employment1, employment2, employment3, employment4
            };           

            Exception ex = Assert.Throws<ArgumentException>(() => employee.Employments = employments);

            Assert.Equal("Dates cant overlap", ex.Message);
        }


        [Fact]
        public void PeriodsNotOverlapShouldReturnValue()
        {
            Employment employment1 = new Employment()
            {
                EmployeeID = 1,
                HireDate = new DateTime(2000, 05, 10),
                EndDate = new DateTime(2010, 05, 05)
            };

            Employment employment2 = new Employment()
            {
                EmployeeID = 1,
                HireDate = new DateTime(2015, 07, 13)
            };

            Employment employment3 = new Employment()
            {
                EmployeeID = 2,
                HireDate = new DateTime(2010, 07, 13)
            };

            Employment employment4 = new Employment()
            {
                EmployeeID = 2,
                HireDate = new DateTime(2005, 07, 13),
                EndDate = new DateTime(2008, 07, 15)
            };

            Employee employee = new Employee();

            List<Employment> employments = new List<Employment>()
            {
                employment1, employment2, employment3, employment4
            };

            employee.Employments = employments;


            Assert.Equal(employments, employee.Employments);
        }

    }
}
