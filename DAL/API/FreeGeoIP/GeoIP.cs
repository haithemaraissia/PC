using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.API.FreeGeoIP
{
    //https://freegeoip.net/json/8.8.8.8
    public class GeoIp
    {
        public string ip { get; set; }
        public string country_code { get; set; }
        public string country_name { get; set; }
        public string region_code { get; set; }
        public string region_name { get; set; }
        public string city { get; set; }
        public string zip_code { get; set; }
        public string time_zone { get; set; }
        public float latitude { get; set; }
        public float longitude { get; set; }
        public int metro_code { get; set; }
    }

}
