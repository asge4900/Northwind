using System;
using System.Collections.Generic;
using System.Text;

namespace Northwind.Entities
{
    public class ExchangeRate
    {
        private double rate;
        private string currency;

        public ExchangeRate(double rate, string currency)
        {
            Rate = rate;
            Currency = currency;
        }

        public double Rate { get => rate; set => rate = value; }
        public string Currency { get => currency; set => currency = value; }

       
    }
}
