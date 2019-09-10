using Northwind.Entities;
using Newtonsoft.Json;
using System;
using System.Net;

namespace Northwind.Services
{
    public class ValidatePhoneNumberService
    {
        public string Url { get; set; }

        public ValidatePhoneNumber ValidatePhoneNumber()
        {
            if (!string.IsNullOrWhiteSpace(Url))
            {
                using (var client = new WebClient())
                {
                    string json = client.DownloadString(Url);
                    ValidatePhoneNumber validatePhoneNumber = JsonConvert.DeserializeObject<ValidatePhoneNumber>(json);
                    return validatePhoneNumber;
                }
            }
            else
                throw new InvalidOperationException();
        } 
    }
}
