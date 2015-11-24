using System.Collections.Generic;
using DAL.API;
using DAL.API.FreeGeoIP;
using Model;
using Newtonsoft.Json;

namespace DAL.Fake.Model.GoodData.Cooker
{
    public class FakeCookersGeoIps
    {
        public List<CookerGeoIP> MyCookersGeoIps;

        public FakeCookersGeoIps()
        {
            InitializeCookersGeoIpList();
        }

        #region CookerIP

        private const string BaseFreeGeopIpaddress = @"https://freegeoip.net/json/";

        private GeoIp GetGeoIpField(string ip)
        {
            var response = new ApiHelper().GetAPIResponse(BaseFreeGeopIpaddress + ip).Result;
            var ipFields = JsonConvert.DeserializeObject<GeoIp>(response);
            return ipFields;
        }

        #endregion

        public void InitializeCookersGeoIpList()
        {
            MyCookersGeoIps = new List<CookerGeoIP> {
                FirstCookersGeoIp(), 
                SecondCookersGeoIp(),
                ThirdCookersGeoIp()
            };
        }

        public CookerGeoIP FirstCookersGeoIp()
        {
            var firstCooker = GetGeoIpField("8.8.8.8");
            var firstCookersGeoIp = new CookerGeoIP
            {
                CookerId = 1,
                Ip="8.8.8.8",
                CountryCode = firstCooker.country_code,
                CountryName = firstCooker.country_name,
                RegionCode = firstCooker.region_code,
                City = firstCooker.city,
                Zipcode = firstCooker.zip_code,
                TimeZone = firstCooker.time_zone,
                Latitude = firstCooker.latitude,
                Longitude = firstCooker.longitude,
                MetroCode = firstCooker.metro_code
            };
            return firstCookersGeoIp;
        }

        public CookerGeoIP SecondCookersGeoIp()
        {
            var secondCooker = GetGeoIpField("192.168.0.0");
            var secondCookersGeoIp = new CookerGeoIP
            {
                CookerId = 2,
                Ip = "68.70.88.2",
                CountryCode = secondCooker.country_code,
                CountryName = secondCooker.country_name,
                RegionCode = secondCooker.region_code,
                City = secondCooker.city,
                Zipcode = secondCooker.zip_code,
                TimeZone = secondCooker.time_zone,
                Latitude = secondCooker.latitude,
                Longitude = secondCooker.longitude,
                MetroCode = secondCooker.metro_code
            };
            return secondCookersGeoIp;
        }

        public CookerGeoIP ThirdCookersGeoIp()
        {
            var thirdCooker = GetGeoIpField("23.42.29.19");
            var thirdCookersGeoIp = new CookerGeoIP
            {
                CookerId = 3,
                Ip = "23.42.29.19",
                CountryCode = thirdCooker.country_code,
                CountryName = thirdCooker.country_name,
                RegionCode = thirdCooker.region_code,
                City = thirdCooker.city,
                Zipcode = thirdCooker.zip_code,
                TimeZone = thirdCooker.time_zone,
                Latitude = thirdCooker.latitude,
                Longitude = thirdCooker.longitude,
                MetroCode = thirdCooker.metro_code
            };
            return thirdCookersGeoIp;
        }

        ~FakeCookersGeoIps()
        {
            MyCookersGeoIps = null;
        }
    }
}
