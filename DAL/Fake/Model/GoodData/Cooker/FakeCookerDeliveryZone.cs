using System.Collections.Generic;
using Model;

namespace DAL.Fake.Model
{
    public class FakeCookerDeliveryZone
    {
        public List<CookerDeliveryZone> MyCookerDeliveryZones;

        public FakeCookerDeliveryZone()
        {
            InitializeCookerDeliveryZoneList();
        }

        public void InitializeCookerDeliveryZoneList()
        {
            MyCookerDeliveryZones = new List<CookerDeliveryZone> {
                FirstCookerDeliveryZone(), 
                SecondCookerDeliveryZone(),
                ThirdCookerDeliveryZone()
            };
        }

        public CookerDeliveryZone FirstCookerDeliveryZone()
        {
            var firstCookerDeliveryZone = new CookerDeliveryZone
            {
                CookerId = 1,
                DeliveryId = 1
            };
            return firstCookerDeliveryZone;
        }

        public CookerDeliveryZone SecondCookerDeliveryZone()
        {
            var secondCookerDeliveryZone = new CookerDeliveryZone
            {
                CookerId = 1,
                DeliveryId = 2
            };
            return secondCookerDeliveryZone;
        }

        public CookerDeliveryZone ThirdCookerDeliveryZone()
        {
            var thirdCookerDeliveryZone = new CookerDeliveryZone
            {
                CookerId = 2,
                DeliveryId = 3
            };
            return thirdCookerDeliveryZone;
        }

        ~FakeCookerDeliveryZone()
        {
            MyCookerDeliveryZones = null;
        }
    }
}
