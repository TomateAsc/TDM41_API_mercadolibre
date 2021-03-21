using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TDM41_API_mercadolibre
{
    public class address
    {
        public string state_name { get; set; }
        public string city_name { get; set; }
    }

    public class Result
    {
        public string title { get; set; }
        public double price { get; set; }
        public string permalink { get; set; }
        public string thumbnail { get; set; }
        public address address { get; set; }
    }

    public class mercadolibre
    {
        public string site_id { get; set; }
        public string query { get; set; }
        public IList<Result> results { get; set; }
    }
}
