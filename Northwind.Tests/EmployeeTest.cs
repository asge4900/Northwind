using Northwind.Gui.Web.Models;
using System;
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

        //[Fact]
        //public void Periodsoverlap_shouldtrowexpextion()
        //{
        //    Employment employment1 = new Employment()
        //    {
        //        EmployeeID = 1,
        //        HireDate = new DateTime(2000, 05, 10),
        //        EndDate = new DateTime(2010, 05, 05)
        //    };

        //    Employment employment2 = new Employment()
        //    {
        //        EmployeeID = 1,
        //        HireDate = new DateTime(2005, 07, 13)
        //    };

        //    Employee employee = new Employee();


        //    Assert.Throws<ArgumentException>(() => employee.Employments);
        //}
    }
}
