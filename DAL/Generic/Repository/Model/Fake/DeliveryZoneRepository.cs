using System.Collections.Generic;
using DAL.Fake.Generic;
using Model;

namespace DAL.Generic.Repository.Model
{
    public partial class DeliveryZoneRepository : FakeGenericRepository<DeliveryZone>, IDeliveryZoneRepository
    {
	    public DeliveryZoneRepository(): base(new FakeDeliveryZones().MyDeliveryZones)
        {
        }

        public DeliveryZoneRepository(List<DeliveryZone> myDeliveryZones): base(myDeliveryZones)
        {
        }
    }
}
       