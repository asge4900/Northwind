using Newtonsoft.Json;
using Northwind.Entities;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Northwind.Services
{
    public class ProfanityFilterService
    {
        public string Url { get; set; }

        public ProfanityFilter ProfanityFilter()
        {
            if (!string.IsNullOrWhiteSpace(Url))
            {
                using (var client = new WebClient())
                {
                    string json = client.DownloadString(Url);
                    ProfanityFilter profanityFilter = JsonConvert.DeserializeObject<ProfanityFilter>(json);
                    return profanityFilter;
                }
            }
            else
                throw new InvalidOperationException();
        }
    }
}
