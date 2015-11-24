using System.Collections.Generic;
using Model;

namespace DAL.Fake.Model.GoodData.Cooker
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
                ThirdCookerDeliveryZone(),
                FourthCookerDeliveryZone()
            };
        }

        public CookerDeliveryZone FirstCookerDeliveryZone()
        {
            var firstCookerDeliveryZone = new CookerDeliveryZone
            {
                CookerDeliveryZoneId = 1,
                CookerId = 1,
                DeliveryId = 1
            };
            return firstCookerDeliveryZone;
        }

        public CookerDeliveryZone SecondCookerDeliveryZone()
        {
            var secondCookerDeliveryZone = new CookerDeliveryZone
            {
                CookerDeliveryZoneId = 2,
                CookerId = 1,
                DeliveryId = 2
            };
            return secondCookerDeliveryZone;
        }

        public CookerDeliveryZone ThirdCookerDeliveryZone()
        {
            var thirdCookerDeliveryZone = new CookerDeliveryZone
            {
                CookerDeliveryZoneId = 3,
                CookerId = 2,
                DeliveryId = 3
            };
            return thirdCookerDeliveryZone;
        }

        public CookerDeliveryZone FourthCookerDeliveryZone()
        {
            var fourthCookerDeliveryZone = new CookerDeliveryZone
            {
                CookerDeliveryZoneId = 4,
                CookerId = 2,
                DeliveryId = 4
            };
            return fourthCookerDeliveryZone;
        }

        ~FakeCookerDeliveryZone()
        {
            MyCookerDeliveryZones = null;
        }
    }
}
