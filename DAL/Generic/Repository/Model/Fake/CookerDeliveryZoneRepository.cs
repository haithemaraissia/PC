using System.Collections.Generic;
using DAL.Fake.Generic;
using DAL.Fake.Model.GoodData.Cookers;
using Model;

namespace DAL.Generic.Repository.Model.Fake
{
    public class FakeCookerDeliveryZoneRepository : FakeGenericRepository<CookerDeliveryZone>, ICookerDeliveryZoneRepository
    {
	    public FakeCookerDeliveryZoneRepository(): base(new FakeCookerDeliveryZone().MyCookerDeliveryZones)
        {
        }

        public FakeCookerDeliveryZoneRepository(List<CookerDeliveryZone> myCookerDeliveryZones)
            : base(myCookerDeliveryZones)
        {
        }
    }
}
       