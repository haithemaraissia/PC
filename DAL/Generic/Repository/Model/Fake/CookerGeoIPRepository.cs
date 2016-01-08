using System.Collections.Generic;
using DAL.Fake.Generic;
using Model;

namespace DAL.Generic.Repository.Model
{
    public partial class CookerGeoIPRepository : FakeGenericRepository<CookerGeoIP>, ICookerGeoIPRepository
    {
	    public CookerGeoIPRepository(): base(new FakeCookerGeoIPs().MyCookerGeoIPs)
        {
        }

        public CookerGeoIPRepository(List<CookerGeoIP> myCookerGeoIPs): base(myCookerGeoIPs)
        {
        }
    }
}
       