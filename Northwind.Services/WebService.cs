using Newtonsoft.Json;
using Northwind.Entities;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Services
{
    public class WebService
    {
       public string Url { get; set; }       

        public ExchangeRate GetExchangeRate()
        {
            if (!string.IsNullOrWhiteSpace(Url))
            {
                using (var client = new WebClient())
                {
                    string json = client.DownloadString(Url);
                    ExchangeRate exchangeRate = JsonConvert.DeserializeObject<ExchangeRate>(json);
                    return exchangeRate;
                }
            }
            else
            {
                throw new InvalidOperationException();
            }            
        } 
    }
}
