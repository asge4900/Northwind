using Newtonsoft.Json;
using Northwind.Entities;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Northwind.Services
{
    public class ValidateAddressService
    {
        public string Url { get; set; }

        public ValidateAddress ValidateAddress()
        {
            if (!string.IsNullOrWhiteSpace(Url))
            {
                using (var client = new WebClient())
                {
                    string json = client.DownloadString(Url);
                    ValidateAddress validateAddress = JsonConvert.DeserializeObject<ValidateAddress>(json);
                    return validateAddress;
                }
            }
            else
                throw new InvalidOperationException();
        }
    }
}
