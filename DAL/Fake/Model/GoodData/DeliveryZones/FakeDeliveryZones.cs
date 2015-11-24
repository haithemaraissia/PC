using System.Collections.Generic;
using Model;

namespace DAL.Fake.Model.GoodData.DeliveryZones
{
    public class FakeDeliveryZone
    {
        public List<DeliveryZone> MyDeliveryZones;

        public FakeDeliveryZone()
        {
            InitializeDeliveryZoneList();
        }

        public void InitializeDeliveryZoneList()
        {
            MyDeliveryZones = new List<DeliveryZone> {
                FirstDeliveryZone(), 
                SecondDeliveryZone(),
                ThirdDeliveryZone(),
                FourthDeliveryZone()
            };
        }

        public DeliveryZone FirstDeliveryZone()
        {
            var firstDeliveryZone = new DeliveryZone
            {
                DeliveryId = 1,
                DeliveryName = "Region A",
                MinimumOrder = (decimal) 15.00,
                CurrencyId = 1
            };
            return firstDeliveryZone;
        }

        public DeliveryZone SecondDeliveryZone()
        {
            var secondDeliveryZone = new DeliveryZone
            {
                DeliveryId = 2,
                DeliveryName = "Region B",
                MinimumOrder = (decimal)10.00,
                CurrencyId = 1
            };
            return secondDeliveryZone;
        }

        public DeliveryZone ThirdDeliveryZone()
        {
            var thirdDeliveryZone = new DeliveryZone
            {
                DeliveryId = 3,
                DeliveryName = "Region 1",
                MinimumOrder = (decimal)20.00,
                CurrencyId = 1
            };
            return thirdDeliveryZone;
        }


        public DeliveryZone FourthDeliveryZone()
        {
            var fourthDeliveryZone = new DeliveryZone
            {
                DeliveryId = 4,
                DeliveryName = "Region 2",
                MinimumOrder = (decimal)9.99,
                CurrencyId = 1
            };
            return fourthDeliveryZone;
        }

        ~FakeDeliveryZone()
        {
            MyDeliveryZones = null;
        }
    }
}
