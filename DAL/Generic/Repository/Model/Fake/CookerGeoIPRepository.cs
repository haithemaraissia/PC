using System.Collections.Generic;
using DAL.Fake.Generic;
using DAL.Fake.Model.GoodData.Cookers;
using Model;

namespace DAL.Generic.Repository.Model.Fake
{
    public class FakeCookerGeoIpRepository : FakeGenericRepository<CookerGeoIP>, ICookerGeoIPRepository
    {
	    public FakeCookerGeoIpRepository(): base(new FakeCookersGeoIps().MyCookersGeoIps)
        {
        }

        public FakeCookerGeoIpRepository(List<CookerGeoIP> myCookerGeoIPs)
            : base(myCookerGeoIPs)
        {
        }
    }
}
       