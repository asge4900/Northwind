using Northwind.Gui.Web.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Northwind.Tests
{
    public class EmploymentTest
    {
        [Fact]
        public void EndDateThatIsBeforeHireDateShouldCastExeption()
        {
            DateTime EndDate = new DateTime(2005, 07, 12);

            Employment employment = new Employment()
            {
                HireDate = new DateTime(2015, 03, 04)                
            };
            
            Assert.Throws<ArgumentException>(() => employment.EndDate = EndDate);
        }
    }
}
