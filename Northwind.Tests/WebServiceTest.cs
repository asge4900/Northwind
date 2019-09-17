using Northwind.Entities;
using Northwind.Gui.Web.Models;
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

        [Fact]
        public void ValidValueShouldChangeCurrency()
        {  
            ExchangeRate exchangeRate = new ExchangeRate(2, "BBD");

            OrderDetail orderDetail = new OrderDetail();

            orderDetail.UnitPrice = 5;
            
            double Rate = exchangeRate.Rate;

            decimal expectedValue = 10;


            decimal actualValue = orderDetail.UnitPrice * (decimal)Rate;


            Assert.Equal(expectedValue, actualValue);
        }
    }
}
