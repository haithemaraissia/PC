using System.Collections.Generic;
using DAL.Fake.Generic;
using Model;

namespace DAL.Generic.Repository.Model
{
    public partial class CookerDeliveryZoneRepository : FakeGenericRepository<CookerDeliveryZone>, ICookerDeliveryZoneRepository
    {
	    public CookerDeliveryZoneRepository(): base(new FakeCookerDeliveryZones().MyCookerDeliveryZones)
        {
        }

        public CookerDeliveryZoneRepository(List<CookerDeliveryZone> myCookerDeliveryZones): base(myCookerDeliveryZones)
        {
        }
    }
}
       