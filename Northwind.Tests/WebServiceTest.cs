using Northwind.Entities;
using Northwind.Services;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Northwind.Tests
{
    public class WebServiceTest
    {
        [Fact]
        public void InvalidUrlShouldThrowException()
        {
            WebService webService = new WebService()
            {
                Url = $""
            };

            ExchangeRate exchangeRate = new ExchangeRate(4, "BDT");           

            Assert.Throws<InvalidOperationException>(() => exchangeRate = webService.GetExchangeRate());
        }
    }
}
