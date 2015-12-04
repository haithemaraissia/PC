using System.Collections.Generic;
using Model;

namespace DAL.Fake.Model
{
    public class FakeServingPrices
    {
        public List<ServingPrice> MyServingPricings;

        public FakeServingPrices()
        {
            InitializeServingPricingList();
        }

        public void InitializeServingPricingList()
        {
            MyServingPricings = new List<ServingPrice> {
                FirstServingPricing(), 
                SecondServingPricing(),
                ThirdServingPricing()
            };
        }

        public ServingPrice FirstServingPricing()
        {
            var firstServingPricing = new ServingPrice
            {
                ServicePriceId = 1,
                ServingMeasurementId = 1,
                PLanId = 1,
                Price = (decimal) 19.99,
                Quantity = 1
            };
            return firstServingPricing;
        }

        public ServingPrice SecondServingPricing()
        {
            var secondServingPricing = new ServingPrice
            {
                ServicePriceId = 2,
                ServingMeasurementId = 7,
                PLanId = 1,
                Price = (decimal)14.99,
                Quantity = 2
            };
            return secondServingPricing;
        }

        public ServingPrice ThirdServingPricing()
        {
            var thirdServingPricing = new ServingPrice
            {
                ServicePriceId = 3,
                ServingMeasurementId = 8,
                PLanId = 1,
                Price = (decimal)9.99,
                Quantity = 1
            };
            return thirdServingPricing;
        }

        ~FakeServingPrices()
        {
            MyServingPricings = null;
        }
    }
}
