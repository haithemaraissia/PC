using System.Collections.Generic;
using DAL.Fake.Generic;
using DAL.Fake.Model.GoodData.DeliveryZones;
using Model;

namespace DAL.Generic.Repository.Model.Fake
{
    public class FakeDeliveryZoneRepository : FakeGenericRepository<DeliveryZone>, IDeliveryZoneRepository
    {
	    public FakeDeliveryZoneRepository(): base(new FakeDeliveryZone().MyDeliveryZones)
        {
        }

        public FakeDeliveryZoneRepository(List<DeliveryZone> myDeliveryZones)
            : base(myDeliveryZones)
        {
        }
    }
}
       